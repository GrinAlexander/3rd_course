   M S B A M L   `   `   `  ����A  =KP_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KP_WPFKP_WPF  5   	       KP_WPF.Test   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:KP_WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$
 Test��5	   	   $	��800��6   $	��800��6#   $	��600��6/   $	��600��6>    � Icon 5
      H� 5   
    H� Drawing 5      � 5       � Brush
 �  ��
 � Pen 5      >� 5       >� 	Thickness$ 10Q�6    >� Brush
 �   �6-    � Geometry 5      � 5      .��5      �� 	 �� Rect	 5   "   � 5   &   
 � Size$
 100, 160��6+    � Location$ 50, 50&�6;   5      �� 5      	 5   "   � 5   &   $
 80, 120��6+   $ 50, 50&�6:   5      5      5      5!      .��5#      � -   5         �Name$ 
layoutRoot��5#      
�������.+�5$   
   �� -   5         ��Name$ button_back��5$      $��
назад��6&   $��40��66   $
��Left=�6A   $	��Top=�6\   $��5,10,0,0q�6t   6�   �� 5%   
   $8��21. Я чувствую подавленность.��6   $��30, 30, 0, 0q�67   $	��Top=�6M   $
��Left=�6e   �� 5&   
   $G��A2. Утром я чувствую себя лучше всего.��6   $��30, 60, 0, 0q�6@   $	��Top=�6V   $
��Left=�6n   �� 5'   
   $d��^3. У меня бывают периоды плача или близости к слезам.��6   $��30, 90, 0, 0q�6P   $	��Top=�6f   $
��Left=�6~   �� 5(   
   $6��04. У меня плохой ночной сон.��6   $��30, 120, 0, 0q�67   $	��Top=�6N   $
��Left=�6f   �� 5)   
   $C��=5. Аппетит у меня не хуже обычного.��6   $��30, 150, 0, 0q�6>   $	��Top=�6U   $
��Left=�6m   �� 5*   
   $����6. Мне приятно смотреть на привлекательных женщин(мужчин), разговаривать с ним, находиться рядом��6   $��30, 180, 0, 0q�6{   $	��Top=�6�   $
��Left=�6�   �� 5+   
   $5��/7. Я замечаю, что теряю вес.��6   $��30, 210, 0, 0q�67   $	��Top=�6N   $
��Left=�6f   �� 5,   
   $2��,8. Меня беспокоят запоры.��6   $��30, 240, 0, 0q�64   $	��Top=�6K   $
��Left=�6c   �� 5-   
   $G��A9. Сердце бьётся быстрее, чем обычно.��6   $��30, 270, 0, 0q�6@   $	��Top=�6W   $
��Left=�6o   �� 5.   
   $9��310. Я устаю без всяких причин.��6   $��30, 300, 0, 0q�69   $	��Top=�6P   $
��Left=�6h   �� 5/   
   $B��<11. Я мыслю так же ясно, как всегда.��6   $��30, 330, 0, 0q�6?   $	��Top=�6V   $
��Left=�6n   �� 50   
   $?��912. Мне легко делать то, что умею.��6   $��30, 360, 0, 0q�6=   $	��Top=�6T   $
��Left=�6l   �� 51   
   $d��^13. Чувствую беспокойство и не могу усидеть на месте.��6   $��30, 390, 0, 0q�6P   $	��Top=�6g   $
��Left=�6   �� 52   
   $B��<14. У меня есть надежды на будущее.��6   $��30, 420, 0, 0q�6>   $	��Top=�6U   $
��Left=�6m   �� 53   
   $H��B15. Я более раздражителен, чем обычно.��6   $��30, 450, 0, 0q�6A   $	��Top=�6X   $
��Left=�6p   �� 54   
   $>��816. Мне легко принимать решения.��6   $��30, 480, 0, 0q�6;   $	��Top=�6R   $
��Left=�6j   �� 55   
   $J��D17. Я чувствую, что полезен и необходим��6   $��30, 510, 0, 0q�6B   $	��Top=�6Y   $
��Left=�6q   �� 56   
   $E��?18. Я живу достаточно полной жизнью.��6   $��30, 540, 0, 0q�6?   $	��Top=�6V   $
��Left=�6n   �� 57   
   $l��f19. Я чувствую, что другим людям станет лучше, если я умру.��6   $��30, 570, 0, 0q�6V   $	��Top=�6m   $
��Left=�6�   �� 58   
   $^��X20. Меня до сих пор радует то, что радовало всегда.��6   $��30, 600, 0, 0q�6N   $	��Top=�6e   $
��Left=�6}   �� 59   
   -   5         ��Name$ 
combobox_1��59      $��20��6'   $	��100��63   $	��Top=�6?   $��Right=�6W   $��0, 30, 30, 0q�6s   .@�5:      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5;      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5<      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5=      $��Никогда��6   $
��Left=�6-   $��98��6H   5>      �� 5?   
   -   5        $ 
combobox_2��5?      $��20��6'   $	��100��63   $	��Top=�6?   $��Right=�6W   $��0, 60, 30, 0q�6s   .@�5@      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5A      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5B      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5C      $��Никогда��6   $
��Left=�6-   $��98��6H   5D      �� 5E   
   -   5        $ 
combobox_3��5E      $��20��6(   $	��100��64   $	��Top=�6@   $��Right=�6X   $��0, 90, 30, 0q�6t   .@�5F      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5G      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5H      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5I      $��Никогда��6   $
��Left=�6-   $��98��6H   5J      �� 5K   
   -   5        $ 
combobox_4��5K      $��20��6(   $	��100��64   $	��Top=�6@   $��Right=�6X   $��0, 120, 30, 0q�6t   .@�5L      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5M      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5N      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5O      $��Никогда��6   $
��Left=�6-   $��98��6H   5P      �� 5Q   
   -   5        $ 
combobox_5��5Q      $��20��6(   $	��100��64   $	��Top=�6@   $��Right=�6X   $��0, 150, 30, 0q�6t   .@�5R      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5S      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5T      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5U      $��Никогда��6   $
��Left=�6-   $��98��6H   5V      �� 5W   
   -   5        $ 
combobox_6��5W      $��20��6(   $	��100��64   $	��Top=�6@   $��Right=�6X   $��0, 180, 30, 0q�6t   .@�5X      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5Y      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5Z      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5[      $��Никогда��6   $
��Left=�6-   $��98��6H   5\      �� 5]   
   -	   5        $ 
combobox_7��5]      $��20��6(   $	��100��64   $	��Top=�6@   $��Right=�6X   $��0, 210, 30, 0q�6t   .@�5^      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5_      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5`      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5a      $��Никогда��6   $
��Left=�6-   $��98��6H   5b      �� 5c   
   -
   5        $ 
