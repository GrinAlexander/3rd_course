   M S B A M L   `   `   `  ����A  =KP_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KP_WPFKP_WPF  5   	       KP_WPF.Article   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:KP_WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Report��5	   	   $	��450��6   $	��800��6%    � Icon 5
      H� 5   
    H� Drawing 5      � 5       � Brush
 �  ��
 � Pen 5      >� 5       >� 	Thickness$ 10Q�6    >� Brush 5      �� 5   "   .��5   &   �  � Offset$	 0.0Q�63   	 � Color$
	 Blue��6@   � 5   &   $	 0.5Q�63   $	 White��6@   � 5   &   $	 1.0Q�63   $
	 Blue��6@   5   #   5      
 � Geometry
 5      � 5      .��5      @�  @� Center$ 50,50&�6.    @� RadiusX$ 50Q�6=    @� RadiusY$ 50Q�6J   @� 5      $ 50, 50&�6.   $ 30Q�6>   $ 30Q�6K   5      5      5!      .��5#      � .+�5$   
   �� -   5         ��Name$ button_back��5$      $��
назад��6&   $��40��66   $
��Left=�6A   $	��Top=�6\   $��5,10,0,0q�6t   6�   �� 5%   
   $��50, 50, 50, 0q�6   $��Visible=�6.   $��Visible=�6T   .��5&      �� -   5         ��Name$ 
image_main��5&      $��	/Page.jpg��6(   $��Stretch=�6;   $��UniformToFill=�6Y   5'      � 5(   
   -   5         �Name$ 	MyContent��5(      .+�5)      o� -   5         o�Name$ menu_general��5)      $��32��6)   $	��183��65   
�������.@�5*      m� $��Файл��6   .@�5+      m� -   5         m�Name$ menu_saveas��5+      $"��Сохранить как...��64   6N   m� 5,      -   5        $ 
menu_print��5,      $��Печать��63   6C   5-      m� 5.      $��
Поиск��6   m� 5/      $��
Выход��6   .@�50      m� -   5        $+��%Выйти в главное меню��50      6=   �� 51      m� 52      -   5        $ 	menu_exit��52      $*��$Выйти из приложения��62   6O   53      55      56      57      58      