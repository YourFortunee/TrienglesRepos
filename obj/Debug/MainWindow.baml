   M S B A M L   `   `   `  ����K  GTestingTriengles, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TestingTrienglesTestingTriengles  5   	   !    TestingTriengles.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TestingTriengles     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
����� �.��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ 
InputBlock��5      $E��?Введите длины сторон треугольника��6,   $��Center=�6U   $��Center=�6p   $��20(�6�   �� 5      -   5        $ Resultat��5      $��Bottom=�6*   $��Center=�6E   $y�Hidden=�6b   $��20(�6v   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ 	FirstSide��5      $��0��6)   
������� �� TextAlignment$ Center=�5      $��Center=�6-   $��20(�6O   $	��150��6]   $��75��6i   �� 5      -   5        $ 
SecondSide��5      $��1��6*   
�������$ Center=�5      $��Center=�6-   $��20(�6O   $	��150��6]   $��75��6i   �� 5      -   5        $ 	ThirdSide��5      $��2��6)   
�������$ Center=�5      $��Center=�6-   $��20(�6O   $	��150��6]   $��75��6i   5      � 5    
   $��2��6   .+�5!      �� -   5        $��CheckBut��5!      $��Проверить��6%   {�. $��20(�5"   &   
������$	��200��6L   $��80��6X   �� 5#      -   5         ��Name$ 
RestartBut��5#      $'��!Попробовать снова��6)   $y�Hidden=�5$      $��20(�6)   
������$	��200��6O   $��80��6[   5%      5&      5'      