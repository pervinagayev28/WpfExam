   M S B A M L   `   `   `  ����I  EForecastDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ForecastDesign.Views.ViewPagesForecastDesign.Views.ViewPages  5      O,clr-namespace:ForecastDesign.UserControllersForecastDesign.UserControllers  5      O,clr-namespace:ForecastDesign.UserControllersForecastDesign.UserControllers  5	      .    (ForecastDesign.Views.ViewPages.ViewLogIn   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:ForecastDesign.Views.ViewPages     5      <btn,clr-namespace:ForecastDesign.UserControllers     5      B	UCTextbox,clr-namespace:ForecastDesign.UserControllers     5	      -   5        $
��page��5        N� Title$  	ViewLogIn��5      .��5      ��    BorderBackround#���   6    �� CornerRadius$ 30��69   ._�5   
   � 
������  � RowDefinitions 5      �� 5      $
��0.2* �6    �� 5      $��* �6    .+�5      <   6ForecastDesign.UserControllers.UserControlViewInButton  $
��Left=�6y      IconKind$ 	ArrowBack��6�      CommandParam 6*   ��  �� ElementName$
 page��   command 6U   �� *GoBackcommand+6�     5      $��Right=�6v   $ Close��6�    6*   �� $
 page�� 6U   �� *Closecommand+6�   �� 5      $��1��6   
������ $��Center=�6?   .+�5      � $��Center=�6   
������ .+�5      7   1ForecastDesign.UserControllers.UserControlTextBox     	LbContent$ Gmail��64      Text 6F   �� $ gmail��	 �� Path$
	 Text��� 5      -   5        
 ��Name$
 gmail��5      $��Center=�6-     ViewLogInTextBoxStyle#���  6Q   5      � 5      $��20q�6   $��Center=�6#   
������ .+�5        $ Password��63    6H   �� $ password��$
	 Text��� 5      -   5        $
 password��5      $��Center=�60   $	��5,0q�6T   #���  6b   5      �� 5      -   5        $	��btn��5        ViewInButtonStyle#���  5!      $��Sign in��6E   $��10q�6W   ��5   $   �� *SignIncommand+��5       �� $
 page��5!   W   5#      5$      5%      5&      