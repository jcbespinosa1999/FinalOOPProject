   M S B A M L   `   `   `  ����L  HOOP Final Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OOP_ProjectOOP_Project  5   	       OOP_Project.PaymentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:OOP_Project  5   	     � Title$  PaymentWindow��5	   	   $	��300��6   $	��300��6,   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��227* �6   .+�5   
   �� 
���iii�$��4��6#   $��2��64   �� 5   
   $��Pin Verification��6   $��Impact)�5      $��24(�6$   $��Center=�5      $
��Left=�6+   $��0��5      $��2��6   $��
18,10,0,18q�61   �� 5   
   -   5        $��	txtVerify��5      $��50��5      $	��120��6   $��Center=�5      $��Center=�5       �� TextWrapping$
 Wrap=�5      $��2��6&   $��1��5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Enter Pin��5!       %  !MaterialDesignFloatingHintTextBox#��[  5"      
�������5#      �� 5$   
   -   5        $��45��5$      $��Verify��6   $	��100��5%      $��Center=�6   $��Center=�5&      $��2��5(      $��2��6%   �� 5)   
   -   5        $��Cancel��5)      $��Center=�5*      $	��Top=�5+      $��76��5,      $��2��5.      $��3��6%   '  !MaterialDesignThemes.Wpf.PackIcon  5/   
   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$	 Key=�6"   $��30��50   "   $��30��6.   $��Center=�51   "   $��Center=�52   "   $��0��53   "   $��1��62   
�������54   "   55      56      