   M S B A M L   `   `   `  ����A  =KP_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KP_WPFKP_WPF  5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit 5   	       KP_WPF.DataBase   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:KP_WPF     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ DataBase��5
   	   $	��600��6   $	��800��6'   $	��600��63   $	��770��6C    � Icon 5      H� 5   
    H� Drawing 5      � 5       � Brush
 �  ��
 � Pen 5      >� 5       >� 	Thickness$ 10Q�6    >� Brush
 �   �6-    � Geometry 5      � 5      .��5      @� 	 @� Center$	 100,240&�6.   
 @� RadiusX$
 30Q�6?    @� RadiusY$ 30Q�6L   �� 5       �� Rect 5   "   � 5   &    � Size$ 40, 120��6+    � Location$ 85, 50&�6:   5      5      5      5      .��5       � .+�5!   
   �� -   5         ��Name$ button_back��5!      $��
назад��6&   $��40��66   $
��Left=�6A   $	��Top=�6\   $��5,10,0,0q�6t   6�   �� 5"   
   -   5        $ button_refresh��5"      $��Обновить��6)   $
��Left=�6<   $	��Top=�6W   $��600,400,0,0q�6o   $��22��6�   �� 5#   
   $��Button��6   $
��Left=�6"   $��22��6=   $��700,400,0,0q�6I   $	��Top=�6^   �� 5$   
   -   5         ��Name$ 
tb_surname��5$      $
��Left=�6&   $	��Top=�6A   $��50, 50, 0, 0q�6Y   $��30��6o   $	��150��6~   $
��Left=�6�   $��Center=�6�   �� 5%   
   -   5        $ tb_phoneNumber��5%      $
��Left=�6*   $	��Top=�6E   $��50, 100, 0, 0q�6]   $��30��6t   $	��150��6�   $
��Left=�6�   $��Center=�6�   �� 5&   
   -   5        $ tb_id��5&      $��Right=�6!   $	��Top=�6=   $��450, 15, 150, 0q�6U   $��30��6n   $	��150��6}   $
��Left=�6�   $��Center=�6�   �� 5'   
   -   5        $ 	tb_tariff��5'      $
��Left=�6%   $	��Top=�6@   $��50, 200, 0, 0q�6X   $��30��6o   $��50��6~   $
��Left=�6�   $��Center=�6�   6�   �� 5(   
   -   5        $ tb_discount��5(      $
��Left=�6'   $	��Top=�6B   $��150, 200, 0, 0q�6Z   $��30��6r   $��50��6�   $
��Left=�6�   $��Center=�6�   6�   �� 5)   
   $
��Left=�6   $	��Top=�6+   $��200, 50, 0, 0q�6C   $��Фамилия��6Z   �� 5*   
   $
��Left=�6   $	��Top=�6+   $��200, 100, 0, 0q�6C   $!��Номер телефона��6[   �� 5+   
   $
��Left=�6   $	��Top=�6+   $��200, 150, 0, 0q�6C   $��Дата звонка��6[   �� 5,   
   $
��Left=�6   $	��Top=�6+   $��100, 200, 0, 0q�6C   $��
Тариф��6[   �� 5-   
   $
��Left=�6   $	��Top=�6+   $��200, 200, 0, 0q�6C   $��Скидка��6[   �� 5.   
   $
��Left=�6   $	��Top=�6+   $��200, 250, 0, 0q�6C   $��Дата начала��6[   �� 5/   
   $
��Left=�6   $	��Top=�6+   $��200, 300, 0, 0q�6C   $!��Дата окончания��6[   �� 50   
   $��Right=�6   $	��Top=�6,   $��0, 15, 130, 0q�6D   $��id��6[   &   System.Windows.Controls.DataGrid  51   
   -   5          Name$ main_dataGrid��51      $��Stretch=�6*   $��450,50,10,0q�6H   $	��Top=�6]      AutoGenerateColumns . $	��300��6�      CanUserReorderColumns .     MinColumnWidth$ 30Q�6�      
IsReadOnly . 6�   �� 52   
   -	   5        $ 
button_add��52      $��Добавить��6%   $��60��68   $
��Left=�6C   $	��Top=�6^   $��
50,350,0,0q�6v   6�   �� 53   
   -
   5        $ button_delete��53      $��Удалить��6(   $��60��6:   $��Right=�6E   $	��Top=�6a   $��	0,20,50,0q�6y   6�   �� 54   
   -   5         ��Name$ img_surnameError��54      $��/Icon/error.png��6*   $��20��6C   $��20��6N   $
��Left=�6Z   $	��Top=�6u   $��30, 55, 0, 0q�6�   $y�	Collapsed=�6�    � ToolTip 55      _� 56      $@��:Введите фамилию с большой буквы��6   58      �� 59   
   -   5        $ img_phoneNumberError��59      $��/Icon/error.png��6.   $��20��6G   $��20��6R   $
��Left=�6^   $	��Top=�6y   $��30, 105, 0, 0q�6�   $y�	Collapsed=�6�    5:      _� 5;      $<��6Формат номер телефона +375XXYYYYYYY��6   5=      �� 5>   
   -   5        $ img_dateError��5>      $��/Icon/error.png��6'   $��20��6@   $��20��6K   $
��Left=�6W   $	��Top=�6r   $��30, 155, 0, 0q�6�   $y�	Collapsed=�6�    5?      _� 5@      $?��9Введите корректную дату звонка��6   5B      �� 5C   
   -   5        $ img_tariffError��5C      $��/Icon/error.png��6)   $��20��6B   $��20��6M   $
��Left=�6Y   $	��Top=�6t   $��30, 205, 0, 0q�6�   $y�	Collapsed=�6�    5D      _� 5E      $D��>Введите корректный тариф и скидку��6   5G      �� 5H   
   -   5        $ img_dateStartError��5H      $��/Icon/error.png��6,   $��20��6E   $��20��6P   $
��Left=�6\   $	��Top=�6w   $��30, 255, 0, 0q�6�   $y�	Collapsed=�6�    5I      _� 5J      $L��FВведите корректную дату начала звонка��6   5L      �� 5M   
   -   5        $ img_dateEndError��5M      $��/Icon/error.png��6*   $��20��6C   $��20��6N   $
��Left=�6Z   $	��Top=�6u   $��30, 305, 0, 0q�6�   $y�	Collapsed=�6�    5N      _� 5O      $\��VДата окончания звонка должна быть позже начала��6   5Q      �� 5R   
   -   5        $ img_idError��5R      $��/Icon/error.png��6%   $��20��6>   $��20��6I   $��Right=�6U   $	��Top=�6q   $��0, 20, 300, 0q�6�   $y�	Collapsed=�6�    5S      _� 5T      $K��EВведите корректный ID, который больше 0��6   5V      &   Xceed.Wpf.Toolkit.DateTimePicker  5W   
   -   5          Name$ dt_date��5W   !   $
��Left=�62   $	��Top=�6M   $��50, 150, 0, 0q�6e   $��30��6|   $	��150��6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   	AllowSpin .     Maximum$ 12/31/2019 23:59:00X�6�      Minimum$ 
1980-01-01X�6�   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ 	ShortDate=�6�   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   AllowTextInput .  $
��Left=�6  $��Center=�6(    5X   
   -   5        $ dt_dateStart��5X   !   $
��Left=�67   $	��Top=�6R   $��50, 250, 0, 0q�6j   $��30��6�   $	��150��6�    .  $ 12/31/2019 23:59:00X�6�   $ 
1980-01-01X�6�   $ FullDateTime=�6�    .  $
��Left=�6  $��Center=�60    5Y   
   -   5        $ 
dt_dateEnd��5Y   !   $
��Left=�65   $	��Top=�6P   $��50, 300, 0, 0q�6h   $��30��6   $	��150��6�    .  $ 12/31/2019 23:59:00X�6�   $ 
1980-01-01X�6�   $ FullDateTime=�6�    .  $
��Left=�6  $��Center=�6.  �� 5Z   
   -   5         ��Name$ 
cb_example��5Z      $
��Left=�6'   $	��Top=�6B   $��50, 400, 0, 0q�6Z   $	��150��6q   .@�5[      �� $��1. Сортировка��6   �� 5\      $&�� 2. Повторы номеров��6   �� 5]      $6��03. Сортировка длительности��6   $	��100��6:   $��WrapWithOverflow=�6I   �� 5^      $/��)4. Самый дорогой звонок��6   $	��100��68   $��WrapWithOverflow=�6G   5_      �� 5`   
   $
��Left=�6   $	��Top=�6,   $��205,396,0,0q�6D   $��Задания��6Y   $��Center=�6k   $
��Left=�6�   $��26��6�   �� 5a   
   $
��Left=�6   $	��Top=�6,   $��500,396,0,0q�6D   $��Группировка��6Y   $��Center=�6o   $
��Left=�6�   �� 5b   
   -   5        $ cb_group��5b      $
��Left=�6%   $	��Top=�6@   $��350, 400, 0, 0q�6X   $	��150��6p   .@�5c      �� $��
1. surname��6   �� 5d      $��2. phoneNumber��6   �� 5e      $��3. date��6   �� 5f      $��	4. tariff��6   �� 5g      $��5. discount��6   �� 5h      $��6. dateStart��6   �� 5i      $��
7. dateEnd��6   5j      5k      5l      