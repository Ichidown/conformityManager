   M S B A M L   `   `   `  ����  conformityManager'    !conformityManager.Pages.AdminPage   5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5         MaterialDesignBody#���   5      $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5	   
    N� Title$ 	AdminPage��5      $��Disabled=�6    � 	Resources 5        MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	MenuClose��%�  &	       &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ 
BurgerMenu��6a   .\�5        $ 0��6'   $	 54Q�63     5      $ 0:0:0.2��6'   $		 260Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ 
BurgerMenu��6a   .\�5        $ 0��6'   $		 260Q�63     5      $ 0:0:0.2��6'   $	 54Q�69   5      5      5       
 � Triggers
 5#      :� 5$   
    :� RoutedEvent$ CheckBox.Checked��6    :� 
SourceName$ 	NavToggle��66   .[�5%      �� #��[ 6   5&      :� 5'   
   $ CheckBox.Unchecked��6   $ 	NavToggle��68   .[�5(      �� #��[ 6   5)      .��5-      � $��Disabled=�6   ���	#FFF5F4F5.+�5.   
   ]� $��Disabled=�6   $��Stretch=�6H   .+�5/      (  "MaterialDesignThemes.Wpf.ColorZone  $
��Left=�6'      Mode$ PrimaryDark=�6=   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�6P   $��Disabled=�6�   $��Stretch=�6�   .��50      �� -   5         ��Name$ 
BurgerMenu��50      $��54��61   .+�51      � 
�������.+�52      � $��54��6   $��54��6+   $��Right=�66   $��Center=�6R   .+�53      d� -   5         d�Name$ 	NavToggle��53   +   
������� ' #MaterialDesignHamburgerToggleButton#���  6T   $��40��6�   $��40��6�   $��Center=�6�   $��Center=�6�   54      55      �� 57      -   5        $��	0 20 0 20q�57      $��Disabled=�6U   $��Disabled=�6�   .@�59      ��  �� Orientation$ 
Horizontal=�6%    � ToolTip$" Gestion de non-conformités.��6>   .+�5:      '  !MaterialDesignThemes.Wpf.PackIcon  
��������  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ FileDocumentBoxMultiple=�6I   $��30��6h   $��30��6t   $��5 0 10 0q�6   �� 5;      $��Non conformite��6(   
�������   MaterialDesignTitleTextBlock#��[ 6Q   $��Center=�6�   5<      �� 5>      $ 
Horizontal=�6%   $ Gestion des utilisateurs.��6>   .+�5?        
�������$ 	UserGroup=�6I   $��30��6Z   $��30��6f   $��5 0 10 0q�6q   �� 5@      $��Utilisateurs��6(   
�������#��[ 6O   $��Center=�6�   5A      �� 5C      $ 
Horizontal=�6%   $C =Visualisation de l'historique de la manipulation des donnée.��6>   .+�5D        
�������$ TextSubject=�6I   $��30��6\   $��30��6h   $��5 0 10 0q�6s   �� 5E      $	��Log��6(   
�������#��[ 6F   $��Center=�6|   5F      5H      5J      5K        5M      $	��Top=�6'   $ PrimaryDark=�6<   $��8q�6O   $ Depth0=�6[   $��Disabled=�6�   $��54��6�   .��5N      � .+�5O      �� $ 
Horizontal=�6!   .+�5P      �� $(��" Administration de non-conformité��6$    % !MaterialDesignSubheadingTextBlock#��[ 6M   $��Center=�6�   $��4 0 0 0q�6�   5Q      �� 5R      $ 
Horizontal=�6!   $��Right=�6:   .+�5S      �� .+�5T      �� -   5        $��AdminFullNameTxt��5T   (   $��Admin Full Name��6@   #��[ 6W   $��Center=�6�   $��16 0 0 0q�6�   $��Center=�6�   �� 5U      -   5        $��AdminJobTxt��5U   (   $��Admin Job Title��6;    " MaterialDesignCaptionTextBlock#��[ 6R   $��Center=�6�   $��16 0 0 0q�6�   $��Center=�6�   5V      �� 5W      -   5         $	  MaterialDesignRaisedAccentButton#��[	 5X   %   $��20,0,0,0q�6_   $
��Auto��6q   .��5Y      �� $ 
Horizontal=�6)   .+�5Z   "   �� $��Deconnecter��6,   #��[ 6?   $��Center=�6w   $��Center=�6�     5[   "   $ Logout=�6:   $��2,0,0,0q�6H   $��30��6Y   $��30��6d   5\      5]      5^      5_      5`      7  1MaterialDesignThemes.Wpf.Transitions.Transitioner  5d      -   5          Name$ MainTransitioner��5d   +    �� SelectedIndex$ 0��6E   !   AutoApplyTransitionOrigins .  $��Disabled=�6z   .@�5g      <  6MaterialDesignThemes.Wpf.Transitions.TransitionerSlide     ForwardWipe 5h      4	  .MaterialDesignThemes.Wpf.Transitions.SlideWipe	  5i       	  	Direction$
 Left=�63      BackwardWipe 5k      	  5l      $
 Left=�63   .��5o       � -   5          �Name$ NcManagementFrame��5o         � NavigationUIVisibility$ Hidden=�6;   5q        5t       5u      	  5v      $
 Left=�63    5x      	  5y      $
 Left=�63   .��5|       � -	   5        $ 
UsersFrame��5|      $ Hidden=�60   5~        5�       5�      	  5�      $
 Left=�63    5�      	  5�      $
 Left=�63   .��5�       � -
   5        $ LogFrame��5�      $ Hidden=�6.   5�      5�      5�      5�      5�      