   M S B A M L   `   `   `  ����G  CLawyer Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Lawyer_Diary.HearingsLawyer_Diary.Hearings  5      *    $Lawyer_Diary.Hearings.HearingByDates   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Lawyer_Diary.Hearings     5      -   5        .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��3* �6   �� 5      $��4* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $
��0.8* �6   .+�5   
   � $��0��6   $��0��6   $��3��6,   
���k���.+�5      �� $2��,Select Date to see the hearings on that date��6   $��15(�6K   $��Bottom=�5      $��Center=�6/   
���� K�$��DemiBold"�5   (   5      � 5   
   $��0��6   $��1��6   $��3��6,   
���k���.+�5      (  "System.Windows.Controls.DatePicker  -   5        $��dpSelectDate��5      $	��200��6-   $��Center=�69   $��Center=�6T   5      5      � 5   
   $��0��6   $��2��6   $��3��6,   $��2��6@   .+�5       &   System.Windows.Controls.DataGrid  -   5        $��completeCasesDataGrid��5          SelectionMode$ Single=�64      AlternatingRowBackground
 ���_�$��12(�6p      AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . ��5!      ��    Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Case Id��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 30* 6U   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *CaseId+6U     5%      $ Hearing Date��6)   $		 35* 6_   
 6?   �� *HearingDate+6_     5&      $ Hearing Time��6)   $		 35* 6_   
 6?   �� *HearingTime+6_   5/      50      � 51   
   $��1��6   $��4��6   .+�52      �� -   5        $��btnOpenCase��52   )   $��	Open Case��6   $��15(�6=   $��DemiBold"�6K   $��40��6a   
����  �
�������$	��180��53   :   $��Center=�6G   6i   54      55      ��56      �� 57   
    �� EndPoint$ 0.5 , 0&�6    �� 
StartPoint$ 0.5 , 1&�61   .��58      �  � Color$ 	CadetBlue��6    � Offset$ 1Q�6-   6:   � 59      $ White��6   $ 1Q�6)   66   5:      5<      