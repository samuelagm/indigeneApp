   M S B A M L   `   `   `  ����  IndigeneApp    IndigeneApp.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        �� 	Resources  5         ControlNormalColor  ControlMouseOverColor  DisabledControlColor  DisabledForegroundColor  ControlPressedColor  PrimaryButtonColor  SecondaryButtonColor  ActiveColor  SecondaryTextColor 	 AppBackgroundColor 
 HeaderBackgroundColor  AppHeaderBackgroundColor   SideBarHeaderBackgroundColor  HeaderForegroundColor  AppSideBarBackgroundColor  SideBarButtonPressedColor  SideBarButtonHoverColor  FormBackgroundColor  FormButtonColor  AppFormBackgroundColor  AppBorderColor  SecondaryText �� Color  FormBackground  SideBarHeaderBackground  AppHeaderBackground  HeaderBackground  	AppBorder  AppSideBarForeColor  AppSideBarBackground  AppBackground  AppSecondaryColor  ButtonFocusVisual �� Property �� Value �� StrokeDashArray   SideBarButton �� 
TargetType �� 
TargetType ��Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup	   Transitions%  System.Windows.VisualTransition
   GeneratedDuration   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ! PrimaryButton �� CornerRadius	   To	 �� To g� Duration g� AutoReverse " SecondaryButton # placeHolder �� BasedOn ��Name K� ZIndex �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� Triggers �� Binding  �� Source%  System.Windows.Markup.Reference! �� Value $ detail_list_panel" �� Orientation# � ColumnDefinitions$ � RowDefinitions��%f  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     &	     &		 )    &	
 J    &	 k    &	 �    &	 �    &	 �    &	 �    &	     &	 1    &	 R    &	 s    &	 �    &	 �    7  &	 �    7  &	 �    7  &	 �    7  &	     7 
 &	 +    7  &	 C    &	 d    7  &	 |    7 	 &	 �    7  &	 �    7  7  &	  i    7  7  7  7  7  7  &	! 
    7  7  7  7  7  7  &	" +    7  7  7  7  7  7  &	# =    7��&	$ �    7  ��5
   
   	#FFC0C0CE��66   ��5   
   	#FF262A33��69   ��5   
   	#FFF2F2F2��68   ��5   
   	#FFBFBFBF��6;   ��5   
   	#FF211AA9��67   ��5   
   	#FF02A2B8��66   ��5   
   	#FF4A4A4A��68   ��5   
   	#FF3FB4C6��6/   ��5   
   	#FF9F9F9F��66   ��5   
   	#FFF3F4F6��66   ��5   
   	#FFF6F8F8��69   ��5   
   	#FF45C8DC��6<   ��5   
   	#FF3FB4C6��6@   ��5   
   	#FF58666E��69   ��5   
   	#FF262A33��6=   ��5   
   	#FF363A4D��6=   ��5   
   	#FF2E3340��6;   ��5   
   	#FFFCFCFC��67   ��5   
   	#FF23B7E5��63   ��5   
   #F8F8F8��68   ��5   
   	#FFE2E2E2��62   �� 5    
   8   60   �� 5!   
   8   61   �� 5"   
   8   6:   �� 5#   
   8   66   �� 5$   
   8   63   �� 5%   
   8   6,   ��5&   
   	#FFE4F8D6��6A   �� 5'   
   8   67   �� 5(   
   8   60   �� 5)   
   8   64   �� 5,   
   .�5-      ��  � �� 5.      �� 5/      .R�50      �� 8��  ._�51      �� $��2q�6(   $	��1.5��63   8�� $	 1 2R�6m   52      53      55      56      �� 5<   
   " ��6&   .�5=      ��  �@J�SnapsToDevicePixels . 64   �� 5>       �@�OverridesDefaultStyle . 66   �� 5?       �@�FocusVisualStyle8   61   �� 5@       � ��$
 29px��6*   �� 5A       � ��$ 103px��6*   �� 5B       � ��$
 Left=�6;   �� 5D       � ��8  6+   �� 5F       � �� 5G      �� 5H      " ��6&   .R�5I      �� $ Border��6U   #��z��6!   ��5J      �� 5K   "   # �  63    5M        5N   "   CommonStates��	 5O   &     5P   *   $
 0:0:0.1D�6;   . 5R   &     
Normal��62     5S   &   	MouseOver��. 5T   *   �� .��5U   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6K   $ Border��5V   1   .g�5W   2     $ 0��6F   8  6R   5X   /   5Y   +   5Z   '     5[   &   Pressed��. 5\   *   �� .��5]   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6K   $ Border��5^   1   .g�5_   2     $ 5��6F   8  6R   5`   /   5a   +   5b   '     5c   &   Disabled��. 5d   *   �� .��5e   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6K   $ Border��5f   1   .g�5g   2     $ 0��6F   8  6R   5h   /   �� 5i   .   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�6K   $ Border��5j   1   .g�5k   2     $ 0��6F   8  6R   5l   /   5m   +   5n   '   5o   #   ._�5q      �� $��Center=�5r      ��. 5s      5t      5u      5w      5x      �� 5z   
   " ��6&   .�5{      ��  � ��
 �����6+   �� 5|       �@J�SnapsToDevicePixels . 64   �� 5}       �@�OverridesDefaultStyle . 66   �� 5~       �@�FocusVisualStyle8   61   �� 5       � ��$
 29px��6*   �� 5�       � ��$
 31px��6'   �� 5�       � ��$ 103px��6*   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $ Border��6!   8�� $	��1.1q�6Z   $	 1.2��6p   ��5�      �� 5�   "   8  62    5�        5�   "   CommonStates��	 5�   &     5�   *   $
 0:0:0.1D�6;     5�   *   $
 0D�6;   $ Pressed��6Q   . 5�   &     
