   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      G CLawyer Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lawyer_DiaryLawyer_Diary 5      (   "Lawyer_Diary.UpdateCaseNextHearing   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      0sys&clr-namespace:System;assembly=mscorlib  5      &localclr-namespace:Lawyer_Diary  5      -   5        .��5      �   � ColumnDefinitions  5   
   �� 5      $
��0.5* �6   �� 5      $��4* �6   �� 5      $��5* �6   �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��0.6* �6   �� 5      $
��0.6* �6   �� 5      $
��0.6* �6   �� 5      $
��0.2* �6   �� 5      $
��0.6* �6   �� 5      $��3* �6   .+�5   
   � $��1��6   $��0��6   $��2��6,   .+�5      �� $'��!Update the case next Hearing date��6   $��15(�6@   $��Center=�6N   
���� K�$��Center=�5   (   5      � 5    
   $��1��6   $��1��6   .+�5!      �� $��Select Case:��6   $��15(�6+   $��Center=�69   
���� K�$
��Left=�5"   (   5#      � 5$   
   $��2��6   $��1��6   .+�5%      �� -   5        $��cbCaseIdForHearing��5%      $��15(�61   $��Center=�6?   $��Center=�5&       �� Text$ Select Case��69   $��35��5'       ^� ToolTip$ Select Case from System��6#   5(      � 5*   
   $��1��6   $��2��6   .+�5+      �� $��Select Next Hearing Date:��6   $��15(�68   $��Center=�6F   
���� K�$
��Left=�5,   (   5-      � 5.   
   $��2��6   $��2��6     5/      �� 50      $	��16* �6#   �� 51      $��9* �6#   .+�53      (  "System.Windows.Controls.DatePicker  -   5        $��dpCaseNextHearingDate��53      $��Center=�66   $��29��6Q   $��15(�6]   
 �� Now   DisplayDateStart# Z 54      $# Select Case Next Hearing Date��55   "   $��2��6Y   56      � 58   
   $��1��6   $��3��6   .+�59      �� $��Select Next Hearing Time:��6   $��15(�68   $��Center=�6F   
���� K�$
��Left=�5:   (   5;      � 5<   
   $��2��6   $��3��6     5=      �� 5>      $	��16* �6#   �� 5?      $��9* �6#   .+�5A      "  Xceed.Wpf.Toolkit.TimePicker  -   5        $��dpCaseNextHearingTime��5A      $��Center=�6;   $��29��6V   $��15(�6b   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ 	ShortTime=�5B   %      EndTime$ 15:00h�68      	StartTime$
 8:00h�6H   $# Select Case Next Hearing Date��6Y   $��2��6�   5C      � 5E   
   $��1��6   $��5��6   $��2��6,   .+�5F      �� -   5        $��btnUpdateCaseHearing��5F      $
��Save��61   $	��300��6@   $��15(�6L   $��Bottom=�6Z   $��40��5G      
����  �
�������$��Center=�5H   :   6W   5I      5J      ��5K      �� 5L   
   	 �� EndPoint$	 0.5 , 0&�6   
 �� 
StartPoint$
 0.5 , 1&�61   .��5M      �  � Color$ 	CadetBlue��6    � Offset$ 1Q�6-   6:   � 5N      $ White��6   $ 1Q�6)   66   5O      5Q      