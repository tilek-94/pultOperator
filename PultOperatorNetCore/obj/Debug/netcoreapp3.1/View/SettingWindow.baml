   M S B A M L   `   `   `  ����N  JPultOperatorNetCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PultOperatorNetCore.ViewPultOperatorNetCore.View  5   	   ,    &PultOperatorNetCore.View.SettingWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:PultOperatorNetCore.View     5   	     � Title$  Identification��5      $	��190��6   $	��600��6,    � WindowStartupLocation$ CenterScreen=�68    � AllowsTransparency$
 True��5	   	    � WindowStyle$
 None=�6#    � 
ResizeMode$ NoResize=�5
   
   ��5	   6   Z� .��5      � 
�������$��5q�6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5       J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6      	Direction$	 250Q�6.   	   ShadowDepth$	 1Q�6>   .+�5   
   �� ���#0A6E9E6   �� 5   
   $��1��6   $��Center=�6"   $��Center=�6@   .+�5      �� 
 �� Orientation$
 
Horizontal=�6   .+�5      �� .+�5      �� $��
IpAddress:��6    $��5q�62   $��25��6=   ���#60656E$��17(�6_   �� 5      $��Window number:��6    $��5q�66   $��25��6A   ���#60656E$��17(�6c   5      �� 5      .+�5      �� -   5         ��Name$ 	IpAddress��5      $��5q�61   $��25��6<   $	��400��6H   �� 5      -   5        $ WindowNumber��5      $��5q�64   $��25��6?   $	��400��6K   5      5       �� 5!      -   5         ��Name$ button_1��5"   "    � Cursor$
 Hand��5!      $��10q�6#   $��30��6/   $	��200��6;   $��Сохранить��5"      ���#0A6E9E
�������$��0q�5#   9    � 	Resources 5$       �� 
TargetType �� Property �� Value��%d   '��       �� 5%      " ��6   .�5&      ��  �@��CornerRadius$ 1,1,1,1��69   5'      5(      5)      5,      51      52      