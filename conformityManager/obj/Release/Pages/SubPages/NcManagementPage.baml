   M S B A M L   `   `   `  ����   conformityManager.    (conformityManager.Pages.NcManagementPage   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008        MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �   N� Title$ UserPage��$��Disabled=� � 	Resources   MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	MenuClose��%�   &	       &	 s     �� .��U� $ (FrameworkElement.Width)�$ 
BurgerMenu��.\�  $ 0��$	 54Q�  $ 0:0:0.2��$		 260Q��� .��U� $ (FrameworkElement.Width)�$ 
BurgerMenu��.\�  $ 0��$		 260Q�  $ 0:0:0.2��$	 54Q�.��� $��Disabled=����	#FFF5F4F5.+�)  #MaterialDesignThemes.Wpf.DialogHost  -   
  Name$
 NewFormDialog��   IsOpen .  $��Stretch=�$��Stretch=�   DialogContent  � -     �Name$ NcFileFormFrame��  � NavigationUIVisibility$ Hidden=�.��  -   $
 SecondDialog�� .  $��Stretch=�$��Stretch=�  � -   $ SecondFrame��$ Hidden=�.��  -   $
 DeleateDialog�� .  $��Stretch=�$��Stretch=� �� $��10q�.+�'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ AlertCircleOutline=�$��80��$��80��$��Center=� J� Opacity$	 0.5Q�$��0,0,0,10q��� $+��%Êtes-vous sure de vouloir supprimer?��$��
20,0,20,20q�$	 0.7Q� % !MaterialDesignSubheadingTextBlock#��[ $��Center=�� .+��� -   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=� # MaterialDesignRaisedLightButton#��[    CloseDialogCommand#��Z $	��100��
���\\��
���\\��
������� � ToolTip$5 /Confirmer la suppression de la non-conformité.��$
��Left=�$��Center=�.��	Confirmer�� #��[ $ Depth0=�#��Z $	��100��
�������
�������
�������$3 -Annuler la suppression de la non-conformité.��$��Right=�$��Center=�.��	Annuler.��]� $��	0,30,0,40q�$��Disabled=�$��Stretch=�.+�]� $	��Top=�.+�#  MaterialDesignThemes.Wpf.Card  $��Right=�$ Depth2=�$��Stretch=�$��0,0,40,0q�.����  �� Orientation$ 
Horizontal=�$��0q�.+�	� -   $, &Liste des non-conformité de qualité.��   MaterialDesignTabRadioButton#��[ $��4q� d� 	IsChecked$
 TrueY�$��	Qualités��	� -   $$ Liste des non-conformité HSE.��#��[ $��4q�$ FalseY�$	��HSE���� $
��Left=�$ 
Horizontal=�$��4q�.+��� -	    $  MaterialDesignRaisedAccentButton#��[ $1 +Cree une nouvelle affaire de non conformite��$��6,0,0,0q�$	��4,2q�.���� $ 
Horizontal=�.+��� $��Nouvelle non conformité��$��Center=�  $ CreateNewFolderOutline=�$��2,0,0,0q�$��30��$��30���� -
    	 MaterialDesignRaisedButton#��[	 $  Imprimer la liste visible.��$��6,0,0,0q�$	��4,2q�.���� $ 
Horizontal=�.+��� $��Imprimer��$��Center=�  $ Printer=�$��2,0,0,0q�$��30��$��30��  $��Stretch=�$��
10,0,10,10q�.��7  1MaterialDesignThemes.Wpf.Transitions.Transitioner  -     Name$ MainTransitioner�� �� SelectedIndex$ 0��!   AutoApplyTransitionOrigins .  $��Disabled=�.@�<	  6MaterialDesignThemes.Wpf.Transitions.TransitionerSlide	   	  ForwardWipe 4
  .MaterialDesignThemes.Wpf.Transitions.SlideWipe
   
  	Direction$
 Left=� 	  BackwardWipe 
  $
 Left=�.�� � -   $ QualityFrame��$ Hidden=�	   
  $ Right=� 
  $ Right=�.�� � -   $ HseFrame��$ Hidden=