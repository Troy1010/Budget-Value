using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;

namespace Budget_Value
{
    public class SpendingsHistoryVM : ViewModelTemplate
    {
        // Init
        public ICommand ImportSpendingsCommand { get; }
        public MainVM MVM;
        public ObservableCollection<Spend> cSpendings { get; set; } = new ObservableCollection<Spend>();
        //  Constructor
        public SpendingsHistoryVM( MainVM mainVM )
        {
            //  Pass MVM to use as parent for child windows
            this.MVM = mainVM;
            //  Link Buttons to Handlers
            this.ImportSpendingsCommand = new CommandHandler(ImportSpendingsButton_Click);
        }

        //  Handler for Import Button
        public void ImportSpendingsButton_Click()
        {
            //  Prompt user for Importable Transaction File path
            //fileDialog = new System.Windows.Forms.FileDialog();
            string ImportTransactionsFilePath = "";
            OpenFileDialog browserDialog1 = new OpenFileDialog();
            browserDialog1.InitialDirectory = @"C:\Users\2troy\Downloads"; //*TOBEFIXED
            DialogResult result = browserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImportTransactionsFilePath = browserDialog1.FileName;
            }
            /*//  Display Drag-and-drop Import Box //*TOREPLACEABOVECODE
            var importView = new ImportView();
            importView.Owner = this.MVM.mainView;
            importView.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            this.MVM.mainView.IsEnabled = false;
            importView.ClipToBounds = true;
            importView.Show();*/
            //  Import file
            var oReader = new StreamReader(ImportTransactionsFilePath);
            // Doublecheck that it's a readable file
            //Incomplete
            // Import from file
            string sLine;
            string[] cWords;
            Spend vSpend;
            var cSpendingsTemp = new List<Spend>();
            while ((sLine = oReader.ReadLine()) != null)
            {
                // Establish cWords
                cWords = sLine.Split(',');
                if (cWords.Length < 5 || cWords[0] == "<Date>")
                {
                    continue;
                }
                // Parse data, Populate vSpend
                vSpend = new Spend
                {
                    vTimestamp = DateTime.Parse(cWords[0]),
                    sTitle = cWords[2]
                };
                if (cWords[3] != "")
                {
                    vSpend.dAmount = -Convert.ToDecimal(cWords[3]);
                }
                else
                {
                    vSpend.dAmount = -Convert.ToDecimal(cWords[4]);
                }
                vSpend.sAdditionalInfo = cWords[5];
                // Add vSpend to Spendings
                cSpendingsTemp.Add(vSpend);
            }
            cSpendings = cSpendings.ConcatListNoDups(cSpendingsTemp);
        }
        //  END Handler for Import Button
    }
}
