   M S B A M L   `   `   `  ����D  @Directory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Directory	Directory  5   	       Directory.LogIn   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Directory     5   	   -   5          � Title$  LogIn��5   	   $	��500��6   $	��350��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U    � Icon$ Assets\earth.ico��5	   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $	 0.5Q�65   5      5      �� 5   
   $��Assets/home.png��6   $	��100��6)   $	��100��65   $	��Top=�6B   $��20q�6Z   6h   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0, 100q�6U    �� RadiusY$ 24��6e   	 �� RadiusX$	 24��6r   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFBBBBBB��6#      	Direction$ 0Q�65      
BlurRadius$ 15Q�6C      ShadowDepth$ 1Q�6S   5      � 5   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5      �� $��Вхід��6   $��Center=�6#   $��40��6@   $��114,14,102,186q�6M   $��64��6e   ���	#FF5F5E5E$��24(�6�   �� 5      $
��name��6   $
��Left=�6#   $��30��6>   $��	13,84,0,0q�6J   $	��Top=�6]   $��45��6u   �� 5      $��password��6   $
��Left=�6'   $��30��6B   $��
13,164,0,0q�6N   $	��Top=�6b   $��65��6z   �� 5       -   5         ��Name$ 	user_name��5       $
��Left=�6)   $��25��6D   $��	78,84,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��160��6�   G� 5!      -   5         G�Name$ user_pas��5!      $
��Left=�6,   $��25��6G   $��
78,164,0,0q�6S   $	��Top=�6g   $	��160��6   5"      �� 5#   
   -   5        $��Вхід��5#      $��Center=�6    $��40��6=   $��	0,345,0,0q�6I   $	��Top=�6\   $	��185��6t   ���	#FF01AAF9
�������$��18(�6�   6�   �� 5$   
   -   5        $&�� Зарегіструватися��5$      $
��Left=�6+   $��25��6F   $��110,405,0,0q�6R   $	��Top=�6g   $	��110��6   6�   5%      5&      