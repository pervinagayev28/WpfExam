   M S B A M L   `   `   `  ����I  EForecastDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ForecastDesign.Views.ViewPagesForecastDesign.Views.ViewPages  5      O,clr-namespace:ForecastDesign.UserControllersForecastDesign.UserControllers  5      .    (ForecastDesign.Views.ViewPages.ViewEntry   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:ForecastDesign.Views.ViewPages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;WeekDays,clr-namespace:ForecastDesign.UserControllers  5      -   5          N�Name$  ViewEntryPage��5       N� 
Background
 ����  N� Title$ 	ViewEntry��5      .��5      � 
������ .+�5   
   ��    BorderBackround#���   6    �� CornerRadius$ 30��6<   ._�5      � 
������ $��	-9,5,9,-5q�6,    � ColumnDefinitions 5      �� 5      $
��0.3* �6'   �� 5      $��* �6'   .+�5      � $��0��6   $��10q�6'    � RowDefinitions 5      �� 5      $
��0.3* �6(   �� 5      $
��0.4* �6(   �� 5      $
��0.2* �6(   �� 5      $
��0.2* �6(   �� 5      $
��0.2* �6(   �� 5      $
��0.2* �6(   �� 5      $
��0.5* �6(   .+�5"      � $��Center=�6   $��0��6g   $��0,5,0,0q�6t   ��66   ��  �� ElementName$ border�� �� Path$ Width�.+�5#      �� -   5         ��Name$ border��5#   "     borderStyle#���  62   �� 5$      -   5        $��lb��5$   1   $��search��6      
LabelStyle#���  6;   �� 5%      -   5        	 ��Name$	 textbox_search��5%   #     TextBoxStyle#���  6;   �� 5&      -   5        $��
btn_search��5&   "     SearchButtonStyle#���  6�   ��64   �� *SearchCommand+��6V   �� $ textbox_search��$
 Text�.��5'      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��67   $��30��6C   
   Kind$
 Search=�6N   ��6\   �� $ lb��$ 
Foreground�5(      5)      �� 5+      $ 50��6   $��1��6/   $	��120��6<   $	��150��6I   ��5,      �� 5-      -   5        weatherimage�� �� ImageSource 5-   ?   �� *!weather.list[0].weather[0].icon+5/      �� 50      $��2��6!   $��Center=�6.   $��Center=�6I    �� Orientation$ 
Horizontal=�6f   .+�51      �� $��Center=�6$   $��40(�6j   $
��Bold"�6x   
���������6?   �� *weather.list[0].main.temp+6�     52      $��Center=�62   $��40��6o   
�������$��40��6�   
 6M   �� *weather.kindTemp+6�   53      �� 54      $��3��6!   $��Center=�6.   $��Center=�6I   $ 
Horizontal=�6f   .+�55      �� $��17(�6C   $
��Bold"�6Q   
���������6$   �� *weather.Today+6c   �� 56      $��10,0,0,0q�6A   $��17(�6S   
�������$
��Bold"�6t   ��6$   �� *CurrentTime+6t   57      �� 58      $��4��6!   $��Center=�6.   $��Center=�6I   $ 
Horizontal=�6f   .+�59        $
 Cloud=�62   $��Center=�6?   $��20��6Z   $��20��6f   
����  �6q   �� 5:      $	��100��6\   $��10,0,0,0q�6h   
�������$��15(�6�   ��6$   �� *(&weather.list[0].weather[0].description+6�   5;      �� 5<      $��5��6!   $��Center=�6/   $ 
Horizontal=�6L   .+�5=        $
 
RainChance=�62   $��0,0,10,0q�6D   $��Center=�6V   $��20��6q   $��20��6}   
����  �6�   �� 5>      $ 
Horizontal=�6%   $	��100��6?   $��20��6K   .+�5?      �� $��Center=�6(   $��Rain-��6C   
�������$��15(�6d   �� 5@      $��Center=�6(   
�������$��15(�6�   ��6C   �� *weather.list[0].main.humidity+6�   5A      5B      �� 5D      $��6��6   $	��150��6*   $	��200��67   $	 100��6D   $��Center=�6W   ��5E      �� 5F       6)   �� *weather.ImageSourceCity+5H      5I      � 5J      $��1��6    5K      �� 5L      $��0.25* �6(   �� 5M      $
��0.4* �6(   �� 5N      $
��0.9* �6(   .+�5Q      � $��1��6    5R      �� 5S      $
��0.5* �6/   �� 5T      $��* �6/   �� 5U      $
��0.5* �6/   .+�5W      �� -   5         ��Name$ 
stackpanel��5W   %   $��Center=�69   $	��100��6T   $��30,0,0,0q�6a   $ 
Horizontal=�6s   .+�5X      �� -   5         ��Name$ F��5X   %   
���   �$��F��5Y   2     ButtonStyle#���  6?   ��5X   0   �� $ 
stackpanel����6d   �� *FahrenHeitCommand+5Y   ?   �� 5Z      -	   5        $ C��5[      
�������
���   �$��C��5\      #���  6*   ��5Z   %   �� $ 
stackpanel����6Y   �� *CelciCommand+5\   *   5]      �� 5^      $��2��6%   $	��130��65   $��Center=�6B   $��80��6]   $��Right=�6j   $ 
Horizontal=�6�   .+�5_      �� 
�������$��0,0,10,0q�6�   
������ #���  6�   ��68   �� *
MapCommand+��6W   �� $ ViewEntryPage��.��5`   "     
���   �$
 LocationMultiple=�6M   $��50��6e   $��50��6q   5a      �� 5b      -
   5        $��	btn_close��5c   !   
