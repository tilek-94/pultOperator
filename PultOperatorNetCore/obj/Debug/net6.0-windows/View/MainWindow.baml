   M S B A M L   `   `   `  ����N  JPultOperatorNetCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:PultOperatorNetCorePultOperatorNetCore  5   	   $    PultOperatorNetCore.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:PultOperatorNetCore     5   	   -   5          �Name$  Mainwin��5   	    � Icon$ ../Images/Icon/icon.ico��5	   	    � Title$ PultOpertatora��5
   	   $	��700��6    $	��400��6-    � WindowStyle$
 None=�69   
������  � Topmost$
 True��5      $��0,0,0,0q�6    � AllowsTransparency$
 True��6%   .��5      � -   5        .+�5   
   � -   5         �Name$ 	GridPanel��5   7   $	��300��6   $��Right=�6   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#   	   	Direction$		 250Q�63   
   ShadowDepth$
 1Q�6C   .+�5      � .+�5      �� $��3q�6   
������ ���	#FF0070B8._�5      �  � RowDefinitions 5      �� 5      $��30 �6,   �� 5      �� 5      $	��275 �6,   .+�5      � ���	#FF0070B8$��0��66    K� ZIndex$ 1��6C    � ColumnDefinitions 5      �� 5    "   �� 5!   "   �� 5"   "   $��65 �63    5$        5%   "   $ 10Q�63   $		 250Q�6C   $
 1Q�6S   .+�5(      �� $��1��6)    �� Orientation$ 
Horizontal=�69   $��Right=�6R   $��Center=�6n   .+�5)   "   �� -   5         
  BtnLng#���   5)   )   $��RU��6J   6W   �� 5*   "   -   5        #���   5*   )   $��KG��6J   6W   �� 5+   "   -   5        #���   5+   )   $	��ENG��6J   6X   5,      �� 5-      $��2��6)   $ 
Horizontal=�69   .+�5.   "   �� -   5        $��-��5.   *   $��20(�66     BtnForm#���  6D   ���	#FF0EA5BD5/   <   �� 51   "   $��X��6)   #���  53   )   ���	#FFBD1313��51   5   �� *CloseWindowCommand+��52   )   ��  �� ElementName$ Mainwin��54   %   55      �� 57      $ 
Horizontal=�6)   $��0��6B   $��10 0 0 0q�6R   .+�58   "   �� -   5         ��Name$ WindowNambe��58   ,   $��Окно №��6A   $��19(�6O   $
��Wrap=�6]   $
��Bold"�6q   
�������$��Center=�59      $��Center=�63   
������ 6P   �� 5:   "   $��10 0 0 0q�6,   $��22(�6\   $
��Wrap=�6j   $
��Bold"�6~   
�������$��Center=�5;      $��Center=�63   
������ ��5:   >   �� *WindowNumber+5;   P   5<      5=      � 5@      $��1��6   .+�5C      �  5D   "   �� 5E   &   $��40 �64   �� 5F   &   -	   5         ��Name$ RowGrid��5F   ?   $��* �64   6?   �� 5G   &   $��85 �64   .+�5L   "   � $��1��6'    5M   &   �� 5N   *   $	��34* �6;   �� 5O   *   $
��113* �6;   .+�5Q   &   �� $ Vertical=�61   $	��Top=�6w   $��2��6�   ��6H   �� *Width+$ 	GridPanel��.+�5R   *   �� -
   5         ��Name$ Button1��5T   1   $ 1��5R   1     
BtnOchered#���  5S   1   $��40��5T   B   .��5V   .   �� $ 
Horizontal=�69   .+�5W   2   �� -   5        $ OzidanieBtn��5W   <   $��Заверщённые��5X   <   �� 5Y   2   $��10 0 0 0q�6<   ��5Z   1   �� *CompleteTurnCount+5[   /    5\   .     5]   2   $ 10Q�6C   $		 250Q�6S   $
 1Q�6c   5_   +   �� 5`   *   -   5         ��Name$ List1��5`   3   $��0��6B   $y�Hidden=�6M   ��6a   �� *HistoryTurnList+ �� SelectedItem 6�   �� *SelectedTurn+��5a   .   �� 5b   2   .R�5c   6   � $��Stretch=�6<   $��Stretch=�6X    5e   :   �� 5f   >   $��60 �6O   �� 5g   >   $��* �6O   �� 5h   >   $��* �6O   .+�5j   :   �� $ 
Horizontal=�6E   $��
10,10,10,0q�6^   $��0��6r   .+�5k   >   �� $
��Bold"�6a   $��15(�6s   ��6I   �� *Number+6s   5l   ;   �� 5m   :   $ 
Horizontal=�6E   $��	0,10,10,0q�6^   $��1��6q   .+�5n   >   �� $��15(�6c   ��6H   �� *
Services+6c   5o   ;   �� 5p   :   $ 
Horizontal=�6E   $��	0,10,10,0q�6^   $��2��6q   .+�5q   >   �� $��15(�6�   ��6H   �� *	StartDate+ �� StringFormat$ {0:dd.MM.yy / HH:mm}��6�   5r   ;   5s   7   5t   3   5v   +   �� 5w   *   -   5        $ Button2��5x   1   $ 1��5w   1   #���  6B   $��40��5x   B   .��5y   .   �� $ 
Horizontal=�69   .+�5z   2   �� -   5        $ 
OcheredBtn��5z   <   $��Очередь��6P   �� 5{   2   $��10 0 0 0q�6<   ��6N   �� *ActiveTurnCount+5|   /    5}   .     5~   2   $ 10Q�6C   $		 250Q�6S   $
 1Q�6c   5�   +   �� 5�   *   -   5        $ List2��5�   ?   $	��180��62   ��6N   �� *
TurnList+ 5�   1   �� *SelectedTurn+��5�   .   �� 5�   2   .R�5�   6   � $��Stretch=�6<   $��Stretch=�6X    5�   :   �� 5�   >   $��60 �6O   �� 5�   >   $��* �6O   �� 5�   >   $��* �6O   .+�5�   :   �� $ 
Horizontal=�6E   $��
10,10,10,0q�6^   $��0��6r   .+�5�   >   �� $
��Bold"�6a   $��15(�6s   ��6I   �� *Number+6s   5�   ;   �� 5�   :   $ 
Horizontal=�6E   $��	0,10,10,0q�6^   $��1��6q   .+�5�   >   �� $��15(�6b   ��6H   �� *	Service+6b   5�   ;   �� 5�   :   $ 
Horizontal=�6E   $��	0,10,10,0q�6^   $��2��6q   .+�5�   >   �� $
��Bold"�5�   C   $��14(�6X   ��5�   H   �� *
CameFrom+5�   X   5�   ;   5�   7   5�   3   5�   +   5�   '   5�   #   ]� 5�   "   $��0��6,   $
��Left=�69   .+�5�   &   ��   LblPrior#���  6,   ���	#FF0070B8��6O   �� *
UserName+6l   5�   #   � 5�   "   $��2��6'   
�������$ 1��5�   '   .+�5�   &   �� 
����� �$��0,1,0,1q�6@   ._�5�   *   �� $��70(�60   $��Medium"�6>   $��	0,-17,0,0q�5�   ,   
������ ���#515151$��Center=�5�   ,   $	��Top=�5�   ,   ��5�   ,   �� *CurentTurn.Number+5�   ,   5�   '   5�   #   5�      5�      � 5�      $��2��6   .+�5�      � -   5        $ Grid1��5�   #    5�   "   �� 5�   &   $��50 �64   �� 5�   &   $��* �64   �� 5�   &   $��85 �64   �� 5�   &   $��70 �64   �� 5�   &   $��20 �64   .+�5�   "   � $��0��6'   $��0 7 0 0q�64    5�   &   �� 5�   *   �� 5�   *   $��0.561* �6;   .+�5�   &   �� -   5        $ NextBtnPesr��5�   -   $��0��5�   -   $��0��5�   -    � Cursor$
 Hand��5�   -   $	��134��6;     
ButtonNext#���  5�   -   $��80��5�   -   
 � Tag$ Следуюший��5�   -   $
��Left=�5�   -   $��	8,6,0,-43q�6H   ��5�   -   �� *NextCommand+5�   H   5�   #   � 5�   "   $��1��6'    5�   &   �� 5�   *   $
��289* �6;   �� 5�   *   $��5* �6;   .+�5�   &   �� -   5        $ Pause��5�   H   $
 Hand��6-   $��0��6;     ButtonNextFals#���  5�   -   $ 
Пауза��5�   -   $��35��5�   %   $	��134��61   $��	152,9,0,6q�5�   -   $
��Left=�6@   ��5�   -   �� *PauseCommand+5�   @   �� 5�   &   -   5        $ ButtonFaile��5�   D   $
 Hand��6)   $��0��67   #���  5�   )   $ Неявка��5�   )   $��35��5�   )   $	��135��65   $��152,54,0,-39q�5�   )   $
��Left=�6?   ��5�   -   �� *AbsenceCommand+5�   ?   �� 5�   &   -   5        $ Vyzov��5�   -   $��0��6<   $��14(�5�   -   $ 
Вызов��5�   -   
���   �#���  5�   -   $
��Left=�6R   $��152,-40,0,50q�6m   $	��133��6�   ��5�   -   �� *CallCommand+��5�   -   �� $ Vyzov��5�   �   5�   #   � 5�   "   $��2��6'    5�   &   �� 5�   *   $
��147* �6;   �� 5�   *   $	��64* �6;   �� 5�   *   $	��84* �6;   .+�5�   &   � $��0��6+   $��3,0,0,0q�6;    5�   *   �� 5�   .   $��* �6<   �� 5�   .   $��* �6<   .+�5�   *   �� -   5        $ AndBtn��5�   _   $
 Hand��6Q     	ButtonEnd#���  6o   $��35��5�   %   $	��136��61   $ Завершить��6=   $��2,0,0,0q�6b   $
��Left=�6s   $��1��6�   ��5�   1   �� *
EndCommand+5�   �   5�   '   � 5�   &   $��1��6+   $��2��6;    5�   *   �� 5�   .   $��42 �6<   �� 5�   .   .+�5�   *   �� -   5        $ Kassa��5�   p   $
 Hand��6U   $��0��6c   #���  6   $ На кассу��6�   $��35��5�   %   $	��135��61   $
��Left=�6=   $��
-140,4,0,3q�6X   ��5�   1   �� *ToKassaCommand+5�   l   �� 5   *   -   5        $ Otlozhit��5   q   $
 Hand��6V   $��1��6d   #���  6�   $ Отложить��6�   $��35��5  %   $	��135��61   ��5   1   �� *PostponeCommand+5  =   5  '   5  #   � 5  "   $��3��6'   $��0 5 0 0q�64   .+�5  &   �� $ Vertical=�61   .+�5  *   �� $��25��6{   $��Center=�6�   $	��270��6�    J� RenderTransformOrigin$ 
0.504,0.52&�6�   ��64   �� *
UserList+ 6U   �� *SelectedUser+��5
  .   �� 5  2   .R�5  6   �� .+�5  :   �� ��6D   �� *
UserName+5  7   5  3   5  +   �� 5  *   -   5        $ Perevod��5  b   $��1��6U   #���  6s   $  Перенаправить��6�   $��35��5  %   $��5q�61   ��5  1   �� *RedirectCommand+5  <   5  '   5  #   � 5  "   $��4��6'   .+�5  &   �� $ 
Horizontal=�61   .+�5  *   �� $#��Автовызов через��64   ���	#FF0091BB6K   �� 5  *   $��5 0 0 0q�6O   
���  ����64   �� *	TimerCall+6`   �� 5  *   $�� мин��64   ���	#FF0091BB6@   5  '   5  #   5      5"     5#     5$     5%     �� 5&     -   5        $ BtnHide��5&  -   $	��175��6   $��50��6"   $
��Left=�5'     $
 Hand��60   $��Bottom=�5(     $��
-50 0 0 70q�60     BtnShow#���  5)  ,   .��5*     �� .+�5+     �� $��../Images/icon/arrow.png��6   $��40��6>   $��40��6I   �� 5,     $��../Images/icon/arrow.png��6   $��40��6>   $��40��6I   �� 5-     $��../Images/icon/arrow.png��6   $��40��6>   $��40��6I   �� 5.     $��../Images/icon/arrow.png��6   $��40��6>   $��40��6I   5/     50     52     �� 55  
   -   5        $ BtnShow��55     $
��Left=�6"   $��Bottom=�6=   $��85��56     $��85��6   $��18 0 0 0q�6(   #���  57     
������ .��59     �� $"��../Images/icon/move-left.png��6    5:       5;     $ 10Q�6'   $		 250Q�67   $
 1Q�6G   5=     5>     5?     5@     