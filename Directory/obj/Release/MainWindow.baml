   M S B A M L   `   `   `  ���� D  @Directory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Directory	Directory  d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF     Directory.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Directory     `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF       � Title$!  Головна панель��$	��650��$
��1180�� � 
ResizeMode$ NoResize=� � Icon$ Assets\earth.ico��.��� 
����İ�.+�'  !Microsoft.Maps.MapControl.WPF.Map  -     Name$	 map��+  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AttsGkqIHCOIEA11KtQZDphl5bi8lppin64jeg-ZOOhiS4cdHA_EXJwHSbyZi4Xo    Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$
 Road $��0��$��1��   	ZoomLevel$ 8Q�   Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 50.1870304,30.6606103 $��640,60,29,91q����#0ccea7$��2q�o� $��30��$	��Top=�$��2��.@�m� $��Feedback��.@�m� $ ��illia.tereshchenko@nure.ua��m� $��Version��.@�m� $��v1.06��m� $��License��.@�m� $��©Directory��m� -   $
��Help��`� $	��Top=�$��Right=�$��30��$��1��.�c� $��25��$��Right=�.@��� -    ��Name$ 
Search_Box��$	��100��.��Поиск...c� .@��� -   	 ��Name$	 Search_Button��.���� 
 �� Orientation$
 
Horizontal=�.+�A� $��10��$��10��
���   �$
��Left=��� $��Right=�$��60��$��0 0 0 0q�
Найти�� -    ��Name$ 
stackPanel��
�������$��0,85,1084,426q�.+�	� -    	� 	GroupName$ Elements��$��Материки�� d� 	IsChecked$
 TrueY�	� -   $ Elements��$��
Міста��	� -   $ Elements��$��Країни��	� -	   $ Elements��$��Райони���� -
    ��Name$
 list��$
��Left=�$	��445��$��	85,85,0,0q�$	��Top=�$	��535��$��Visible=�$��Visible=� �� View �� �� -    ��Name$ Sort_Box��$��25��$	��Top=�$��195,40,824,0q�.@��� $��За площею���� $4��.За чисельністю населення���� $.��(За густиною населення���� $(��"За найвищою точкою���� $*��$За найнижчою точкою���� $��За назвою�� �� 
IsSelected . �� $��Сотувати за��$
��Left=�$��25��$��
120,40,0,0q�$	��Top=�$��85��