���   �$��0,0,10,0q�5e   /   #���  6A   ��5d      �� *ClosedCommand+��6<   �� $ ViewEntryPage��.��5f   "     
�������$
 CloseCircle=�6Q   $��50��6d   $��50��6p   5g      5i      �� 5j      $��Bottom=�6'   $��1��6B   $��Center=�6S   .+�5k      �� $ 
Horizontal=�6)   .+�5l   "   ��   ClearButtonStyle#���  6�   ��6)   �� *ClearHistoryCommand+��6Q   �� $ ViewEntryPage��6�   �� 5m   "   -   5        $��combobox��5n   %   $��30��5p   "   
�������$	��250��5r   "   
���   �$��0 0 0 2q�5t   "   ��5o   !   �� *user.Histories+��5u   &   �� 5w   *   .R�5x   .   ��  �� TextAlignment$ Center=�6R   $��Center=�6i   $
��Bold"�6�   $��15(�6�   ��68   �� *
location+6�   5y   +   5{   #   5|      �� 5~      $ 
Horizontal=�6)   $��Center=�6B   .+�5   "   �� $��Comic Sans MS)�6(   $��Light"�6C   $��Center=�6V   $��Center=�6s   $��30(�6�   ��6�   �� *weather.city.name+  5�   "   $
 Location=�6:   
���  ��$��0,0,0,5q�6[   $��Bottom=�6l   $��Center=�6�   $��Center=�6�     	IconStyle#���  6�   5�      5�      5�      �� 5�      $��0q�5�      $��Disabled=�6,   $��Center=�5�      $��Center=�5�      $��0,0,0,0q�65   
������ $��1��5�   1     ListViewStyle#���  5�      ��5�      �� *weather.list+��5�      �� 5�      .R�5�   "   �  � Orientation$ 
Horizontal=�6,   5�      ��5�      �� 5�      .R�5�   "   8   2ForecastDesign.UserControllers.UserControlWeekDays  5�      5�      � 5�      $��3��6   $��0,0,0,20q�6(   $��Center=�6:    5�      �� 5�      �� 5�      .+�5�      �� $��30,0,0,0q�6%   $��0��67   $ 
Horizontal=�6D   .+�5�      ��  	 BorderStyle#��� 	 6%   $��0,0,10,0q�6K   $	��200��6^   $	��250��6k   ._�5�   "   �� .+�5�   &   �� $��UI temprature��6,   $��20(�6D   $
��Bold"�6R   $��Center=�6d   �� 5�   &    
 Border_Style#��� 
 6-   $	��200��6T   $ 10��6`   $��0,20,0,0q�6r    �� Padding$ 	10,0,10,0q�6�   $��30��6�   
�������$��2q�6�   
������ ._�5�   *   ��   SliderStyle#���  6l    � Value 61   �� $ HumiditlySlider��$ Value�6l   5�   '   �� 5�   &   $	��200��6-   $ 10��69   $��0,20,0,0q�6K   $ 	10,0,10,0q�6]   $��30��6q   
�������$��2q�6�   
������ ._�5�   *   ��  � Maximum$ 100000Q�61   #���  6}    �� IsMoveToPointEnabled$ False��6�   $��False��6�    6B   �� $ VisibilitySlider��$ Value�6�   5�   '   �� 5�   &   $	��200��6-   $ 10��69   $��0,20,0,0q�6K   $ 	10,0,10,0q�6]   $��30��6q   
�������$��2q�6�   
������ ._�5�   *   �� $
 1100Q�61   #���  6z    6@   �� $ SeaLevelSlider��$ Value�6z   5�   '   5�   #   5�      �� 5�      #��� 	 6%   $��0,0,10,0q�6K   $	��200��6]   $	��250��6j   ._�5�   "   �� .+�5�   &   �� $��wind Status��6-   $��20(�6C   $
��Bold"�6Q   $��Center=�6c   �� 5�   &   $��0,20,0,0q�61   $��Center=�6C   $ 
Horizontal=�6a   .+�5�   *   �� $��30(�60   ��6>   �� *weather.list[0].wind.speed+�� 5�   *   $��Bottom=�60   $��10(�6K   $
��km/h��6Y   5�   '   �� 5�   &   $��50��6j   $	��100��6v   $��0,30,0,0q�6�   ��6,   �� $ weatherimage��$ ImageSource�6�   5�   #   5�      �� 5�      #��� 	 6%   $��0,0,10,0q�6K   $	��200��6]   $	��250��6j   ._�5�   "   �� .+�5�   &   �� $��20(�6,   $��Sunset Sunrise��6:   $��Center=�6S   $
��Bold"�6x   �� 5�   &   $��0,20,0,0q�61   $ 
Horizontal=�6C   $��Center=�6\   .+�5�   *     $
 Sunrise=�6B   $��50��6R   $��50��6^   �� 5�   *   $��25(�60   ��6>   �� *weather.SunRise+5�   '   �� 5�   &   $��0,20,0,0q�61   $ 
Horizontal=�6C   $��Center=�6\   .+�5�   *     $
 WeatherSunset=�6B   $��50��6X   $��50��6d   �� 5�   *   $��25(�60   ��6>   �� *weather.SunSet+5�   '   5�   #   5�      5�      �� 5�      $��1��6%   $ 
Horizontal=�62   $��30,0,0,0q�6K   .+�5�      �� #��� 	 6%   $��0,0,10,0q�6K   $	��200��6]   $	��250��6j   ._�5�   "   �� .+�5�   &   �� $��	Humiditly��6,   $��Center=�6@   $��25(�6d   $
��Bold"�6r   �� 5�   &   $	��200��6-   $ 10��69   $��0,20,5,0q�6K   $ 	10,0,10,0q�6]   $��30��6q   
�������$��2q�6�   
������ ._�5�   *   �� -   5         ��Name$ HumiditlySlider��5�   1   #���  6{    6J   �� *weather.list[0].main.humidity+6{   5�   '   �� 5�   &   $��Center=�61   $ 
Horizontal=�6O   .+�5�   *   �� $��30(�6b   $��0,10,0,0q�6p   ��60   �� *weather.list[0].main.humidity+6p   �� 5�   *   $��%��60   $��20(�6<   $��Bottom=�6J   $��0,20,0,0q�6l   5�   '   �� 5�   &   $��Normal��6,   $��Center=�6=   $��20(�6Z   $��0,10,0,0q�6i   5�   #   5�      �� 5�      #��� 	 6%   $��0,0,10,0q�6K   $	��200��6]   $	��250��6j   ._�5�   "   �� .+�5�   &   �� $��
Visibility��6,   $��Center=�6A   $��25(�6e   $
��Bold"�6s   �� 5�   &   $	��200��6-   $ 10��69   $��0,20,5,0q�6K   $ 	10,0,10,0q�6]   $��30��6q   
�������$��2q�6�   
������ ._�5�   *   �� -   5        $ VisibilitySlider��5�   1   $ 100000Q�6y   #���  6�    6L   �� *weather.list[0].visibility+6�   5�   '   �� 5�   &   $��Center=�61   $ 
Horizontal=�6O   .+�5�   *   �� $��30(�6`   $��0,10,0,0q�6n   ��60   �� *weather.list[0].visibility+6n   �� 5�   *   $��km��60   $��20(�6=   $��Bottom=�6K   $��0,20,0,0q�6m   5�   '   �� 5�   &   $��Normal��6,   $��Center=�6=   $��20(�6Z   $��0,10,0,0q�6i   5�   #   5�      �� 5�      #��� 	 6%   $��0,0,10,0q�6K   $	��200��6]   $	��250��6j   ._�5�   "   �� .+�5�   &   �� $��	Sea Level��6,   $��Center=�6@   $��25(�6d   $
��Bold"�6r   �� 5�   &   $	��200��6-   $ 10��69   $��0,20,5,0q�6K   $ 	10,0,10,0q�6]   $��30��6q   
�������$��2q�6�   
������ ._�5�   *   �� -   5        $ SeaLevelSlider��5�   1   $
 1100Q�6I   #���  6�    6X   �� * weather.list[0].main.sea_level+6�   5�   '   �� 5�   &   $��Center=�61   $ 
Horizontal=�6O   .+�5�   *   �� $��30(�6c   $��0,10,0,0q�6q   ��60   �� * weather.list[0].main.sea_level+6q   �� 5�   *   $��SL��60   $��20(�6=   $��Bottom=�6K   $��0,20,0,0q�6m   5�   '   �� 5�   &   $��Normal��6,   $��Center=�6=   $��20(�6Z   $��0,10,0,0q�6i   5�   #   5�      5�      5�      5�      5�      5�      5     5     