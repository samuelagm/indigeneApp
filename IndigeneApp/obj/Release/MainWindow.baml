   M S B A M L   `   `   `  ����   IndigeneApp    IndigeneApp.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -      AppBackground#��[    � WindowState$  	Maximized=� � Title$ 
i-Slog App��$	��550��$	��725�� � 	Resources   headerButtons �� 
TargetType �� Property �� Value��%D   &	       �� " ��.���  � ��
 ���� ��  � ��$ 0q�.��� .+�� -    �Name$ Overlay�� K� ZIndex$
 1000��$y�	Collapsed=�����  �� Color$ Black��	 �� Opacity$	 .5Q�� 
 � RowDefinitions
 ��  � ColumnDefinitions �� $
��auto ��� .+��� -    ��Name$ SideBarBorder��$	 100��$	��160��  AppSideBarBackground#��[ ._�]� $��Stretch=�$
��Left=�$��0��.+��� $	��Top=� �� Orientation$ Vertical=�.+��� -    ��Name$ mainNavigation��$��0,10,0,0q�$ Vertical=�.+��� -    ��Name$ 
homeButtom��  SideBarButton#��[ $��
15,0,20,10q�$
��Left=�$	��160��$��0,0,0,5q�.���� $��10,0,0,0q�$
��Left=�$	��115��$ 
Horizontal=�$��40��.+��� $��Media\appbar.home.png���� $��10q�$��SemiBold"�$��Center=�$
��Left=�HOME�� -   $ newIndigeneButton��#��[ $��
15,0,20,10q�$
��Left=�$
��auto��$��0,0,0,5q�.���� $��10,0,0,0q�$
��auto��$ 
Horizontal=�$��40��.+��� $��Media\appbar.add.png���� $��10q�$��SemiBold"�$��Center=�$
��Left=�ADD INDIGENE�� -   $ backNavigation��$y�Hidden=�.+��� -   $ backNavigationButton��#��[ $��
15,0,20,10q�$��Center=�$
��auto��$��0,0,0,5q�.���� $(��"Media\appbar.navigate.previous.png��$��60��$��60���� $��Bottom=�$��Bottom=�.+���  �� Padding$ 10q�$��Center=�
�������$��Bottom=�Slug Data Company�� $��1��.+�]� $��50��  AppHeaderBackground#��[ .+��� -	    ��Name$ headerTitle��$�� ��$
��Left=�$��30,5,0,0q�
�������$
��auto��$��Center=�$��
0,10,10,10q�$��15(�$��SemiBold"��� $ 
Horizontal=�$��	20,0,10,0q�$��Center=�$��Right=�$��Right=�.+��� -
   $ configurationButton2�� � ToolTip$ Application Settings��$��	10,0,17,0q�#��[ .���� $��30��$��Media\appbar.settings.png����   	AppBorder#��[ $	��0.3q�._��� �� #��[ $	��0.3q�._��� �� -   $ ControlsPanel��$��Stretch=�$��30, 10,30,10q�$
��auto��