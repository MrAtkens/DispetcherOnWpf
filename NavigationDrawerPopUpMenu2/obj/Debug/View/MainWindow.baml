   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:NavigationDrawerPopUpMenu2NavigationDrawerPopUpMenu2  5   	   +    %NavigationDrawerPopUpMenu2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:NavigationDrawerPopUpMenu2     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��800��5	      $	��980��6*   $
��1000��69   $
��1280��6H   $y�Visible=�6U   
�������  � 
ResizeMode$  CanResizeWithGrip=�6}    � WindowStartupLocation$ CenterOwner=�6�    � WindowStyle$
 None=�6�    � Icon$= 7/NavigationDrawerPopUpMenu2;component/Image/SecLogo.png��6�   .��5      � -   5         �Name$ MainGrid��5      $y�Visible=�6    J� Opacity$
 0.95Q�6/    � ColumnDefinitions 5      �� 5      $��* �6    � RowDefinitions 5      �� 5      $��45 �6   �� 5      $��* �6   .+�5      � -   5        $ HeaderLogin��5   	   $y�	Collapsed=�6   $��0��66   $
 0.95Q�6C   ���	#FF0080FF J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 1Q�6   
   ShadowDepth$
 1Q�6&      Color$ 	#FFACACAC��66   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�6)   $��Right=�6D   .+�5      �� -   5         ��Name$ MinimazeLogin��5      $	����6<   $
��10px(�6O   $��Segoe MDL2 Assets)�6`   ��6%   Z� ��6   Z� 6�   �� 5       -   5        $ MaximazeLogin��5       $	����6<   $
��10px(�6O   $��Segoe MDL2 Assets)�6`   ��6%   Z� ��6   Z� 6�   �� 5!      -   5        $ 
CloseLogin��5!      $	����69   $
��10px(�6L   $��Segoe MDL2 Assets)�6]   ��6"   Z� ��6|   Z� 6�   5"      �� 5%      $��Center=�6   $��Center=�6,   $��22(�6G   �� 6W   $�Security Face��6[   6s   5&      � 5)      -   5        $ Login��5)   	   $y�	Collapsed=�6   $��1��6/   .+�5,      �� ��5-      �� 5.       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6,   .��5/      �  � Color$ 	#FF2281D1��6   � 50      $ 	#FF34268A��6    � Offset$ 1Q�6'   � 51      $ 	#FF33288B��6   $ 0.546Q�6'   52      54      � 55       56      �� 57      $	��91* �6   �� 58      $
��368* �6   �� 59      $	��59* �6   �� 5:      $
��129* �6    5<      �� 5=      $
��395* �6   �� 5>      $
��283* �6   �� 5?      $
��394* �6   .+�5B      � $��1��6   $��1��6    J� RenderTransformOrigin$ 0.5,0.5&�6(   .+�5D      �� $��1��6   $��1��6#   
������� �� RadiusX$ 20��6=    �� RadiusY$ 20��6J   �� 5F      $��1��6   $��0��6#   $ 0.5,0.5&�60   .+�5G      �� $��LOGIN��6   $��Center=�6   $	��Top=�6;   $��25q�6S   
�������$��30(�6q   5I      �� 5J      $��Center=�6   $��1��6-   $��0��6=   .+�5K      �� -   5         ��Name$ LoginTextBox��5K      $��20 10 20 10q�6&   
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Login��6N    %  !MaterialDesignFloatingHintTextBox#��[  6i   $��Champagne & Limousines)�6�   $��20(�6�   G� 5L      -	   5         G�Name$ Password��5L      $��20 10 20 10q�6&   
���   �$ Password��6N    ) %MaterialDesignFloatingHintPasswordBox#��[ 6l   $��Champagne & Limousines)�6�   $��20(�6�   5M      �� 5N      $��0��6   $��1��6   $��Bottom=�6/   .+�5O      �� -
   5        $ 
LoginEnter��5O      $��20 10 20 20q�6#   $��Bottom=�68   $��LOGIN��6S   6c   5P      5Q      5R      5S      � 5V      -   5        $ Header��5V   	   $y�Visible=�6   ���	#FF0080FF$��0��6F   $
 0.95Q�6S    5W        5X      $	 1Q�6   $
 1Q�6&   $ 	#FFACACAC��66   .+�5Z      �� $ 
Horizontal=�6   $��Center=�6)   $��Right=�6D   .+�5[      �� -   5        $ Minimaze��5[      $	����67   $
��10px(�6J   $��Segoe MDL2 Assets)�6[   ��6    Z� ��6z   Z� 6�   �� 5\      -   5        $ Maximaze��5\      $	����67   $
��10px(�6J   $��Segoe MDL2 Assets)�6[   ��6    Z� ��6z   Z� 6�   '  !MaterialDesignThemes.Wpf.PopupBox  5]         PlacementMode$ BottomAndAlignRightEdges=�6      	StaysOpen .     PopupContent. 5^      �� $	��150��6   .+�5_      �� -   5        $ LogOut��5_      $��LogOut��64   �� 5`      $��Account��6   �� 5a      $
��Help��6   �� 5b      �� 5c      -   5        $
 Exit��5c      $��Logout��60   5d      5e      5f      �� 5h      $ 
Horizontal=�6   $	��Top=�6)   $
��Left=�6A   .+�5j      �� -   5         ��Name$ AccountName��5j      $��Admin��6%   $��Center=�62   $��	20 10 0 0q�6M   $��16(�6`   5k      �� 5m      -   5        $ 
HeaderText��5m      $��Center=�6#   $��Center=�6@   $��22(�6[   �� 6k   $�Введите город��6o   6�   5n      � 5q      -   5        $ 
GridSearch��5q   	   $y�Visible=�6   $��1��62   .+�5s      �� $��4��6   ��5t      �� 5u      $ 0.5,1&�6   $ 0.5,0&�6,   .��5v      � $ 	#FF2281D1��6   � 5w      $ 	#FF34268A��6   $ 1Q�6'   � 5x      $ 	#FF33288B��6   $ 0.546Q�6'   5y      5{      &   System.Windows.Controls.DataGrid  5}      -   5          Name$ ProcessTable��5}      $��40,40,40,300q�6$   �� 5~      -   5        $ ButtonSearch��5~      $��Удалить��6#   $��Century Gothic)�65   $��36(�6Q   $��1q�5      ���	#FF2196F3���#ffffff$��Center=�6D   $��72,705,84,192q�6`   $��50��5�      }�. ��6?   Z� 5�      5�      5�      