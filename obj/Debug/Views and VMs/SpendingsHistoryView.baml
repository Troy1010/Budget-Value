   M S B A M L   `   `   `  ����G  CBudget Value, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Budget_ValueBudget_Value  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      '    !Budget_Value.SpendingsHistoryView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Budget_Value     5      9system&clr-namespace:System;assembly=mscorlib     5      .��5
      �   � DataContext  6   �� *SpendingsHistory+ � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   `� $��0��6    `� 
Background
 �����$��30��69   $	��Top=�6E   .�5      c� $	��500��6   $��30��6"   
����d�.@�5      �� 
����·�$��Import��6^   ��6   �� *ImportSpendingsCommand+6^   �� 5      
����·�$"��Catagorize Unassigned Spends��63   5      5      �� 5   
   $��1��6   $
��Auto=�6$   $
��Auto=�6G   .��5      �� ��6   �� *
cSpendings+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "    z� SharedSizeGroup$
 Col1��63   $
��Auto �6J   �� 5   "   $
 Col1��63   $
��Auto �6J   �� 5   "   $
 Col1��63   $
��Auto �6J   �� 5   "   $
 Col1��63   $
��Auto �6J   �� 5   "   $
 Col1��63   $
��Auto �6J   .+�5!      �� $��0��6(   ��68   �� *
vTimestamp+�� 5"      $��0��6%   $��Right=�65   $��1q�6Q   
���   �6e   �� 5#      $��1��6(   ��68   �� *sTitle+�� 5$      $��1��6%   $��Right=�65   $��1q�6Q   
���   �6e   �� 5%      $��2��6(   ��68   �� *	dAmount+�� 5&      $��2��6%   $��Right=�65   $��1q�6Q   
���   �6e   �� 5'      $��3��6(   ��68   �� *	sCatagory+�� 5(      $��3��6%   $��Right=�65   $��1q�6Q   
���   �6e   �� 5)      $��4��6(   ��68   �� *sAdditionalInfo+�� 5*      $��4��6%   $��Right=�65   $��1q�6Q   
���   �6e   5+      5,      5.      5/      50      51      