   M S B A M L   `   `   `  ����I  EForecastDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ForecastDesign.Views.ViewPagesForecastDesign.Views.ViewPages  5      O,clr-namespace:ForecastDesign.UserControllersForecastDesign.UserControllers  5      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5
      <    6ForecastDesign.Views.ViewPages.ViewSearchLocationOnMap   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a@material1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      8local,clr-namespace:ForecastDesign.Views.ViewPages  5      ADesignedButton,clr-namespace:ForecastDesign.UserControllers  5      \mapRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF  5
      -   5        $
��page��5        N� 
Background
  ����  N� Title$ ViewSearchLocationOnMap��5      .��5      � 
������  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 	70,70,0,0��6      BorderBackround#���   6*   �� 5   
   $��1��6   $ 	0,0,70,70��6   #���   67   � 5   
    � ColumnDefinitions 5      �� 5      $
��0.5* �6#   �� 5      $��* �6#   �� 5      $
��0.6* �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ;   5ForecastDesign.UserControllers.UserControlButtonStyle     IconKind$
 Home��6�   
����� �   CommandParam 6<   ��  �� ElementName$
 page��	   command	 6g   �� *GoBackCommand+6�   5       �� 5!      $��Center=�6   $��1��68   $ 
Horizontal=�6H   .+�5"      � $	��300��6   $��0,0,10,0q�6#   .+�5#      �� -   5        $��border��5#        Border_Style#���  6+   �� 5$      -   5        $��lb��5$        Label_Style#���  6&   �� 5%      -   5        $��textbox��5%   4     TextboxStyle#���  6C   5&        5'      $��0q�5)   <   $ search��6G   	 5'   9   �� *SearchCommmand+ 5(   <   �� $
 page��5)   G   5*      �� 5+      $��Right=�6   $��2��65   $ 
Horizontal=�6E   .+�5,        
����  �$ Earth��5.   (   	 5,   8   �� *EarthModeCommmand+ 5-   $   �� $
 page��5.   (     50      
�������$ 
MapOutline��53   /   	 51      �� *AerialModeCommmand+ 52   $   �� $
 page��53   /     55      $
 Tree��68   
��� � �	 56   $   �� *AerialWithLabelsModeCommmand+ 57   $   �� $
 page��58   $   5:      5;      '  !Microsoft.Maps.MapControl.WPF.Map  5<   
   -   5        $	��map��5<      +  %Microsoft.Maps.MapControl.WPF.MapCore
   Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$

 road 6   $	��500��6*   $	��900��67   $��1��6v      CredentialsProvider 6C   �� *CredentialProvider+5>      5?      5@      