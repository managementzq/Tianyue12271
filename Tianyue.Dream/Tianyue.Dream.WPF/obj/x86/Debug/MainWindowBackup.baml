   M S B A M L   `   `   `  ����L  HTianyue.Dream.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Tianyue.Dream.WPFTianyue.Dream.WPF  5   	   N JTianyue.Wpf.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:Tianyue.Wpf.Control;assembly=Tianyue.Wpf.ControlTianyue.Wpf.Control 5   	   (    "Tianyue.Dream.WPF.MainWindowBackup   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Tianyue.Dream.WPF     5   	   Nxly>clr-namespace:Tianyue.Wpf.Control;assembly=Tianyue.Wpf.Control     5   	     � Title$  
MainWindow��5	   	    � WindowStartupLocation$ CenterScreen=�6    � WindowState$ 	Maximized=�5
   	    � 
ResizeMode$ NoResize=�6!    � WindowStyle$
 None=�67    � 	Resources 5       �� 
TargetType �� Property   WindowBackground �� Value��%�   '��       7   '� D     7   �� 5   
   " ��6   .�5      ��  � ��8   6+   5      �� 5   
   " �6   .�5      ��  � ��8   6+   5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��60 �6   6*   �� 5      $��1* �6   6*   .+�5   
   � $��0��6   
 � ColumnDefinitions
 5      �� 5       $	��200 �6#   61   �� 5!      $��1* �6#   60   �� 5"      $	��180 �6#   61   .+�5%      � $��0��6   
 5'      �� 5(      $��60 �6'   64   �� 5)      $��2* �6'   64   .+�5,      �� $��0��6   $��60��6-   .+�5.      �� $��0��6   $��Resources\Decepticon.png��6.   6R   51      53      �� 55      $��1��6    �� Orientation$ 
Horizontal=�6)   57      � 59      $��2��6   
 5;      �� 5<      $��1* �6'   64   �� 5=      $��1* �6'   64   �� 5>      $��1* �6'   64   .+�5A      '  !Tianyue.Wpf.Control.TianyueButton  -   5        $��
btnProfile��5A   4   $��0��6$      VectorIconSize$ 45��6F      
VectorIcon$	 ��6Z   $��3q�6p     TianyueButton_Transparency#��[ 6{   6�     5B      -   5        $��btnMinimize��5B   4   $��1��6$   $ 45��6G   $	 ��6[   $��3q�6q   #��[ 6|   6�     5C      -   5        $��btnExit��5C   4   $��2��6$   $ 45��6C   $	 ��6W   $��3q�6m   #��[ 6x   6�   5E      5G      � 5I   
   $��1��6   
 5L      �� 5M      $	��200 �6#   61   �� 5N      $��1* �6#   60   .+�5Q      �� $��0��6   $ 
Horizontal=�6)   5S       � 5U      -   5          �Name$ PageContext��5U      $��1��6)   
����  �$��1q�6L     � NavigationUIVisibility$ Visible=�6`   5W      5Y      5[      