   M S B A M L   `   `   `  ����I  EForecastDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ForecastDesign.Views.ViewPagesForecastDesign.Views.ViewPages  5      O,clr-namespace:ForecastDesign.UserControllersForecastDesign.UserControllers  6�   O,clr-namespace:ForecastDesign.UserControllersForecastDesign.UserControllers  5      5    /ForecastDesign.Views.ViewPages.ViewRegistration   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:ForecastDesign.Views.ViewPages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6B   6btn,clr-namespace:ForecastDesign.UserControllers  6�   <	UCTextbox,clr-namespace:ForecastDesign.UserControllers  5      -   5        $
��page��5	        N� Title$  ViewRegistration��5      .��5      ��    BorderBackround#���   6    �� CornerRadius$ 30��69   ._�5   
   � 
������  � RowDefinitions 5      �� 5      $
��0.2* �6    �� 5      $��* �6    .+�5      <   6ForecastDesign.UserControllers.UserControlViewInButton  $
��Left=�6y      IconKind$ 	ArrowBack��6�      CommandParam 6*   ��  �� ElementName$
 page��   command 6U   �� *GoBackcommand+6�     5      $��Right=�6v   $ Close��6�    6*   �� $
 page�� 6U   �� *Closecommand+6�   �� 5      -   5         ��Name$ 
stackpanel��5      $��1��6-   
������ $��Center=�6S   .+�5      � $��Center=�6   
������ .+�5      7   1ForecastDesign.UserControllers.UserControlTextBox     	LbContent$ Gmail��63   	   Text	 6E   �� $ gmail��
 �� Path$

 Text��� 5      -   5         ��Name$ gmail��5        ViewLogInTextBoxStyle#���  6-   5      �� 5      -   5        $	��btn��5        ViewInButtonStyle#���  6v   $��	Send Code��6�   $��20q�6�   ��6$   �� $
 page����6R   �� *SendCodeCommand+6�   �� 5      $y�Hidden=�6   $��40��6,   $	��300��68   $��	errrorere��6D   $��20(�6X   $��Center=�6f   
���  ��6�   5      5      5      5       