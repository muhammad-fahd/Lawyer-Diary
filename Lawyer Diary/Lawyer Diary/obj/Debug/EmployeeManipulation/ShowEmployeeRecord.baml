   M S B A M L   `   `   `  ����G  CLawyer Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lawyer_DiaryLawyer_Diary  5      %    Lawyer_Diary.ShowEmployeeRecord   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Lawyer_Diary     5      -   5        .��5	      �   � ColumnDefinitions  5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��90* �6   �� 5      $	��10* �6   .+�5   
   � $��0��6   $��2��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��employeeDataGrid��5         AlternatingRowBackground
 ���_�   
IsReadOnly . $��12(�5         AutoGenerateColumns .     CanUserDeleteRows .  ��6!   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	User Name��6F      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.1* 6Y   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� *
userName+6Y     5      $
 Name��6B   $
 1.3* 6P   	 6)   �� *name+6P     5      $ Email��6C   $
 1.3* 6R   	 6)   �� *email+6R     5      $ Contact��6E   $
 1.3* 6V   	 6)   �� *	Contact+6V     5      $
 Role��6O   $
 1.3* 6]   	 6)   �� *UserRole.roleName+6]   5      5      � 5   
   $��1��6   $��2��6   $��0��60   .+�5       �� -   5        $��btnEmployeeDelete��5    &   $��Delete��6   $	��200��6?   $��17(�6K   $��40��6Y   $��Center=�5!      $��Center=�60   
����  �
�������$��DemiBold"�5"   (   $��10 0 0 0q�6>   6P   5#      5$      5%      