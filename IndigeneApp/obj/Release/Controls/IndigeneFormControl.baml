   M S B A M L   `   `   `  ����   IndigeneApp%    IndigeneApp.IndigeneFormControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   .����    	AppBorder#��[    �� Padding$  0, 0, 0, 10q�  FormBackground#��[  �� CornerRadius$ 0��$	��1.5q�._��� .+��� .+���  �� Padding$ 15q�$
��Left=�$��SemiBold"�PERSONNEL DATA FOR INDIGENES�� $	��0.5q�#��[  ._��� �� $  10q�._�� #��[  � RowDefinitions �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� ��  � ColumnDefinitions �� $
��auto ��� �� �� .+��� $��0��$��0��.��Name�� $��0��$��1��.��	Village�� $��0��$��2��.��Date of Birth�� $��0��$��3��.��Marital Status�� $��0��$��4��.��Sex�� $��0��$��5��.��Phone Number�� $��0��$��6��.��
Occupation�� $��0��$��7��.��Name of Parents�� $��0��$��8��.��Place of Residence�� $��0��$��9��.��
Comments�� -    ��Name$
 name��$��0��$��1��$��2�� �� SelectedText$  ��$��4q�$��4q��� -    ��Name$ village�� �� SelectedIndex$ 1��$��1��$��1��$��2��$��4q�$��4q����� *VillageList+(  "System.Windows.Controls.DatePicker  -   	  Name$	 dateofbirthDatePicker��$��1��$��2��$��4q�$��4q��� -   $ maritalstatus��$ 1��$��3��$��1��
 �� Text$
 Marital Status��$��4q����� *MaritalStatusList+�� -   $ sexComboBox��$ 1��$��4��$��1��$��4q����� *	SexList+�� -   $ phoneNumber��$��5��$��1��$  ��$��4q�$��4q��� -   $ 
occupation��$��6��$��1��$��2��$  ��$��4q�$��4q��� -	   $ nameofParents��$��7��$��1��$��2��$  ��$��4q�$��4q��� -
   $ placeofResidence��$��8��$��1��$��2��$  ��$��4q�$��4q��� -   $ comments��$��9��$��2��$��2��$��1��$  ��$��4q�$��4q��� $��0��$��11��.��
Children�� $
��auto��$��1��$��4q�$
��Left=�$��11��$��2��.+��  ��  �� �� .+��� $��0��$��0��$
��auto�� �� Orientation$ 
Horizontal=�$��Center=�.+��� .��Name�� -   $ 	childName��$��4q�$��4q�$	��180��
 � Tag$
 Name���� .��Age�� -   $ childAge��$��4q�$��4q�$	��100��$	 Age���� -    ��Name$ addChildButton��$��10,0,0,0q�$��27��$��60��$��50��  SecondaryButton#��[ .��Add�� -    ��Name$ childListBox��$
��Left=�$��0��$��1��$	��500��$��0,10,0,0q�$
��auto��$��80������ *	ChildList+ � ContextMenu �� .@�m� -    m�Name$ deleteMenuButton��$��Delete������ .R��  �� $	��300 ���  �� .+��� $��0������ *Name+�� $��1��$��0,0,10,0q����� *Age+�� $	��0.8q�#��[  $��	0,10,0,10q�._��� �� $��Right=�$ 
Horizontal=�$��50��$��0,0,49,0q�.+��� #��[ $
��auto��$��5q�.��Clear�� -   $ 
saveButton��  PrimaryButton#��[ $
��auto��$��5q�.��Save