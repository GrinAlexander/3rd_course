   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   H DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CourseProjectCourseProject 5   	      CourseProject.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CourseProject     5   	     � Icon$  icon.ico��5	   	    � Title$ Curve��5
   	   $	��600��6   $	��750��6$   $	��400��60   $	��650��6@    � WindowStartupLocation$ CenterScreen=�6O   .��5      � .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $
��Left=�6F   .+�5      o� $
��Left=�6   $	��Top=�6.   
����� �
�������.@�5      m� $��Файл��6   $��12(�6)   $��Center=�67   $��Center=�6[   .@�5      m� -   5        $��Открыть��5      60   m� 5      -   5        $��Сохранить��5      62   m� 5      -   5        $��Очистить��5      61   m� 5      -   5        $��Закрыть��5      60   5      m� 5      $��О программе��6   $��12(�60   $��Center=�6>   $��Center=�6b   .@�5      m� -   5        $��Разработчик��5      64   m� 5      -   5        $��Справка��5      60   5      5      5      �� 5   
   -   5         ��Name$ tb_x1��5      $
��Left=�6!   $��30��6<   $��	65,60,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $��35��6�   
���   �$��Center=�6�   $��Center=�6�    �� 	MaxLength$ 4��6�   �� 5   
   -   5        $ tb_y1��5      $
��Left=�6!   $��30��6<   $��
125,60,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $��35��6�   
���   �$��Center=�6�   $��Center=�6�   $ 4��6�   �� 5   
   -	   5         ��Name$ label_ox��5      $��Ox��6"   $
��Left=�6/   $��	65,29,0,0q�6J   $	��Top=�6]   $��Center=�6u   $��Center=�6�   $��35��6�   �� 5   
   -
   5        $ label_oy��5      $��Oy��6"   $
��Left=�6/   $��
125,30,0,0q�6J   $	��Top=�6^   $��35��6w   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ label_point1��5      $��Точка 1��6&   $
��Left=�68   $��0,60,0,0q�6S   $	��Top=�6e   $��Center=�6}   $��Center=�6�   $��55��6�   �� 5   
   -   5        $ tb_x2��5      $
��Left=�6!   $��30��6<   $��	65,91,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $��35��6�   
���   �$��Center=�6�   $��Center=�6�   $ 4��6�   �� 5    
   -   5        $ tb_y2��5       $
��Left=�6!   $��30��6<   $��
125,91,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $��35��6�   
���   �$��Center=�6�   $��Center=�6�   $ 4��6�   �� 5!   
   -   5        $ label_point2��5!      $��Точка 2��6&   $
��Left=�68   $��0,92,0,0q�6S   $	��Top=�6e   $��Center=�6}   $��Center=�6�   $��55��6�   �� 5"   
   -   5        $ tb_x3��5"      $
��Left=�6!   $��30��6<   $��
65,122,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $��35��6�   
���   �$��Center=�6�   $��Center=�6�   $ 4��6�   �� 5#   
   -   5        $ tb_y3��5#      $
��Left=�6!   $��30��6<   $��125,122,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $��35��6�   
���   �$��Center=�6�   $��Center=�6�   $ 4��6�   �� 5$   
   -   5        $ label_point3��5$      $��Точка 3��6&   $
��Left=�68   $��	0,122,0,0q�6S   $	��Top=�6f   $��Center=�6~   $��Center=�6�   $��55��6�   �� 5%   
   -   5        $��Построить��5%      $
��Left=�6%   $��
200,60,0,0q�6@   $	��Top=�6T   $	��120��6l   $��30��6x    J� RenderTransformOrigin$ 	0.483,0.5&�6�   6�   �� 5&   
   -   5        	 ��Name$	 comboBox_curve��5&      $��	0,60,30,0q�6+   $��Right=�6>   $	��Top=�6Z   $	��150��6s   $��30��6   $
��Left=�6�   $��Center=�6�   .@�5'      �� $��Кривая Безье��6   �� 5(      $%��Кривая Гильберта��6   �� 5)      $)��#Кривая Серпинского��6   5*      �� 5+   
   $%��Выберите функцию��6   $��Right=�6+   $	��Top=�6G   $��
0,60,180,0q�6_   �� 5,   
   -   5        $��Очистить��5,      $
��Left=�6$   $��200,120,0,0q�6?   $	��Top=�6T   $	��120��6l   $��30��6x   6�   �� 5-   
   -   5        
 ��Name$
 
chkRefresh��5-      $%��Обновлять кривую��6'   $��60, 170, 10, 0q�6B   $	��150��6Z   $��30��6f   $y�Hidden=�6r   $
��Left=�6�   $	��Top=�6�   �� 5.   
   -   5        $��picCanvas_border��5.      $��30,220,30,10q�6)   
���   �$��2q�6S   
�������._�5/      � -   5        $��floatingTip��5/       � AllowsTransparency . $��Relative=�6A    � PlacementTarget 6V   ��  �� ElementName$ picCanvas_border��.��50      �� -   5         ��Name$ tb_popup��50      60   51      52      53      54      