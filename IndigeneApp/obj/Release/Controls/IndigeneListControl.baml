   M S B A M L   `   `   `  ����   IndigeneApp%    IndigeneApp.IndigeneListControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     � 	Resources   �� 
TargetType �� Property �� Value   indigeneListViewSource �� Source  DetailTemplate �� Orientation �� Path � RowDefinitions � ColumnDefinitions  SecondaryText	 ��Name  	AppBorder
 � ToolTip J� Opacity  list_button
 � Tag  FormBackgroundColor �� Color��%�  '��       &	  "     &	 A     7  7  7  7  7  7  7  7  7  7  &	 �    7  �� " ��.���  � ��$ 4q���  �� *IndigeneList+�� .R�]� $��Stretch=�.+��� $	��Top=�$��0,20,0,0q�$ Vertical=�.+��� $ Vertical=�$��Center=�.+��� ���� *ElligibilityImage+�� $ 
Horizontal=�$��Center=�$��Center=�.+��� $��SemiBold"�$��13(����� $ 	FirstName��� $��SemiBold"�$��5,0,0,0q�$��13(����� $ 
OtherNames��� $��Light"�$��10,0,0,0q�$��Italic$����� *Elligibility+�� � $��0,15,0,0q�$	��100��$	��250�� �� �� �� �� �� �� �� ��  �� $	��100 ��� $	��150 �.+��� 8��  $��Center=�$��0��$��
First Name��$��0���� $��Center=�$��0��$��1��$��
5, 0, 0, 0q����� $ 	FirstName��� 8�� $��Center=�$��1��$��Other Names��$��0���� $��Center=�$��1��$��1��$��
5, 0, 0, 0q����� $ 
OtherNames��� 8�� $��Center=�$��2��$��Place of Residence��$��0���� $��Center=�$��2��$��1��$��
5, 0, 0, 0q����� $ PlaceOfResidence��� 8�� $��Center=�$��3��$��Marital Status��$��0���� $��Center=�$��3��$��1��$��
5, 0, 0, 0q����� $ MaritalStatus��� 8�� $��Center=�$��4��$��
Occupation��$��0���� $��Center=�$��4��$��1��$��
5, 0, 0, 0q����� $ 
Occupation��� 8�� $��Center=�$��5��$	��Sex��$��0���� $��Center=�$��5��$��1��$��
5, 0, 0, 0q����� $	 Sex��� 8�� $��Center=�$��6��$��Phone Number��$��0���� $��Center=�$��6��$��1��$��
5, 0, 0, 0q����� $ PhoneNumber��� 8�� $��Center=�$��7��$��Date of Birth��$��0���� $��Center=�$��7��$��1��$��
5, 0, 0, 0q����� $ DateOfBirth��� $
��auto��$��Bottom=�$��Center=�$��Bottom=�$ 
Horizontal=�.+��� $	 deleteButton��-   $��4q�$	��1.2q�8�� 
������ $
 Delete��.���� $	 0.5Q�$ ��../Media/appbar.delete.png��$��27��$��27���� $	 
editButton��-   $	��1.2q�8��	 $��4q�$

 Edit��
������ .���� $	 0.6Q�$��../Media/appbar.edit.png��$��27��$��27���� " ��.���  � �� �� .R��� #��z ��  � ��$ 20����  � �� �� 8   .���� #��[  �� Padding$ 0, 0, 0, 10q�$��Stretch=�  FormBackground#��[  �� CornerRadius$ 0��$	��1.5q�._��  �� �� �� ��  �� $��* ��� $
��auto �.+��� $��0��$��40��$��8q�$	��1.5q�#��[ ._��  �� $��* ��� $
��auto �.+��� -    ��Name$ 
searchTerm��$��0��$��4q�$��Center=�$��Stretch=�$��0q��� -   $	 searchButton��$
 Search for indigene��$��5q�$��1��$��0q�
������ .���� -    ��Name$ searchButtonImage��$	 0.5Q�$!��..\Media\appbar.magnify.png��o� $��0��$��1���� $��1��$��2��$��0��$	��0.5q�#��[ ._��� � $��2��$��0��$��2��$��Stretch=� �� $��* ��� $��2 ��� $
��auto �.+��� -    ��Name$ listbox�� �� SelectionMode$ Single=� �� ShowOnDisabled . $	��580��$
��Auto=�$��0��$��0q�$ �� IsSynchronizedWithCurrentItem$
 TrueY�����  �� Source# [  ���� " ��.���  � ��
 ���� ��  � �� ��  �� 
TargetType" ��.R��� 
������ $��0q�#��z��._��� $��Stretch=�#��z��$
��Auto��$��0q� �� Content# z�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � ��  AppBackground# [ P�  �@J�	IsFocused . . ���  � ��# [  �� View ��  �� AllowsColumnReorder .  .P���  �� Width$
 auto��$
��Name�� �� CellTemplate �� .R��� $ 
Horizontal=�.+��� $��0��$��0��$��5,0,0,0q�$��40��$��40������ $ ElligibilityImage��� $��Center=�$��13(����� $ 	FirstName��� $��Center=�$��5,0,0,0q�$��13(����� $ 
OtherNames��� $��Gender��  �� DisplayMemberBinding  �� $	 Sex��� $	��Age��  �� $	 Age��� $��Payment Elligibility��  �� $ Elligibility��� $��
Occupation��  �� $ 
Occupation��� $��Phone Number��  �� $ PhoneNumber��� $��1q�$��1��#��[ ._��� �� $��2��$��10q�$��0q�#��[ ���� # [  