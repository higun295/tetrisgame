   M S B A M L   `   `   `  ����A  =Tetris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TetrisTetris  5	          Tetris.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5       localclr-namespace:Tetris  5	      -   5          �Name$  window��5       � Title$ Tetris��5      $	��600��5      $	��800��5      $	��600��5      $	��600��5      
�������$��Seogoe UI Light)�5      $��28(�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   ��5!   
   �� 5"       �� ImageSource$ Assets/Background.png��6   .+�5%   
   (� $��1��5&      $��1��5'      $��0 0 0 20q�5(      .��5*      �� -   5         ��Name$ 
GameCanvas��5+      ���#101010$	��250��5-      $	��510��5.      }�. 50      52      �� 54   
   -   5         ��Name$ 	ScoreText��55      $��0��56      $��1��57      $��Score : ��58      $
��0 10q�59       �� TextAlignment$ Center=�5:      �� 5=   
   $��1��5>      $��0��5?      $��Center=�5@      $��Right=�5A      .+�5C      �� $
��Hold��5D      $ Center=�5E      �� 5G      -   5         ��Name$ 	HoldImage��5H      $��20q�5I      $	��125��5J      5L      �� 5N   
   $��1��5O      $��2��5P      $��Center=�5Q      $
��Left=�5R      .+�5T      �� $
��Next��5U      $ Center=�5V      �� 5X      -   5        $ 	NextImage��5Y      $��20q�5Z      $	��125��5[      5]      � 5_   
   -   5        	 �Name$	 GameOverMenu��5`      ���	#CC000000$��2��5b      $��3��5c      $y�Hidden=�5d      .+�5f      �� $��Center=�5g      $��Center=�5h      .+�5j      �� $��	Game Over��5k      $��48(�5l      $ Center=�5m      �� 5o      -   5        $ FinalScoreText��5p      $��Score : ��5q      $��36(�5r      $ Center=�5s      �� 5u      -   5        
 ��Name$
 	PlayAgain��5v      $��
Play Again��5w      
������$��0 20 0 0q�5y      $��5q�5z      5{      5}      5~      5      5�      