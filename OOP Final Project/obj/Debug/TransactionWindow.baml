   M S B A M L   `   `   `  ����L  HOOP Final Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OOP_ProjectOOP_Project  5   	   #    OOP_Project.TransactionWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OOP_Project     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  TransactionWindow��5	   	   $	��400��6#   $	��800��60    � 
ResizeMode$ NoResize=�6<   .��5      �  � RowDefinitions 5   
   �� 5      $
��161* �6   �� 5      $	��80* �6   �� 5      $��50 �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $��25 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $��25 �6   �� 5      .+�5   
   �� 
���iii�$��5��5      $��4��6(   �� 5   
   $��5��6   $��4��6$   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5       �  � Color$ #4ed899��6#    � Offset$
 0.09Q�63   � 5!      $ #94d0b4��6#   $	 0.5Q�63   � 5"      $ #5fc998��6#   $ 1Q�63   5#      5%      �� 5&   
   
���iii�$��4��6#   $��4��67   �� 5'   
   $��Transactions��6   $��Impact)�5(      $��40(�6$   $��0��5)      $��1��6   $��3��5*      $��Center=�5+      $��Center=�5,      �� 5-   
   $)��#Please select a transaction method.��6   $��1��5.      $��3��5/      $��Bottom=�50      $��Center=�51      $��
41,0,41,30q�6-   �� 52   
   $��Building lives with loans��6   $��DejaVu Sans Light)�53      $��15(�6/   $��0��54      $��5��6   
�������$��52,93,52,41q�56      �� 57   
   $��LOGO/Logo OOP.png��6   $	��175��58      $	��150��6   $��UniformToFill=�59      $��5��6(   $��77,125,67,71q�5:      $��4��6&   $y�Visible=�67   �� 5;   
   $��Linquere��6   $��Geometos)�5<      $��45(�6&   $��
ExtraBlack"�5=      $��0��5>      $��5��6   $��Bottom=�5?      
�������$��Center=�5A      $��
20,0,10,63q�6-   �� 5C   
   -   5        $��
loanButton��5C      $
��Loan��5D      $��2��6    $��1��5E      $��Center=�5F      $��Center=�5G      $	��120��5H      $��40��6   5I      �� 5J   
   -   5        $��paymentButton��5J      $��Payment��5K      $��2��6#   $��2��5L      $��Center=�6!   $��Center=�5M      $	��120��5N      $��40��6   5O      �� 5P   
   -   5         ��Name$ 
menuButton��5P      $��	Main Menu��5Q      $��2��6%   $��3��5R      $��Center=�5S      $��Center=�5T      $	��120��5U      $��40��6   5V      '  !MaterialDesignThemes.Wpf.PackIcon  5W   
   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]	   Kind$	 HamburgerMenu=�6"   
�������$��3��5Y   "   $��1��62   $��Center=�5Z   "   $��Center=�5[   "   $��80��5\   "   $��80��6.     5]   
   $	 Payment=�6"   
�������$��2��5_   "   $��1��62   $��Center=�5`   "   $��Center=�5a   "   $��80��5b   "   $��80��6.     5c   
   $
	 Cash=�6"   
�������$��1��5e   "   $��1��62   $��Center=�5f   "   $��Center=�5g   "   $��80��5h   "   $��80��6.   5i      5j      