combobox_8��5c      $��20��6(   $	��100��64   $	��Top=�6@   $��Right=�6X   $��0, 240, 30, 0q�6t   .@�5d      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5e      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5f      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5g      $��Никогда��6   $
��Left=�6-   $��98��6H   5h      �� 5i   
   -   5        $ 
combobox_9��5i      $��20��6(   $	��100��64   $	��Top=�6@   $��Right=�6X   $��0, 270, 30, 0q�6t   .@�5j      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5k      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5l      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5m      $��Никогда��6   $
��Left=�6-   $��98��6H   5n      �� 5o   
   -   5        $ combobox_10��5o      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 300, 30, 0q�6u   .@�5p      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5q      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5r      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5s      $��Никогда��6   $
��Left=�6-   $��98��6H   5t      �� 5u   
   -   5        $ combobox_11��5u      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 330, 30, 0q�6u   .@�5v      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5w      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5x      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5y      $��Никогда��6   $
��Left=�6-   $��98��6H   5z      �� 5{   
   -   5        $ combobox_12��5{      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 360, 30, 0q�6u   .@�5|      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5}      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5~      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ combobox_13��5�      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 390, 30, 0q�6u   .@�5�      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5�      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5�      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5�      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ combobox_14��5�      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 420, 30, 0q�6u   .@�5�      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5�      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5�      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5�      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ combobox_15��5�      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 450, 30, 0q�6u   .@�5�      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5�      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5�      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5�      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ combobox_16��5�      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 480, 30, 0q�6u   .@�5�      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5�      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5�      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5�      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ combobox_17��5�      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 510, 30, 0q�6u   .@�5�      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5�      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5�      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5�      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ combobox_18��5�      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 540, 30, 0q�6u   .@�5�      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5�      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5�      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5�      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ combobox_19��5�      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 570, 30, 0q�6u   .@�5�      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5�      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5�      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5�      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ combobox_20��5�      $��20��6)   $	��100��65   $	��Top=�6A   $��Right=�6Y   $��0, 600, 30, 0q�6u   .@�5�      �� $��Всегда��6   $
��Left=�6,   $��98��6G   �� 5�      $��
Часто��6   $
��Left=�6+   $��98��6F   �� 5�      $��Иногда��6   $
��Left=�6,   $��98��6G   �� 5�      $��Никогда��6   $
��Left=�6-   $��98��6H   5�      �� 5�   
   -   5        $ button_result��5�      $��Bottom=�6(   $��Center=�6C   $��30��6`   $	��120��6l   $��Результат��6x   $��0, 0, 0, 100q�6�   6�   �� 5�   
   -   5         ��Name$ label_result��5�      $��Bottom=�6&   $
��Left=�6A   $��30, 0, 0, 50q�6\   $��Результат: ��6r   5�      5�      