   M S B A M L   `   `   `  ����N  JTianyue.Wpf.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Tianyue.Wpf.ControlTianyue.Wpf.Control  5      )    #Tianyue.Wpf.Control.TianyueTreeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Tianyue.Wpf.Control     5      -   5          >�Name$  uc��5   <   .��5	      � .+�5   
   ]� .+�5      �� ._�5      R� -   5        $��tvTree��5      
������ ��5      �� 5       �� 
TargetType" Q�6    .�5      ��  �� Property �@Q�
IsExpanded �� Value 6;   �� *
IsExpanded+ �� Mode$ TwoWay=�6g   5      ��5      �� 5       �� DataType'   !Tianyue.Wpf.Control.TreeViewModel"  63    �� ItemsSource 6\   ��  �� Path$ Children�$ OneWay=�.R�5      ��  ��Name$ staTree��6B   	 �� Orientation$	 
Horizontal=�6)   .+�5   "   �� -   5        
 � ToolTip
 5   +   �� *	ToolTip+
 � Tag 6G   �� *
Children+ d� 	IsChecked 6a   �� *	IsChecked+.��5!   &   �� $	 
Horizontal=�61   .+�5#   *   �� $��Center=�60   ��6K   �� *Icon+6f   �� 5%   *   ��64   �� *
NodeName+6P   5'   '   5)   #   5+       �� Triggers 5-      �� 5/   "    �� Value$
 true��6L    �� Binding 6.   �� *	IsChecked+.a�50   &   ��  �� 
TargetName$ staTree��6-    � ��
 ���� 6X   51   #   �� 53   "   $ false��6L    6.   �� *	IsChecked+.a�54   &   �� $ staTree��6-    � ��
 ���� 6X   55   #   59      5=      5?      5A      5C      5E      