Normal��. 5�   *   �� .��5�   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6=   $ Border��5�   =   8  6\   5�   +   5�   '     5�   &   	MouseOver��. 5�   *   �� .��5�   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6=   $ Border��5�   =   8  6\   5�   +   5�   '     5�   &   Pressed��. 5�   *   �� .��5�   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6=   $ Border��5�   =   8  $ 0:0:0.9D�6~    . 6�   5�   +   5�   '   5�   #   ._�5�      �� $��2q�6/   $��Center=�5�      $��Center=�5�      ��. 5�      5�      5�      5�      5�      �� 5�   
   " ��6(   .�5�      ��  � ��
 �����6+   �� 5�       �@J�SnapsToDevicePixels . 64   �� 5�       �@�OverridesDefaultStyle . 66   �� 5�       �@�FocusVisualStyle8   61   �� 5�       � ��$
 29px��6*   �� 5�       � ��$
 31px��6'   �� 5�       � ��$ 103px��6*   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $ Border��6!   8�� $	��1.1q�6Z   $	 1.2��6p   ��5�      �� 5�   "   8  62    5�        5�   "   CommonStates��	 5�   &     5�   *   $
 0:0:0.1D�6;     5�   *   $
 0D�6;   $ Pressed��6Q   . 5�   &     
Normal��. 5�   *   �� .��5�   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6=   $ Border��5�   =   8  6\   5�   +   5�   '     5�   &   	MouseOver��. 5�   *   �� .��5�   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6=   $ Border��5�   =   8  6\   5�   +   5�   '     5�   &   Pressed��. 5�   *   �� .��5�   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6=   $ Border��5�   =   8  $ 0:0:0.9D�6~    . 6�   5�   +   5�   '   5�   #   ._�5�      �� $��2q�6/   $��Center=�5�      $��Center=�5�      ��. 5�      5�      5�      5�      5�      �� 5�   
   " ��6$   8   .�5�      ��  �@�OverridesDefaultStyle .  66   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ 
textSource��5�   "   
������ $ 2��5�   "   ��5�   &   �� $
 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�5�   "   �� 5�      #��z 6&   #��z��6C   $ 1��6m   .��6~   ��5�   "   �� 5�   &   " ��6,   .�5�   *   ��  � ��
 ���� 6G    5�   *   �� 5�   .    6:   �� $
 Text�    *
textSource+!  6y   .a�5�   2   ��  � ��
 �����6O   5�   /   5�   '   .��5�   1   5�      5�      5�      5      5     �� 5  
   " ��6+   .�5     ��  � �� 5     �� 5     " ��6&   .R�5     �� $" Vertical=�6%   #��z��6<   .+�5     � $
��auto��6#   # 5	  "   �� 5
  &   �� 5  &   $ 5  "   �� 5  &   �� 5  &   .+�5  "   �� $��0��6,   8��  $��0��6e   #��z 6u   �� 5  "   $��0��6-   $��1��6:   #��z��6J   5     5     5     5     5     5     5     