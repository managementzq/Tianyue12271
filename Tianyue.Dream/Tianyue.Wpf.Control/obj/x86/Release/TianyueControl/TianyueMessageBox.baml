   M S B A M L   `   `   `  ���� N  JTianyue.Wpf.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Tianyue.Wpf.ControlTianyue.Wpf.Control  +    %Tianyue.Wpf.Control.TianyueMessageBox   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     R NMicrosoft.Windows.Shell, Version=3.0.1.0, Culture=neutral, PublicKeyToken=nullKshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  -local!clr-namespace:Tianyue.Wpf.Control  -   $   Tianyue.Wpf.Control.WindowBase   Name$  mb�� � WindowStartupLocation$ CenterOwner=�   MaxboxEnable .     MinboxEnable .   � 
ResizeMode$ NoResize=�   
VectorIcon$	 �� � Title$ 
MessageBox�� � ShowInTaskbar .   � SizeToContent$ WidthAndHeight=�   DefaultWindowStyle#��[  	   CaptionHeight$	 24Q�
 J� InputBindings
 �� 
 �� Key$ Escape��,  &Microsoft.Windows.Shell.SystemCommands   CloseWindowCommand �� Command# Z .��� .+�� $��5,8,5,5q� � RowDefinitions �� $��* ��� $��60 � � ColumnDefinitions �� $	��100 ��� $��* �.+��� -    ��Name$ ficon��$��Right=�$��80(�$	����  
VectorIcon#��[ $��5q����� *
Foreground+ �� ElementName$ mb���� -   $ 
txtMessage��$��1��$��Center=�$
��Left=�$
��Wrap=�$��
5,20,10,20q�$	��260��$	��420������ *
Foreground+$ mb������ *
FontSize+$ mb����新建一个WPF程序在Windows8下面就会出现左边的窗口边框，颜色取决于Windows主题我想在想创建一个右边那样的窗口，要么是窄边，要么没有边��  �� Orientation$ 
Horizontal=�$	��Top=�$��1q�$��0��$��1��$��2��$��Center=�.+�'   !Tianyue.Wpf.Control.TianyueButton  -     Name$ btnOK��'   !Tianyue.Wpf.Control.TianyueButton   Click$ btnOK_Click��   
VectorIcon$	 ��$��85��$��30��   CornerRadius$ 0��$��5,5,20,5q�.��确定  -   $ 	btnCancel��$ btnCancel_Click��$	 ��$��85��$��30��$ 0��$��	20,5,10,5q�.��取消