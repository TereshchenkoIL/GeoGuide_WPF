   M S B A M L   `   `   `  ����D  @Directory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Directory	Directory  5   	   d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5   	       Directory.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Directory     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	     � Title$!  Головна панель��5	      $	��650��6   $
��1180��6,    � 
ResizeMode$ NoResize=�69    � Icon$ Assets\earth.ico��5
      .��5      � 
����İ�.+�5   
   '  !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$	 map��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AttsGkqIHCOIEA11KtQZDphl5bi8lppin64jeg-ZOOhiS4cdHA_EXJwHSbyZi4Xo 6      Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$
 Road 6u   $��0��6�   $��1��6�      	ZoomLevel$ 8Q�6�      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 50.1870304,30.6606103 6�   $��640,60,29,91q�6�   ���#0ccea7$��2q�6�   6  o� 5   
   $��30��6   $	��Top=�6   $��2��63   .@�5      m� $��Feedback��6   .@�5      m� $ ��illia.tereshchenko@nure.ua��6   6B   5      m� 5      $��Version��6   .@�5      m� $��v1.06��6   6-   5      m� 5      $��License��6   .@�5      m� $��©Directory��6   62   5      m� 5      -   5        $
��Help��5      5      5      `� 5   
   $	��Top=�6   $��Right=�6/   $��30��6K   $��1��6W   .�5      c� $��25��6   $��Right=�6"   .@�5       �� -   5         ��Name$ 
Search_Box��5       $	��100��6.   .��6:   Поиск...6D   5!      c� 5"      .@�5#      �� -   5        	 ��Name$	 Search_Button��5#      .��5$      �� 
 �� Orientation$
 
Horizontal=�6!   .+�5%      A� $��10��6"   $��10��6-   
���   �$
��Left=�6G   �� 5&      $��Right=�6$   $��60��6@   $��0 0 0 0q�6K   
Найти6c   5'      5(      5)      5*      �� 5,   
   -   5         ��Name$ 
stackPanel��5,      
�������$��0,85,1084,426q�6B   .+�5-      	� -   5         	� 	GroupName$ Elements��5-      $��Материки��6/    d� 	IsChecked$
 TrueY�6B   6S   	� 5.      -   5        $ Elements��5.      $��
Міста��6/   6?   	� 5/      -   5        $ Elements��5/      $��Країни��6/   6@   	� 50      -	   5        $ Elements��50      $��Райони��6/   6@   52      �� 53   
   -
   5         ��Name$
 list��53      $
��Left=�6#   $	��445��6>   $��	85,85,0,0q�6K   $	��Top=�6^   $	��535��6v   $��Visible=�6�   $��Visible=�6�    �� View 54      �� 55      59      5;      �� 5<   
   -   5         ��Name$ Sort_Box��5<      $��25��6%   $	��Top=�61   $��195,40,824,0q�6I   .@�5=      �� $��За площею��6   61   �� 5>      $4��.За чисельністю населення��6   6@   �� 5?      $.��(За густиною населення��6   6=   �� 5@      $(��"За найвищою точкою��6   6:   �� 5A      $*��$За найнижчою точкою��6   6;   �� 5B      $��За назвою��6    �� 
IsSelected . 6C   5C      �� 5D   
   $��Сотувати за��6   $
��Left=�6&   $��25��6A   $��
120,40,0,0q�6M   $	��Top=�6a   $��85��6y   5F      5G      