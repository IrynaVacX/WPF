   M S B A M L   `   `   `  ����P  LWpfApp4-1_ContextMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApp4_1_ContextMenuWpfApp4_1_ContextMenu  5   	   &     WpfApp4_1_ContextMenu.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfApp4_1_ContextMenu     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)   .��5	      � 
���iii�$��0,0,0,-6q�6     � RowDefinitions 5
   
   �� 5      $	��37* �6   �� 5      $��7* �6   .+�5   
   r� -   5        $��mediaElement1��5      $��Center=�6,   $	��293��6I   $	��Top=�6V   $	��556��6n   $��0,10,0,0q�6z    � ContextMenu 5      �� 5      .@�5      m� -   5        $
��Open��5      6H   m� 5      -   5        $
��Play��5      6H   m� 5      -   5        $
��Stop��5      6E   m� 5      -   5        $��Pause��5      6J   5      5      �� 5   
   -   5         ��Name$ 
buttonOpen��5      $
��Open��6%   $
��Left=�64   $��40��6O   $��20,0,0,0q�6[   $��Center=�6m   $	��126��6�   $��1��6�   �� 5   
   -   5        $ buttonPause��5      $	��| |��6&   $
��Left=�64   $��30��6O   $��	550,0,0,0q�6[   $��Center=�6n   $��30��6�   $
��Bold"�6�   $��1��6�    J� RenderTransformOrigin$ 1.039,0.671&�6�   �� 5   
   -   5        $ button_��5      $	��█��6"   $
��Left=�6.   $��30��6I   $��	515,0,0,0q�6U   $��Center=�6h   $��30��6�   $��1��6�   �� 5   
   -	   5        $ 
buttonPlay��5      $	��▶��6%   $
��Left=�61   $��30��6L   $��	480,0,0,0q�6X   $��Center=�6k   $��30��6�   $��1��6�   �� 5   
   -
   5         ��Name$ slider1��5      $��Center=�6"   $��55��6?   $��	0,337,0,0q�6K   $	��Top=�6^   $	��560��6v   $��2��6�   5      5      