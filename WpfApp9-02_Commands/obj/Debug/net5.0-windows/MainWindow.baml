   M S B A M L   `   `   `  ����N  JWpfApp9-02_Commands, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfApp9_02_CommandsWpfApp9_02_Commands  5   	   $    WpfApp9_02_Commands.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WpfApp9_02_Commands     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    J� InputBindings 5	      �� 5
   
    �� Command$ local:RTBCommands.Bold��6   
 �� Key$ B��6<    �� 	Modifiers$
 Ctrlf�6D   �� 5   
   $ local:RTBCommands.Italic��6   $ I��6<   $
 Ctrlf�6D   �� 5   
   $! local:RTBCommands.Underline��6   $ U��6<   $
 Ctrlf�6D   �� 5   
   $ local:RTBCommands.Clear��6   $	 Tab��6<   $
 Ctrlf�6F   �� 5   
   $" local:RTBCommands.FontSize15��6   $ F1��6<   $
 Ctrlf�6E   �� 5   
   $" local:RTBCommands.FontSize30��6   $ F2��6<   $
 Ctrlf�6E    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ local:RTBCommands.Bold��5      6@     5   
   -   5        $ local:RTBCommands.Italic��5      6@     5   
   -   5        $! local:RTBCommands.Underline��5      6@     5   
   -   5        $ local:RTBCommands.Clear��5      6@     5   
   -   5        $" local:RTBCommands.FontSize15��5      6@     5   
   -   5        $" local:RTBCommands.FontSize30��5      6@     5   
   -   5        $  local:RTBCommands.colorRed��5      6@     5   
   -   5        $" local:RTBCommands.colorGreen��5      6@     5   
   -	   5        $! local:RTBCommands.colorBlue��5      6@   .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��3* �6   �� 5       $��4* �6   �� 5!      $��3* �6    � RowDefinitions 5#   
   �� 5$      $��1* �6   �� 5%      $	��10* �6   .+�5'   
   c� $��0��6   $��3��6   .@�5(      �� -
   5        	 ��Name$	 butBold��5(      $
��Bold��6&   $
��Bold"�65   $��local:RTBCommands.Bold��6G   �� 5)      -   5        $	 	butItalic��5)      $��Italic��6(   $��Italic$�69   $��local:RTBCommands.Italic��6L   �� 5*      -   5        $	 butUnderline��5*      $��	Underline��6+   $!��local:RTBCommands.Underline��6?   
���   �$��0,0,0,1q�6y   �� 5+      -   5        $	 butClear��5+      $��Clear��6'   $��local:RTBCommands.Clear��67   5,      c� 5-   
   $��0��6   $��1��6   .@�5.      �� -   5        $	 butFontSize15��5.      $��
FontSize15��6,   $"��local:RTBCommands.FontSize15��6A   �� 5/      -   5        $	 butFontSize30��5/      $��
FontSize30��6,   $"��local:RTBCommands.FontSize30��6A   50      c� 51   
   $��0��6   $��2��6   .@�52      �� -   5        $	 butcolorRed��52      $��colorRed��6*   $ ��local:RTBCommands.colorRed��6=   �� 53      -   5        $	 butcolorGreen��53      $��
colorGreen��6,   $"��local:RTBCommands.colorGreen��6A   �� 54      -   5        $	 butcolorBlue��54      $��	colorBlue��6+   $!��local:RTBCommands.colorBlue��6?   55      �� 56   
   -   5        
 ��Name$

 rtb1��56      $��1��6$   $��4��61   $��2q�6E   57      58      