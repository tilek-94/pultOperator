   M S B A M L   `   `   `  ����N  JPultOperatorNetCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PultOperatorNetCore.ViewPultOperatorNetCore.View  5   	   O,clr-namespace:PultOperatorNetCore.ComponentsPultOperatorNetCore.Components  5   	   -    'PultOperatorNetCore.View.Identification   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   2local&clr-namespace:PultOperatorNetCore.View  5   	   =
components,clr-namespace:PultOperatorNetCore.Components  5   	   -   5          �Name$  window��5   	    � Title$ Identification��5   	   $	��190��6    $	��600��6-    � WindowStartupLocation$ CenterScreen=�69    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�6#    � 
ResizeMode$ NoResize=�5   
    +� FocusedElement 5
   	   ��  �� ElementName$
 pass����5   6   Z� .��5      � $��10q�6   
������� J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      	   	Direction$		 265Q�6   
   Opacity$	
 0.5Q�6/      ShadowDepth$ 0Q�6=      
BlurRadius$ 10Q�6M   .+�5   
   �  � RowDefinitions 5      �� 5      $��15 �6    6.   �� 5      6"   .+�5      �� ���#0A6E9E6   � 5      $��1��6   $��Center=�6     K� ZIndex$ 1��6<   ��5      �� 5       �� 
TargetType" �6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�67    �� Triggers 5      �� 5       �� Binding 6*   �� *	IsLoading+ �� Value True6H   .a�5   "   ��  � y�$ Visible=�6?   5       5"       5$      �� 5%      �� 5&      .+�5(      �� .+�5*      "  FontAwesome.WPF.ImageAwesome     Icon$ Spinner=�6&      
Foreground �	#FF007BAB   Spin$
 True��5+   "   $��50��6/      SpinDuration$ 1Q�5,   "   5.      5/      �� 50      $��1��6   .+�51      �� -   5         ��Name$ Login��51   1   $��14(�6@      styleLog#���   52      
 � Tag$  Login��53      $��24��6'   $	��340��63   $��Right=�54       �� Left$	 131��66   
 �� Top$ 32��6H   ��51      �� *Login+54   H   7   1PultOperatorNetCore.Components.BidablePasswordBox  55      -   5          Name$
 pass��57   0   7   1PultOperatorNetCore.Components.BidablePasswordBox   KeyDown$  BidablePasswordBox_KeyDown��58   0   $��14(�56      $��24��6*   $	��340��66   $��Right=�59      $	 131��66   $ 65��6H      Password 55   0   �� *
Password+  �� UpdateSourceTrigger$  PropertyChanged=�! �� Mode$! TwoWay=�59   H   �� 5:      -   5        " � Cursor$
" Hand��5:   .   $��
Выход��6<   $��25��6M   $	��155��6Y   
�������$��2q�6x   ���#0A6E9E$	 139��6�   $ 99��6�   ��5;      �� 5<      " ��6    .�5=      ��  � �� �#0A6E9E6;   5>      # � 	Resources# 5@      ��%d   '��       �� 5A      " ��6    .�5B      ��  �@��CornerRadius$ 5,0,0,5��6=   5C      5D      5E      �� 5F      -   5        $ ��Name$$ button_1��5F   6   $
" Hand��6   $��Вход��6'   $��25��5H   9   $	��164��6E   ���#0A6E9E
�������$��0q�6y   $	 294��6�   $ 99��6�   ��5G      �� $ window����5H      �� *ExitCommand+# 5J      ��%d   '��       �� 5K      " ��6    .�5L      ��  �@��CornerRadius$ 0,5,5,0��6=   5M      5N      5O      �� 5P      -   5        $!��Изменит пароль��5P      $
" Hand��62   $	 333��6@   $	 132��6R   ���#60656E$��13(�6x   $��Center=�6�   $	��Top=�6�     5Q      $��24��6w   $	��340��6�   $	 131��6�   $	 190��6�    60   �� *NewPassword+$  PropertyChanged=�6�     5R      $��24��6z   $	��340��6�   $	 131��6�   $	 251��6�    60   �� *RepeatPassword+$  PropertyChanged=�6�   �� 5S      $!��Введите пароль��6   $	 131��62   $	 166��6D   ���#60656E$��15(�6j   �� 5T      $%��Повторите пароль��6   $	 131��64   $	 226��6F   ���#60656E$��15(�6l   �� 5U      -   5        $$ button_1_Copy��5V   X   $
" Hand��5U      $��Вход��5V   I   $��25��6o   $	��164��6{   ���#0A6E9E
�������$��0q�6�   $	 294��6�   $	 286��6�   ��5U   '   �� *UpdatePassword+��5V      �� $ window��# 5W      ��%d   '��       �� 5X      " ��6    .�5Y      ��  �@��CornerRadius$ 0,5,5,0��6=   5Z      5[      5\      �� 5]      -   5        % ��Name$% 
savePassCB��5]      $%��Запомнить пароль��5a      $	 155��66   $	 134��6H   $��22��6Y   ���#60656E$	��134��6z   $��Center=�6�   $	��Top=�6�   & d� 	IsChecked& 5^      �� *IsCheckedBox+��5_      �� $ 
savePassCB����5`      �� *SaveDataToProjectCommand+5a   �   �� 5b      $��../Images/icon/log.png��6   $��28��68   $ 98��6D   $ 30��6U   $��32��6e   �� 5c      $��/Images/Icon/pass.png��6   $��28��67   $	 100��6C   $ 64��6U   $��32��6e   $
��Left=�6p   $	��Top=�6�   �� 5d      -	   5        $
" Hand��5d      $��25��5f      $	��110��6%   
�������
�������$��0q�5g   ,   $	 140��5h      $	 287��6+   $
��Left=�5i      $	��Top=�64   ��5j      �� 5k      ' �� Orientation$' 
Horizontal=�6%   .+�5l      �� $��/Images/Icon/setting.png��6$   $��28��6F   $	 133��6R   $	 285��6d   $��32��6u   $��Center=�6�   $��Center=�6�   �� 5m      $��Center=�6(   $��Настройка��6C   ���#0A6E9E6T   5n      5q      5s      5t      �� 5u   
   -
   5        ( ��Name$( MessageText��5u      
���  ��$��14(�5w      ) �� TextAlignment$) Center=�5y      $
��Wrap=�6*   $	��Top=�5{      $��114,22,98,0q�6,   $	��368��6A   y�5x      �� *Visubilitu1+��5z      �� *	Message+5{   A   5|      5}      