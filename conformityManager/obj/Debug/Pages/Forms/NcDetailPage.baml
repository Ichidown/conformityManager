   M S B A M L   `   `   `  ����  conformityManager0    *conformityManager.Pages.Other.NcDetailPage   5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5         MaterialDesignBody#���   5      $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5	   
    N� Title$ UserPage��5      $��Disabled=�6   $	��500��6L   $	��600��6X   .��5      ]� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $	��Top=�6#   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�68      Mode$ PrimaryLight=�5      $��8q�5      .��5      ]� .+�5      �� -   5        $��caseTitleLabel��5      $��Center=�62   $
��Left=�6M   $��	16 0 16 0q�5      $
��Left=�6&   $*��$Titre de l'affaire de non conformite��6A   �� 5       # MaterialDesignRaisedLightButton#��[ 6   $��Right=�6R    �� 	IsDefault . $2��,materialDesign:DialogHost.CloseDialogCommand��5   &   
���  ��
���  ��
�������$
��Auto��5   K   $��Center=�6Y   $��Right=�6t   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   )   ��6   9system&clr-namespace:System;assembly=mscorlib     6)   True��5       .��5!   /   X5#      5$      5%        5'   
   $��Bottom=�6#   $ Depth3=�6;   $ PrimaryLight=�5(      $��8q�5)      $��Stretch=�6   
�������$��Stretch=�6F   $��Stretch=�6k   ��. .��5*      �� -   5        $��FixBtn��5-   0   $��0q�5*       $  MaterialDesignRaisedAccentButton#��[ 5+      $	��100��5,       � ToolTip$ Lever la non conformite.��5-      .��5.      �� 	 �� Orientation$	 
Horizontal=�6   .+�5/      �� $��Lever��6    $��Center=�6-   '  !MaterialDesignThemes.Wpf.PackIcon  50      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind$
 WrenchOutline=�6.   $��4q�6C   51      52      53      � 55   
    � ColumnDefinitions 56      �� 57      $��3* �6#   �� 58      $��* �6#   .+�5;        $��Bottom=�6'   $ Depth1=�6?   $��Stretch=�6p   .��5<      �� $��Disabled=�6   $
��Auto=�6H   .��5=      �� $��10q�6!   $��0��6-   .+�5?      �  5@      �� 5A   "   $��* �63   �� 5B   "   $��* �63   .+�5D      �� -   5        $��userFullNameTxt��5D   "   $��0��6:    �� 
IsReadOnly . )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Auteur :��5E      $��Auteur��6E    % !MaterialDesignFloatingHintTextBox#��[ 5F      $��10,10.2,10,9.6q�6V   �� 5G      -   5        $��structureTxt��5G   "   $��1��66    . $ Structure :��5H      $��Nom de structure 01��6H   #��[ 5I      $��10,10.2,10,9.6q�6V   5J      �� 5K      -   5        $��DescriptionTxt��5K       . $����Detail de affaire de non conformite Detail de affaire de non conformiteDetail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite��6@   $ Description :��5L       �� TextWrapping$
 Wrap=�6>   #��[ 5M      $��10q�6J   � 5O       5P      �� 5Q   "   $��* �63   �� 5R   "   $��* �63    � RowDefinitions 5T      �� 5U   "   $��* �60   �� 5V   "   $��* �60   .+�5Y      �� -   5        $��	n_planTxt��5Y   &   $��0��68   $��0��6E   $��1561651 65165 51165��6U   $ Numero Plan :��5Z       . #��[ 5[      $��10,10,10,9.8q�6J   �� 5]      -   5        $��partial_setTxt��5]   &   $��0��6<   $��1��6I   $��sdfsd-sdfsdf-sdfsdf-sdf��6Y   $ Ensemble partiel :��5^       . #��[ 5_      $��10,10,10,9.8q�6J   �� 5e      -   5        $��	sourceTxt��5e   &   $��1��67   $��0��6D    . $ Source :��5f      #��[ 5g      $��10,10.2,10,9.6q�6V   �� 5h      -	   5        $��creationDateTxt��5h   &   $��1��6=   $��1��6J    . $ Date de creation :��5i      $��
00-00-0000��6O   #��[ 5j      $��10,10.2,10,9.6q�6V   5l      5n      5p      5r      �� 5t      $��1��6   $��Disabled=�6+   $
��Auto=�6T   .��5u      �� -
   5        $��PicContainer��5u      $��Right=�61   5v      5z      5}      5�      