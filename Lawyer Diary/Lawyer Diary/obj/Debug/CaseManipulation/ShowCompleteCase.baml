   M S B A M L   `   `   `  ����G  CLawyer Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lawyer_DiaryLawyer_Diary  5      #    Lawyer_Diary.ShowCompleteCase   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      &localclr-namespace:Lawyer_Diary  5      -   5        .��5
      �   � ColumnDefinitions  5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��0.6* �6   �� 5      $
��8.6* �6   �� 5      $
��0.8* �6   .+�5   
   � $��0��6   $��0��6     5      �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $
��0.5* �6#   .+�5      � $��0��6   
���k���.+�5      �� $��Complete Cases Table��6   $��15(�67   $��Bottom=�5      $��Center=�6/   
���� K�$��DemiBold"�5   (   5      � 5      $��1��6   .+�5      %  Xceed.Wpf.Toolkit.MaskedTextBox  -   5        $��txtSearchBox��5   %   $��3q�69      Mask$ 00000-0000000-0��6D   $��15(�6\   
���� K� ^� ToolTip$ 
Enter CNIC��5    %   .��6h   5!      5"      � 5#      $��2��6   $��0��6#   .+�5$      �� -   5        $��btnSearchBox��5$   *   $��Search��6   $��14(�6?   $��3q�6M   
����  �
�������$��DemiBold"�5%   ;   6Q   5&      5'      � 5)   
   $��0��6   $��1��6   .+�5*   
   &   System.Windows.Controls.DataGrid  -   5        $��completeCasesDataGrid��5*         SelectionMode$ Single=�60      AlternatingRowBackground
 ���_�$��12(�6l      AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . ��5+      �� 	   Columns	 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn
   Header$
 CaseID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.1* 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *CaseId+6T     5/      $
 	Plaintiff��6)   $
 1.2* 6Z    6<   �� *	Plaintiff+6Z     50      $
 Defender��6)   $
 1.2* 6X    6;   �� *
Defender+6X     51      $

 Type��6)   $
 1.2* 6T    67   �� *
CaseType+6T     52      $
 Case Discription��6)   $ 5* 6g    6C   �� *CaseDiscription+6g     53      $
 Client CNIC��6)   $
 1.5* 6[    6>   �� *
ClientId+6[   55      56      � 57   
   $��0��6   $��2��6     58      �� 59      $��1* �6#   �� 5:      $��1* �6#   �� 5;      $��1* �6#   .+�5=      � $��0��6   .+�5>      �� -   5        $��btnPrintCase��5>   .   $��
Print Case��6   $��15(�6C   $��DemiBold"�6Q   
����  �
�������$	��150��5?   :   $��37��6F   $��Center=�6R   $��Center=�5@      67   5B      � 5C      $��1��6   .+�5D      �� -   5        $��btnOpenCase��5D   -   $��	Open Case��6   $��15(�6A   $��DemiBold"�6O   
����  �
�������$	��150��5E   :   $��37��6F   $��Center=�6R   $��Center=�5F      67   5G      � 5H      $��3��6   .+�5I      �� -   5        $��btnDeleteCase��5I   /   $��Delete Case��6   $��15(�6E   $��DemiBold"�6S   
����  �
�������$	��150��5J   :   $��37��6F   $��Center=�6R   $��Center=�5K      67   5L      5W      5Y      5Z      