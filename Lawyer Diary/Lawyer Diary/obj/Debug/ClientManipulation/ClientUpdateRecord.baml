   M S B A M L   `   `   `  ����G  CLawyer Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lawyer_DiaryLawyer_Diary  5      %    Lawyer_Diary.ClientUpdateRecord   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      &localclr-namespace:Lawyer_Diary  5      -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Update Student Record��5
      $	��450��6,   $	��400��69   .��5       �  � ColumnDefinitions 5!   
   �� 5"      $	��10* �6   �� 5#      $	��50* �6   �� 5$      $	��55* �6   �� 5%      $	��10* �6    � RowDefinitions 5'   
   �� 5(      $	��20* �6   �� 5)      $	��12* �6   �� 5*      $	��12* �6   �� 5+      $	��12* �6   �� 5,      $	��12* �6   �� 5-      $	��12* �6   �� 5.      $	��15* �6   �� 5/      $	��10* �6   �� 50      $	��10* �6   .+�53   
   � $��0��6   $��1��6   $��2��6,   .+�54      �� $��Update Client Profile��6   $��15(�64   $��Center=�6B   $��Center=�6]   
���� K�55      56      � 57   
   $��1��6   $��1��6   .+�58      �� $��CNIC:��6   $��15(�6$   $��Center=�62   
���� K�$
��Left=�59   (   5:      � 5;   
   $��1��6   $��2��6   .+�5<      %  Xceed.Wpf.Toolkit.MaskedTextBox  -   5        $��txtClientCNIC��5<   !   {�.     Mask$ 00000-0000000-0��6H   $��15(�5=   ;   $��Center=�6I   $��Center=�5>   !   $��30��6C    ^� ToolTip$ 
Enter CNIC��5?   !   ��5=   !   �� *
ClientId+.��5?   F   5@      5A      � 5C   
   $��2��6   $��1��6   .+�5D      �� $��Client Name:��6   $��15(�6+   
���� K�$��Center=�5E      $
��Left=�6/   5F      � 5G   
   $��2��6   $��2��6   .+�5H      �� -   5        $��txtClientName��5H      $��15(�6+   $��Center=�69   $��Center=�5I      $��30��61   $ Enter Client Name��6=   ��5H   [   �� *
ClientName+.��5I   h   5J      5K      � 5M   
   $��3��6   $��1��6   .+�5N      �� $��Father Name:��6   $��15(�6+   $��Center=�69   
���� K�$
��Left=�5O   (   5P      � 5Q   
   $��3��6   $��2��6   .+�5R      �� -   5        $��txtClientFname��5R      $��15(�6I   $��Center=�6W   $��Center=�5S      $��30��61   $ Enter Client Father Name��6=   ��5R   ,   �� *ClientFname+5S   =   5T      � 5U   
   $��4��6   $��1��6   .+�5V      �� $��Phone Number:��6   $��15(�6,   $��Center=�6:   
���� K�$
��Left=�5W   (   5X      � 5Y   
   $��4��6   $��2��6   .+�5Z        -   5        $��txtClientContact��5Z   5   $ 9999-9999999��6!   $��15(�6l   $��Center=�5[   !   $��Center=�6<   $��30��6^   $ Enter Contact��5\   !   ��5Z   M   �� *ClientContact+5\   !   5]      � 5_   
   $��5��6   $��1��6   .+�5`      �� $��Address:��6   $��15(�6'   $��Center=�65   $
��Left=�5a      
���� K�6/   5b      � 5c   
   $��5��6   $��2��6   $��2��6,   .+�5d      #  Xceed.Wpf.Toolkit.RichTextBox  -   5        $��txtClientAddress��5d      $��15(�6W   $��Center=�6e   $��80��5e      $  Type Complete Address here��6"      Text 5d   8   �� *ClientAddress+   TextFormatter 5f      *  $Xceed.Wpf.Toolkit.PlainTextFormatter  5g      5i      5j      � 5l   
   $��7��6   $��1��6   $��2��6,   .+�5m      �� -   5        $��btnClientSave��5m   $   $
��Save��6   $	��180��69   $��17(�6E   $��35��6S   $��Bottom=�6`   $��Center=�5n      
����  �
�������6W   5o      5p      ��5q      �� 5r   
    �� EndPoint$ 0.5 , 0&�6   	 �� 
StartPoint$	 0.5 , 1&�61   .��5s      � 
 � Color$
 	CadetBlue��6    � Offset$ 1Q�6-   6:   � 5t      $
 White��6   $ 1Q�6)   66   5u      5w      