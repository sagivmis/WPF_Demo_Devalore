   M S B A M L   `   `   `  ����K  GWPFExhangeApiApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFExhangeApiAppWPFExhangeApiApp  5   	   !    WPFExhangeApiApp.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPFExhangeApiApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ title��5      $��1��6$   $��1��61   .+�5      �� $��C# WPF Assignment��6   $��32(�61   $
��Bold"�6?   5      �� 5   
   -   5        $
 form��5      $��2��6#   $��1��60   $��0,30,0,0q�6@   .+�5      �� -   5         ��Name$ coinComboBox��5      $	��200��6-   $��30��69   ��5      �� 5      .R�5       �� -   5        $��18(�5    a   ��6#   �� *symbol+ d� 	IsChecked 6>   �� *check_status+6�   5!      5#      �� 5%      -   5        $��SEARCH��5%      $��
50,20,50,0q�6&   6:   5&      �� 5'   
   -   5        $ table��5'   .    �� Orientation$ 
Horizontal=�6   $��3��6=   $��1��6J   .+�5(      �� -   5         ��Name$ informationList��5(      $��0,20,0,0q�6/   $	��200��6A   �� 5)      -   5        $ rateList��5)      $��0,20,0,0q�6(   $	��200��6:   5*      5+      5.      