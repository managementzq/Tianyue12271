   M S B A M L   `   `   `  ���� N  JTianyue.Wpf.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Tianyue.Wpf.ControlTianyue.Wpf.Control  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NMicrosoft.Windows.Shell, Version=3.0.1.0, Culture=neutral, PublicKeyToken=null   BaseWindowStyle  �� 
TargetType$    Tianyue.Wpf.Control.WindowBase �� Property  WindowBackground �� Value  TextForeground  FontSize  
FontFamily  WindowBorderBrush  CaptionBackground  CaptionForeground/   )Tianyue.Wpf.Control.ControlAttachProperty*  $Microsoft.Windows.Shell.WindowChrome   ResizeBorderThickness   CaptionHeight �� Path �� RelativeSource �� AncestorType �� 
TargetType	 ��Name
   CornerRadius �� CornerRadius  WindowDropShadow J� Effect J� SnapsToDevicePixels 	 WindowInnerBackground    CaptionHeight �� Orientation'   !Tianyue.Wpf.Control.TianyueButton  Name 
 TianyueButton_Transparency   
VectorIcon   VectorIconSize   IsHitTestVisibleInChrome    CaptionForeground*   $Tianyue.Wpf.Control.TianyueConverter#   BooleanToVisibilityConverter �� 	Converter   CornerRadius   MouseOverBackground   MouseOverForeground   PressedBackground   PressedForeground   AllowsAnimation   VectorIconMargin �� Triggers P� Property  P� Value! �� 
TargetName  NoTransparencyWindowStyle  DefaultWindowStyle" � RowDefinitions#    CaptionBackground$ � ColumnDefinitions% ��Name  
VectorIcon&    VectorIconSize'    
VectorIcon  HeaderFontSize( � Title�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     Kshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  +local!clr-namespace:Tianyue.Wpf.Control  %O  &	        7  7  7  7  7  7  7  7  7 	 7 
 7 
 7 
 &	 �    7  7  7  7  7  7  7  7 	 7 
 7 
 7 
 &	 �    7  7  7  7  7  7  7  7  7 	 7  7  7 
 7 
 7 
 �� "    .���  � ��8   ��  � ��8  ��  � ��8  ��  � ��8  ��  � ��$	 480����  � ��$	 320����  � ��8  ��  � ��$ 1q���  �@J�SnapsToDevicePixels . ��  �@  VectorIconSize$ 20Q���  �@  CaptionHeight$ 26Q���  �@�
ResizeMode$ CanResizeWithGrip=���  �@  CaptionBackground8  ��  �@  CaptionForeground8  ��  �@  
VectorIcon$	 ����  �@  MaxboxEnable . ��  �@  MinboxEnable . ��  � ��$ 3q���  �@ CornerRadius$ 0����  �@ WindowChrome   $ 8q� �� $ CaptionHeight� �� *FindAncestor+"   ��  � �� �� "   .R�� $��6q�.+��� $	 Bg��# z
 #��z��#��z��8  #��z��# z �� $	 BgInner��# z
 8�� #��z��# z �� .u��� $��1q�#��z���� $	��Top=�#��z $
��Auto��$��1q�$��Right=�._��� $ 
Horizontal=�#��z��$��30��.+�  $ btnMin��$��26��$��Center=�$��1,2,1,2q�8��	 $	 ��$ 16�� . #��z y��� $ MinboxEnable� �� *TemplatedParent+# Z ���� $ MinimizeWindowCommand� �� *TemplatedParent+  $ btnMax��$��26��$��Center=�$��1,2,1,2q�8��
 $	 ��$ 16�� . #��z y��� $ MaxboxEnable� �� *TemplatedParent+# Z ���� $ MaximizeWindowCommand� �� *TemplatedParent+  $ btnClose��$��38��$��Center=�$��1,2,3,2q�$ 0��
 �  ��
 ����� �#AA0D0D
 ����� . 8�� $	 ��$ 16�� . $ 0q�#��z ���� $ CloseWindowCommand� �� *TemplatedParent+ P�  �@�WindowState$  	Maximized=�. ��� $! btnMax�� �@ 
VectorIcon$	 ��P�  �@�WindowState$  Normal=�. ��� $! btnMax�� �@ 
VectorIcon$	 ���� "    .���  � ��8   ��  � ��8  ��  � ��8  ��  � ��8  ��  � ��$	 480����  � ��$	 320����  � ��8  ��  � ��$ 0q���  �@J�SnapsToDevicePixels . ��  �@  VectorIconSize$ 20Q���  �@  CaptionHeight$ 26Q���  �@�
ResizeMode$ NoResize=���  �@�WindowState$ 	Maximized=���  �@  CaptionBackground8  ��  �@  CaptionForeground8  ��  �@  
VectorIcon$	 ����  �@  MaxboxEnable .  ��  �@  MinboxEnable . ��  � ��$ 0q���  �@ CornerRadius$ 0����  � �� �� "   .R�� .+��� $	 Bg��# z
 #��z��#��z��#��z��# z �� $	 BgInner��# z
 8�� #��z��# z �� .u��� #��z��#��z���� $	��Top=�#��z $
��Auto��$��1q�$��Right=�._��� $ 
Horizontal=�#��z��$��30��.+�  $ btnMin��$��26��$��Center=�$��1,2,1,2q�#��z 8�� $	 ��$ 16��y��� $ MinboxEnable� �� *TemplatedParent+# Z ���� $ MinimizeWindowCommand� �� *TemplatedParent+  $ btnMax��$��26��$��Center=�$��1,2,1,2q�#��z 8��	 $	 ��$ 16��y��� $ MaxboxEnable� �� *TemplatedParent+# Z ���� $ MaximizeWindowCommand� �� *TemplatedParent+  $ btnClose��$��38��$��Center=�$��24��$��1,2,3,2q�$ 0��#��z 
 �  ��
 ����� �#AA0D0D
 ����� . 8��
 $	 ��$ 16������ $ CloseWindowCommand� �� *TemplatedParent+ P�  �@�WindowState$  	Maximized=�. ��� $! btnMax�� �@ 
VectorIcon$	 ��P�  �@�WindowState$  Normal=�. ��� $! btnMax�� �@ 
VectorIcon$	 ���� "    .���  � ��8   ��  � ��8  ��  � ��8  ��  � ��8  ��  � ��$	 480����  � ��$	 320����  � ��8  ��  � ��$ 1q���  �@J�SnapsToDevicePixels . ��  �@  VectorIconSize$ 20Q���  �@  CaptionHeight$ 26Q���  �@�
ResizeMode$ CanResizeWithGrip=���  �@  CaptionBackground8  ��  �@  CaptionForeground8  ��  �@  
VectorIcon$	 ����  �@  MaxboxEnable . ��  �@  MinboxEnable . ��  � ��$ 3q���  �@ CornerRadius$ 0����  �@ WindowChrome   $ 8q� �� $ CaptionHeight� �� *FindAncestor+"   ��  � �� �� "   .R�� $��6q�.+��� $	 Bg��# z
 #��z��#��z��8  #��z��# z �� $	 BgInner��# z
 8�� #��z��# z � $��1q�" �� $��18��$
��Auto ��� $��* �.+��� $��0q�$��0��#��z# ._�� $��2,1,2,0q�$ �� $��* ��� $
��Auto �.+��� $% PART_Header��#��z $��5,1,5,1q�$ 
Horizontal=�$��Center=�.+��� 8��	 #��z #��z& #��z' �� $��Center=�$��5q�8��
 #��z #��z( �� $��1��$ 
Horizontal=�$	��Top=�$��1q�$��Right=�#��z .+�  $ btnMin��$��26��$��Center=�$��1q�8�� $	 ��$ 14�� . #��z y��� $ MinboxEnable� �� *TemplatedParent+# Z ���� $ MinimizeWindowCommand� �� *TemplatedParent+  $ btnMax��$��26��$��Center=�$��1q�8�� $	 ��$ 14�� . #��z y��� $ MaxboxEnable� �� *TemplatedParent+# Z ���� $ MaximizeWindowCommand� �� *TemplatedParent+  $ btnClose��$��35��$��Center=�$��1q�$ 0��$��1 2 1 2q�
 �  ��
 ����� �#AA0D0D
 ����� . 8�� $	 ��$ 14�� . $ 0q�#��z ���� $ CloseWindowCommand� �� *TemplatedParent+�� $��1��$��3,0,3,3q�.u��� #��z�� P�  �@�WindowState$  	Maximized=�. ��� $! btnMax�� �@ 
VectorIcon$	 ��P�  �@�WindowState$  Normal=�. ��� $! btnMax�� �@ 
VectorIcon$	 ��