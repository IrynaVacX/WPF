   M S B A M L   `   `   `  ����P  LWpfApp6-3_BookRecipes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApp6_3_BookRecipesWpfApp6_3_BookRecipes  5   	   &     WpfApp6_3_BookRecipes.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfApp6_3_BookRecipes     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ���	#FFB27D5E � RowDefinitions 5
   
   �� 5      $	��15* �6   �� 5      $
��200* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��7* �6   .+�5   
   �� -   5         ��Name$
 but1��5      ���	#FFE6BEA0$��Open recipe folder��66   $��0��6S   $��0��6c   $��5,5,5,5q�6p   6�   �� 5   
   -   5         ��Name$ RecipesListBox��5      $��0��6*   $��1��6:   $��5,5,5,5q�6G   ���	#FFE6BEA0$
��Lato)�6�   $��20(�6�   � 5   
   $��1��6   $��0��6   $��2��6,   $��0,5,5,5q�6=   ���	#FFEBC8B4 5      �� 5      $��1* �6    �� 5      $��4* �6    �� 5      $��5* �6     5      �� 5      $��3* �6#   �� 5      $��4* �6#   .+�5      �� -   5         ��Name$ RecipeImage��5      $��1��6)   $��0��66   $	��200��6F    �� Left$ 10��6V   
 �� Top$ 45��6g   $��0,0,0,0q�6w   �� 5      -   5         ��Name$ 
RecipeName��5      $��0��6,   $��0��69   $��2��6I   $
��Name��6]   $��35��6i   $	��535��6u   $ 10��6�   $ 10��6�   	 �� TextAlignment$	 Center=�6�   $
��Lato)�6�   $��22(�6�   $
��Bold"�6�   ,� 5       -   5        
 ,�Name$
 RecipeIngred��5    '   $��1��6=   $	 267��6M   $ 45��6_   $
��Lato)�6o   $��20(�6�   $��3q�6�   ���	#FFB27D5E$��0,2,10,0q�6�   $��1��6�   .��5!      /� .T�5"      J� .*�6    .*�5#      �� $�Ingridients��6   5$      5%      5&      ,� 5'      -   5        $
 RecipeCooking��5'   '   $��2��6>   $��0��6K   $��2��6[   $ 10��6o   $	 245��6�   $��10,10,10,10q�6�   $
��Lato)�6�   $��20(�6�   $��3q�6�   ���	#FFB27D5E.��5(      /� .T�5)      J� .*�6    .*�5*      �� $�Cooking��6   5+      5,      5-      5.      5/      50      