   M S B A M L   `   `   `  ���� L  HTianyue.Dream.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Tianyue.Dream.WPFTianyue.Dream.WPF  N JTianyue.Wpf.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:Tianyue.Wpf.Control;assembly=Tianyue.Wpf.ControlTianyue.Wpf.Control #    Tianyue.Dream.WPF.LoginWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Tianyue.Dream.WPF     Nxly>clr-namespace:Tianyue.Wpf.Control;assembly=Tianyue.Wpf.Control       � Title$  LoginWindow��$	��768��$
��1024�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � 	Resources  �� 
TargetType �� Property �� Value   WindowBackground��%�   '��       7   �� " ��.���  � ��$ 80����  � ��$ 3q���  �@��Orientation$ 
Horizontal=���  � ��8   .��� .+��� $&�� Resources\LoginMaxBackground.png��$
��Fill=�� 	 � RowDefinitions	 �� $��8* ��� $	��354 ��� $��2* �.+�� $��1��$��444px��$��	500,0,0,0q�.+��� $#��Resources\LoginBackground.png��
 J� Opacity$	
 0.3Q�� 	 �� $��3* ��� $��3* ��� $��3* � � ColumnDefinitions .+��� $	��200��$��30��$��3q�/  )Tianyue.Wpf.Control.ControlAttachProperty   	Watermark$ 请输入爱好��  LabelClearButtonTextBox#��[    Label$ 	爱好：��� $��1��.+�� 	 �� $��2* ��� $��1* �.+��  �� $��6* ��� $��8* ��� $��5* �.+��� $��Right=�$��0��$��Resources\PassWord.png��$
��30px��G� -    G�Name$ txtPassword��$��1��$
��30px��$��15(�$��Center=��� -    ��Name$ lblMsg��$��1��$��Center=�
���  ��� $��2��	 �� $��1* ��� $��3* ��� $��1* ��� $��4* � �� $��4* ��� $��1* ��� $��4* �.+��� $��0��$��3��$��0q�$��2��
���   ��� $��2��$��3��$��0q�$��2��
���   