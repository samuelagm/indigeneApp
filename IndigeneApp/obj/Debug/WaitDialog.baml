   M S B A M L   `   `   `  ����  IndigeneApp    IndigeneApp.WaitDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � WindowStyle$
  None=�5   	    � OverridesDefaultStyle .  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � Title$ 
WaitDialog��5   	   $	��180��6   $	��350��6)   ��5      �� 5   
    �� 
TargetType" �6   .R�5      �� $��5q�6   
�������   AppSecondaryColor#��[  6<   ._�5      �� #��z��6#   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Center=�6"   $��Center=�6=   .+�5      �� -   5         ��Name$ 
contentBox��5   2   	 �� Padding$	 5q�6   $��14(�6$   $
��Left=�6G   $
��Wrap=�6c   $��	TextBlock��6w   $	��Top=�6�   
 J� RenderTransformOrigin$
 -0.531,-0.319&�6�   5      �� 5   
   -   5         ��Name$ buttonContainer��5   P   $y�	Collapsed=�6   $��1��6,    �� Orientation$ Vertical=�69   .+�5      �� $	��0.8q�6     	AppBorder#��[ 6+   $��	0,10,0,10q�6T   ._�5      �� 5       �� 5!      $
��Left=�6   $��50��60   $��-9,10,0,-10q�6<   $	��Top=�6Q   $	��332��6i   ._�5"      �� -   5         ��Name$ closeButton��5"      $��OK��6H   $��0,0,0,21q�6U   $��Right=�6g   $��97��6�     PrimaryButton#��[ 6�   $
��Auto��6�   5#      5$      5'      5)      