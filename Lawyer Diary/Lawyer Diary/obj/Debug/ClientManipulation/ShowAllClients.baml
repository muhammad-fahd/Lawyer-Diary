   M S B A M L   `   `   `  ����G  CLawyer Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lawyer_DiaryLawyer_Diary  5      !    Lawyer_Diary.ShowAllClients   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Lawyer_Diary     5      -   5        .��5	      �   � ColumnDefinitions  5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��90* �6   �� 5      $	��10* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��clientDataGrid��5      $��0��6)   $��2��66      AlternatingRowBackground
 ���_�$��12(�6o      AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . ��5      ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
NameColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Client Name     ��5   X      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6r   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *
ClientName+6r     5      -   5        FnameColumn��$ Client Father Name��5   Z   $ 1* 6v   	 6:   �� *ClientFname+6v     5      -   5        ContactColumn��$ Contact#��5   ^   $ 1* 6p   	 6<   �� *ClientContact+6p     5      -   5        AddressColumn��$ Address��5   ^   $ 1* 6o   	 6<   �� *ClientAddress+6o   5      � 5   
   $��1��6   .+�5      �� -   5        $��btnClientUpdate��5   &   $��Update��6   $	��180��6=   $��17(�6I   $��40��6W   $��Center=�6d   $��Right=�5       
����  �
�������$��DemiBold"�6V   $��0 0 10 0q�6l   6~   5!      � 5"   
   $��1��6   $��1��6   .+�5#      �� -   5        $��btnClientDelete��5#   &   $��Delete��6   $	��180��6=   $��17(�6I   $��40��6W   $��Center=�6d   $
��Left=�5$      
����  �
�������$��DemiBold"�6U   $��10 0 0 0q�6k   6}   5%      5(      ��5)      �� 5*   
   
 �� EndPoint$
 0.5 , 0&�6    �� 
StartPoint$ 0.5 , 1&�61   .��5+      �  � Color$ 	CadetBlue��6    � Offset$ 0Q�6-   6:   � 5,      $ White��6   $ 1Q�6)   66   5-      5/      