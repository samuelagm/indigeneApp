   M S B A M L   `   `   `  ����  IndigeneApp    IndigeneApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5           AppBackground#��[  5   	     � WindowState$  	Maximized=�5   	    � Title$ 
i-Slog App��5   	   $	��550��6   $	��725��6)    � 	Resources 5        headerButtons �� 
TargetType �� Property �� Value��%w   &	       �� 5	   
   " ��6&   .�5
      ��  � ��
 ���� 6A   �� 5       � ��$ 0q�60   5      5      .��5      � .+�5   
   � -   5         �Name$ Overlay��5       K� ZIndex$
 1000��6    $y�	Collapsed=�64   ��5      �� 5       �� Color$ Black��6"   	 �� Opacity$	 .5Q�60   5      � 5   
   
 � RowDefinitions
 5      �� 5       � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      .+�5       �� -   5         ��Name$ SideBarBorder��5    g   $	 100��6   $	��160��6(     AppSideBarBackground#��[ 64   ._�56      ]� $��Stretch=�6   $
��Left=�69   $��0��6T   .+�57      �� $	��Top=�6!    �� Orientation$ Vertical=�66   .+�58      �� $��50��6%   $	��160��61   $��0,0,0,10q�6=     SideBarHeaderBackground#��[ 6O   5:      �� 5;      -   5         ��Name$ mainNavigation��5;   &   $ Vertical=�6>   .+�5<      �� -   5         ��Name$ 
homeButtom��5<   �     SideBarButton#��[ 6%   $��
15,0,20,10q�6L   $
��Left=�6a   $	��160��6�   $��0,0,0,5q�5=   .   .��5>   "   �� $��10,0,0,0q�6-   $
��Left=�6?   $	��115��6Z   $ 
Horizontal=�6f   $��40��6   .+�5?   &   �� $��Media\appbar.home.png��6,   �� 5@   &   $��10q�60   $��SemiBold"�6<   $��Center=�6R   $
��Left=�6m   HOME6�   5A   #   5B      �� 5C      -   5        $ newIndigeneButton��5C   �   #��[ 6%   $��
15,0,20,10q�6L   $
��Left=�6a   $
��auto��6�   $��0,0,0,5q�5D   6   .��5E   "   �� $��10,0,0,0q�6-   $
��auto��6?   $ 
Horizontal=�6L   $��40��6e   .+�5F   &   �� $��Media\appbar.add.png��6,   �� 5G   &   $��10q�60   $��SemiBold"�6<   $��Center=�6R   $
��Left=�6m   ADD INDIGENE6�   5H   #   5I      5J      �� 5L      -   5        $ backNavigation��5L   9   $y�Hidden=�6%   .+�5M      �� -   5        $ backNavigationButton��5M   �   #��[ 6H   $��
15,0,20,10q�6o   $��Center=�6�   $
��auto��6�   $��0,0,0,5q�5N      .��5O   "   �� $(��"Media\appbar.navigate.previous.png��6(   $��60��6T   $��60��6`   5Q      5R      5S      �� 5T      $��Bottom=�6!   $��Bottom=�6<   .+�5U      ��  �� Padding$ 10q�6$   $��Center=�61   
�������$��Bottom=�6`   Slug Data Company5W      5X      5Y      5Z      �� 5\      $��1��6   .+�5]      ]� $��50��6     AppHeaderBackground#��[ 6,   .+�5^      �� $
��Left=�6    $��40,5,0,0q�66   
�������$
��auto��6[   $��Center=�6i   $ 
0,10,10,10q�6�   $��15(�6�   $��SemiBold"�6�   i-Slog Data App5`      �� 5a      $ 
Horizontal=�6#   $��	20,0,10,0q�6<   $��Center=�6O   $��Right=�6j   $��Right=�6�   .+�5d      �� -	   5        $ configurationButton2��5d   T    � ToolTip$ Application Settings��6!   $��	10,0,30,0q�6A   #��[ 6�   .��5e      �� $ 4q�6)   
�������$
��Bold"�6M   
Settings5g      5h      5i      5j      �� 5k        	AppBorder#��[ 6   $	��0.3q�6B   ._�5l      �� 5m      �� 5n      #��[ 6   $	��0.3q�6B   ._�5o      �� 5p      �� 5q      -
   5        $ ControlsPanel��5q   `   $��Stretch=�6   $��30, 10,30,10q�6;   $
��auto��6Q   6`   5r      5t      5v      5x      