   M S B A M L   `   `   `  ����  IndigeneApp    IndigeneApp.LoginForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � WindowStyle$
  None=�5   	    � OverridesDefaultStyle .  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � Title$ 
Login Form��5
   	   $	��330��6   $	��450��6)   ��5      �� 5   
    �� 
TargetType" �6   .R�5      �� $��5q�6   
�������   AppHeaderBackground#��[  6<   ._�5      �� #��z��6#   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��28 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Right=�6"   .+�5      �� -   5         ��Name$ closeButton��5   P   $��0q�6   $��3q�6)   	 � ToolTip$	 Close application��64   
������ .��5      �� -   5        
 ��Name$
 searchButtonImage��5   =    J� Opacity$	 0.2Q�6   $��25��6&   $��19��61   $$��Media\appbar.axis.x.letter.png��6X   5      5      �� 5   
   $��1��6   $��Center=�6"   $��Center=�6=   .+�5      �� $��20q�6   $��Center=�6    $��
ExtraBlack"�6=   $��18(�6U   $��0q�6d   
�������.��6�   
i-Slog App5!      �� 5"      $��0q�6   $��SemiBold"�6    $��13(�66   $��0q�6E   .��6Z   Login5$      �� 5%      $	��0.8q�6     	AppBorder#��[ 6+   $��0,0,0,10q�6T   ._�5&      �� 5'      � 5)       � ColumnDefinitions 5*      �� 5+      $
��auto �6'   �� 5,      $��* �6'    5.      �� 5/      �� 50      .+�52      �� $��0��6   $��0��6(   .��65   Account name6C   �� 53      $��0��6   $��1��6(   .��65   
Password6?   �� 54      -   5         ��Name$ accountNameComboBox��54   '   $	��180��6   $��0��6D   $��1��6Q   $��4q�6a   $��4q�6m   .@�55      �� $��Administrator��6#   �� 56      $
��User��6#   57      G� 58      -   5         G�Name$ password��58      $��1��61   $��1��6>   $��4q�6O   $��4q�6[   59      5:      �� 5;   
   -   5         ��Name$ buttonContainer��5;   :   $��2��6    �� Orientation$ Vertical=�6#   $��0,48,0,0q�6S   .+�5<      �� $	��0.8q�6   #��[ 6+   $��	0,10,0,10q�6T   ._�5=      �� 5>      �� 5?      $
��Left=�6   $��50��60   $��-9,10,0,-10q�6<   $	��Top=�6Q   $	��332��6i   ._�5@      �� -   5        $ loginButton��5@      $��Login��6H   $��0,-8,-31,29q�6X   $��Right=�6m   $��97��6�     PrimaryButton#��[ 6�   $
��Auto��6�   5A      5B      5E      5G      