   M S B A M L   `   `   `  ����   conformityManager'    !conformityManager.Pages.AdminPage   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008        MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �   N� Title$ 	AdminPage��$��Disabled=� � 	Resources   MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	MenuClose��%�   &	       &	 s     �� .��U� $ (FrameworkElement.Width)�$ 
BurgerMenu��.\�  $ 0��$	 54Q�  $ 0:0:0.2��$		 260Q��� .��U� $ (FrameworkElement.Width)�$ 
BurgerMenu��.\�  $ 0��$		 260Q�  $ 0:0:0.2��$	 54Q�
 � Triggers
 :�  :� RoutedEvent$ CheckBox.Checked�� :� 
SourceName$ 	NavToggle��.[��� #��[ :� $ CheckBox.Unchecked��$ 	NavToggle��.[��� #��[ .��� $��Disabled=����	#FFF5F4F5.+�]� $��Disabled=�$��Stretch=�.+�(  "MaterialDesignThemes.Wpf.ColorZone  $
��Left=�   Mode$ PrimaryDark=�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�$��Disabled=�$��Stretch=�.���� -    ��Name$ 
BurgerMenu��$��54��.+�� 
�������.+�� $��54��$��54��$��Right=�$��Center=�.+�d� -    d�Name$ 	NavToggle��
������� ' #MaterialDesignHamburgerToggleButton#���  $��40��$��40��$��Center=�$��Center=��� -   $��	0 20 0 20q�$��Disabled=�$��Disabled=�.@���  �� Orientation$ 
Horizontal=� � ToolTip$" Gestion de non-conformités.��.+�'  !MaterialDesignThemes.Wpf.PackIcon  
��������  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ FileDocumentBoxMultiple=�$��30��$��30��$��5 0 10 0q��� $��Non conformite��
�������   MaterialDesignTitleTextBlock#��[ $��Center=��� $ 
Horizontal=�$ Gestion des utilisateurs.��.+�  
�������$ 	UserGroup=�$��30��$��30��$��5 0 10 0q��� $��Utilisateurs��
�������#��[ $��Center=��� $ 
Horizontal=�$C =Visualisation de l'historique de la manipulation des donnée.��.+�  
�������$ TextSubject=�$��30��$��30��$��5 0 10 0q��� $	��Log��
�������#��[ $��Center=�  $	��Top=�$ PrimaryDark=�$��8q�$ Depth0=�$��Disabled=�$��54��.��� .+��� $ 
Horizontal=�.+��� $(��" Administration de non-conformité�� % !MaterialDesignSubheadingTextBlock#��[ $��Center=�$��4 0 0 0q��� $ 
Horizontal=�$��Right=�.+��� .+��� -   $��AdminFullNameTxt��$��Admin Full Name��#��[ $��Center=�$��16 0 0 0q�$��Center=��� -   $��AdminJobTxt��$��Admin Job Title�� " MaterialDesignCaptionTextBlock#��[ $��Center=�$��16 0 0 0q�$��Center=��� -    $	  MaterialDesignRaisedAccentButton#��[	 $��20,0,0,0q�$
��Auto��.���� $ 
Horizontal=�.+��� $��Deconnecter��#��[ $��Center=�$��Center=�  $ Logout=�$��2,0,0,0q�$��30��$��30��7  1MaterialDesignThemes.Wpf.Transitions.Transitioner  -     Name$ MainTransitioner�� �� SelectedIndex$ 0��!   AutoApplyTransitionOrigins .  $��Disabled=�.@�<  6MaterialDesignThemes.Wpf.Transitions.TransitionerSlide     ForwardWipe 4	  .MaterialDesignThemes.Wpf.Transitions.SlideWipe	   	  	Direction$
 Left=�   BackwardWipe 	  $
 Left=�.�� � -     �Name$ NcManagementFrame��  � NavigationUIVisibility$ Hidden=�   	  $
 Left=� 	  $
 Left=�.�� � -	   $ 
UsersFrame��$ Hidden=�   	  $
 Left=� 	  $
 Left=�.�� � -
   $ LogFrame��$ Hidden=