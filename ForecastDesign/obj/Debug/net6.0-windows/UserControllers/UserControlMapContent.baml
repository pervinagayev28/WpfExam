   M S B A M L   `   `   `  ����I  EForecastDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ForecastDesign.UserControllersForecastDesign.UserControllers  5      :    4ForecastDesign.UserControllers.UserControlMapContent   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:ForecastDesign.UserControllers     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �� $	��200��6   $	��250��6   ��5   
   �� 5      .��5      �   � Color$  black��6    � Offset$	 0.1Q�6-   � 5      $  	AliceBlue��6   $ 1Q�61   5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� $��Comic Sans MS)�6   
�������$��Light"�6B   $��Center=�6U   $��Center=�6r   $��30(�6�   ��6�   �� *weather.city.name+'  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Location=�6&   
���  ��$��0,0,0,5q�6G   $��Bottom=�6X   $��Center=�6s   $��Center=�6�      	IconStyle#���   6�   5      �� 5   
   $��80��6   $	��200��6O   ��6   �� *!weather.list[0].weather[0].icon+6O   �� 5   
   $��Center=�6   $ 
Horizontal=�62   .+�5      �� $��Center=�6   $��40(�6^   $
��Bold"�6l   
���������63   �� *weather.list[0].main.temp+6~     5      $��Center=�6&   $��40��6c   
�������$��40��6�    6A   �� *weather.kindTemp+6�   5      �� 5   
   $��Center=�6   $ 
Horizontal=�62   $��0,5,0,0q�6K   .+�5      �� $��Center=�6   $��Rain-��63   
�������$��30(�6T   �� 5      $��Center=�6   
�������$��30(�6x   ��63   �� *weather.list[0].main.humidity+6x   5       5!      5"      