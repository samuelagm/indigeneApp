   M S B A M L   `   `   `  ����   IndigeneApp    IndigeneApp.App   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       �� 	Resources     ControlNormalColor  ControlMouseOverColor  DisabledControlColor  DisabledForegroundColor  ControlPressedColor  PrimaryButtonColor  SecondaryButtonColor  ActiveColor  SecondaryTextColor 	 AppBackgroundColor 
 HeaderBackgroundColor  AppHeaderBackgroundColor   SideBarHeaderBackgroundColor  HeaderForegroundColor  AppSideBarBackgroundColor  SideBarButtonPressedColor  SideBarButtonHoverColor  FormBackgroundColor  FormButtonColor  AppFormBackgroundColor  AppBorderColor  SecondaryText �� Color  FormBackground  SideBarHeaderBackground  AppHeaderBackground  HeaderBackground  	AppBorder  AppSideBarForeColor  AppSideBarBackground  AppBackground  AppSecondaryColor  ButtonFocusVisual �� Property �� Value �� StrokeDashArray   SideBarButton �� 
TargetType �� 
TargetType ��Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup	   Transitions%  System.Windows.VisualTransition
   GeneratedDuration   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ! PrimaryButton �� CornerRadius	   To	 �� To g� Duration g� AutoReverse " SecondaryButton # placeHolder �� BasedOn ��Name K� ZIndex �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� Triggers �� Binding  �� Source%  System.Windows.Markup.Reference! �� Value $ detail_list_panel" �� Orientation# � ColumnDefinitions$ � RowDefinitions��%�  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     &	 �     &	 �     &		 �     &	
 �     &	 �     &	 �     &	 �     &	 
    &	     &	 0    &	 C    &	 V    &	 i    &	 z    &	 �    7  &	 �    7  &	 �    7  &	 �    7  &	 �    7 
 &	 �    7  &	 �    &	 �    7  &	 �    7 	 &	 �    7  &	 �    7  7  &	  N    7  7  7  7  7  7  &	! �    7  7  7  7  7  7  &	" �    7  7  7  7  7  7  &	# �    7��&	$     7  ��	#FFC0C0CE����	#FF262A33����	#FFF2F2F2����	#FFBFBFBF����	#FF211AA9����	#FF02A2B8����	#FF4A4A4A����	#FF3FB4C6����	#FF9F9F9F����	#FFF3F4F6����	#FFF6F8F8����	#FF45C8DC����	#FF3FB4C6����	#FF58666E����	#FF262A33����	#FF363A4D����	#FF2E3340����	#FFFCFCFC����	#FF23B7E5����#F8F8F8����	#FFE2E2E2���� 8   �� 8   �� 8   �� 8   �� 8   �� 8   ��	#FFE4F8D6���� 8   �� 8   �� 8   �� .���  � �� �� .R��� 8��  ._��� $��2q�$	��1.5��8�� $	 1 2R��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@�FocusVisualStyle8   ��  � ��$
 29px����  � ��$ 103px����  � ��$
 Left=���  � ��8  ��  � �� �� " ��.R��� $ Border��#��z������ # �     CommonStates��	   $
 0:0:0.1D�.   
Normal��  	MouseOver��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��.g�  $ 0��8    Pressed��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��.g�  $ 5��8    Disabled��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��.g�  $ 0��8  �� $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�$ Border��.g�  $ 0��8  ._��� $��Center=���. �� " ��.���  � ��
 �������  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@�FocusVisualStyle8   ��  � ��$
 29px����  � ��$
 31px����  � ��$ 103px����  � �� �� " ��.R��� $ Border��8�� $	��1.1q�$	 1.2������ 8     CommonStates��	   $
 0:0:0.1D�  $
 0D�$ Pressed��.   
Normal��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��8    	MouseOver��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��8    Pressed��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��8  $ 0:0:0.9D� . ._��� $��2q�$��Center=�$��Center=���. �� " ��.���  � ��
 �������  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@�FocusVisualStyle8   ��  � ��$
 29px����  � ��$
 31px����  � ��$ 103px����  � �� �� " ��.R��� $ Border��8�� $	��1.1q�$	 1.2������ 8     CommonStates��	   $
 0:0:0.1D�  $
 0D�$ Pressed��.   
Normal��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��8    	MouseOver��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��8    Pressed��. �� .���� $0 *(Panel.Background).(SolidColorBrush.Color)�$ Border��8  $ 0:0:0.9D� . ._��� $��2q�$��Center=�$��Center=���. �� " ��8   .���  �@�OverridesDefaultStyle .  ��  � �� �� " ��.R�� .+��� $ 
textSource��
������ $ 2������ $
 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=��� #��z #��z��$ 1��.������ " ��.���  � ��
 ����  ��  �� $
 Text�    *
textSource+!  .a���  � ��
 �����.���� " ��.���  � �� �� " ��.R��� $" Vertical=�#��z��.+�� $
��auto��# �� �� $ �� �� .+��� $��0��8��  $��0��#��z �� $��0��$��1��#��z��