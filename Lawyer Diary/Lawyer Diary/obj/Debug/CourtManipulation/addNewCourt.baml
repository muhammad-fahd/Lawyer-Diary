   M S B A M L   `   `   `  ����G  CLawyer Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lawyer_DiaryLawyer_Diary  5   	       Lawyer_Diary.addNewCourt   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Lawyer_Diary     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ Add New Court��5
   	   $	��270��6   $	��400��6,   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��2.5* �6   �� 5      $
��6.5* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��2.5* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $
��1.5* �6   �� 5      $��1* �6   .+�5   
   � $��0��6   $��3��6   .+�5      �� $"��Add new Court to your System��6   $��18(�6;   $��Bottom=�5      $��Center=�6/   
���� K�$
��Bold"�5   (   $��10q�6:   5      � 5   
   $��0��6   $��1��6   .+�5      �� $��Court Type:��6   $��16(�6*   $��Center=�5       $��Center=�6/   
���� K�5!      5"      � 5#   
   $��1��6   $��1��6   .+�5$      �� -   5        $��txtCourtType��5$      $��35��6*   $��Center=�66   $��Center=�6Q   $��15(�5%       ^� ToolTip$9 3Enter Court type (High/Sessional/Supreme Court etc)��6$   5&      � 5(   
   $��0��6   $��2��6   .+�5)      �� $��Court City:��6   $��16(�6*   $��Center=�5*      $��Center=�6/   
���� K�5+      5,      � 5-   
   $��1��6   $��2��6   .+�5.      �� -   5        $��txtCourtCity��5.      $��35��6+   $��Center=�67   $��Center=�5/      $��15(�68   $ Enter Court City��6F   50      � 51   
   $��1��6   $��3��6   .+�52      �� -   5        $��btnSaveCourt��52      $
��Save��6)   $��17(�68   
����  �$��Center=�53      $
��Left=�60   $��30 0 0 5q�6K   $��70��54      $��30��6    
�������6?   �� 55      -   5        $��btnCancelCourt��55      $��Cancel��6+   $��17(�6<   
����  �$��Center=�56      $��Right=�60   $��0 0 30 5q�6L   $��70��57      $��30��6    
�������6?   58      59      ��5:      �� 5;   
    �� EndPoint$ 0.5 , 0&�6    �� 
StartPoint$ 0.5 , 1&�61   .��5<      �  � Color$ 	CadetBlue��6   	 � Offset$	 1Q�6-   6:   � 5=      $ White��6   $	 1Q�6)   66   5>      5@      