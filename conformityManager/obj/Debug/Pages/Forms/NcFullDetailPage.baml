   M S B A M L   `   `   `  ����  conformityManager4    .conformityManager.Pages.Forms.NcFullDetailPage   5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5         MaterialDesignBody#���   5      $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5	   
    N� Title$ UserPage��5      $��Disabled=�6   $	��960��6L   $	��600��6X    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?�6%   %    5      .��5      ]� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $	��Top=�6#   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�68   	   Mode$	 PrimaryLight=�5      $��8q�5      .��5      ]� .+�5      �� -   5        $��caseTitleLabel��5      $��Center=�62   $
��Left=�6M   $��	16 0 16 0q�5      $
��Left=�6&   $*��$Titre de l'affaire de non conformite��6A   �� 5!       # MaterialDesignRaisedLightButton#��[ 6   $��Right=�6R   
 �� 	IsDefault
 . $2��,materialDesign:DialogHost.CloseDialogCommand��5"   &   
���  ��
���  ��
�������$
��Auto��5#   K   $��Center=�6Y   $��Right=�6t   ��5$      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5%   )   ��6   9system&clr-namespace:System;assembly=mscorlib     6)   True��5'      .��5(   /   X5*      5+      5,        5.   
   $��Bottom=�6#   $ Depth3=�6;   $��0q�6l   $	 PrimaryLight=�5/      $��Stretch=�6   
�������$��Stretch=�6N   $��Stretch=�6s   ��. .��50      � .+�51      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�53      &   MaterialDesignThemes.Wpf.Flipper  -   5        $��FinaliseFlipper��53   -     MaterialDesignCardFlipper#��[ 6D   $��Stretch=�6w   $��Stretch=�6�      FrontContent 54      �� 55      -   5        $��FinaliseFlipperFrontBtn��55   B     MaterialDesignFlatButton#��[ 56         FlipCommand#��Z 57      $��8q�58       � ToolTip$" Realiser la non conformité.��6*   $	��220��59      .��6+   
Realiser5;         BackContent 5?      ]� 5@      $��Stretch=�6(   $��Stretch=�6F   $��
10,10,10,0q�6b   $	��220��6v   .+�5A   "   �� $
��Left=�6,   $+��%Etes vous sure de vouloir continuer ?��6G   $	��Top=�6t   �� 5C   "   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5D   &   �� -   5        $��10q�5D   .   $��Right=�6T   $��Center=�6p   
����� �
�������
����� �#��[ 5F   %   .��5G   *   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Check=�6B   5H   '   �� 5J   &   $��10q�6.   $
��Left=�6:   $��Center=�6U   
����p��
�������
����p��#��Z 5L   %   #��[ 5M   %   .��5N   *     $ Close=�6B   5O   '   5P   #   5Q      5S        5V      -   5        $��ValidateFlipper��5V   -   #��[ 6D   $��Stretch=�6w   $��Stretch=�6�    5W      �� 5X      -   5        $��ValidateFlipperFrontBtn��5X   B   #��[ 5Y      #��Z 5Z      $��8q�5[      $! Valider la non conformité.��6*   $	��220��5\      .��6+   	Valider5^       5b      ]� 5c      $��Stretch=�6(   $��Stretch=�6F   $��
10,10,10,0q�6b   $	��220��6v   .+�5d   "   �� $
��Left=�6,   $+��%Etes vous sure de vouloir continuer ?��6G   $	��Top=�6t   �� 5f   "   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5g   &   �� -   5        $��10q�5g   .   $��Right=�6T   $��Center=�6p   
����� �
�������
����� �#��[ 5i   %   .��5j   *     $ Check=�6B   5k   '   �� 5m   &   $��10q�6.   $
��Left=�6:   $��Center=�6U   
����p��
�������
����p��#��Z 5o   %   #��[ 5p   %   .��5q   *     $ Close=�6B   5r   '   5s   #   5t      5v        5y      -   5        $��ResetFlipper��5y   -   #��[ 6A   $��Stretch=�6t   $��Stretch=�6�    5z      �� 5{      -	   5        #��[ 5|      #��Z 5}      $��8q�5~      $K EEffacer tous les données concernant la levée de la non conformité.��6*   $	��220��5      .��6+   Reinitialiser5�       5�      ]� 5�      $��Stretch=�6(   $��Stretch=�6F   $��
10,10,10,0q�6b   $	��220��6v   .+�5�   "   �� $
��Left=�6,   $/��)Etes vous sure de vouloir reinitialiser ?��6G   $	��Top=�6x   �� 5�   "   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5�   &   �� -
   5        $��10q�5�   .   $��Right=�6Q   $��Center=�6m   
����� �
�������
����� �#��[ 5�   %   .��5�   *     $ Check=�6B   5�   '   �� 5�   &   $��10q�6.   $
��Left=�6:   $��Center=�6U   
����p��
�������
����p��#��Z 5�   %   #��[ 5�   %   .��5�   *     $ Close=�6B   5�   '   5�   #   5�      5�      5�      �� 5�      -   5          MaterialDesignRaisedButton#��[ 5�      $  Imprimer la liste visible.��5�   %   $��5q�5�   %   $	��4,2q�60   $��Right=�6>   $��Center=�6Z   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $��Imprimer��6$   $��Center=�64     5�      $ Printer=�62   $��2,0,0,0q�6A   $��30��6R   $��30��6]   5�      5�      5�      5�      � 5�   
    � ColumnDefinitions 5�      �� 5�      $��2* �6#   �� 5�      $��2* �6#   �� 5�      $��* �6#   .+�5�      �� $��0��6   $��Disabled=�6+   $
��Auto=�6T   .��5�      �� $��10q�6   $��0��6)   .+�5�      �  5�      �� 5�      $��* �6/   �� 5�      $��* �6/   .+�5�      �� -   5        $��userFullNameTxt��5�   "   $��0��6:    �� 
IsReadOnly . )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Auteur :��5�      $��Auteur��6E    % !MaterialDesignFloatingHintTextBox#��[ 5�      $��10,10.2,10,9.6q�6V   �� 5�      -   5        $��structureTxt��5�   "   $��1��66    . $ Structure :��5�      $��Nom de structure 01��6H   #��[ 5�      $��10,10.2,10,9.6q�6V   5�      �� 5�      -   5        $��NcDescriptionTxt��5�       . $����Detail de affaire de non conformite Detail de affaire de non conformiteDetail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite��6H   $ Description :��5�       �� TextWrapping$
 Wrap=�6J   #��[ 5�      $��10q�6V   � 5�       5�      �� 5�      $��* �6/   �� 5�      $��* �6/    � RowDefinitions 5�      �� 5�      $��* �6,   �� 5�      $��* �6,   .+�5�      �� -   5        $��	n_planTxt��5�   "   $��0��64   $��0��6A   $��1561651 65165 51165��6Q   $ Numero Plan :��5�       . #��[ 5�      $��10,10,10,9.8q�6J   �� 5�      -   5        $��partial_setTxt��5�   "   $��0��68   $��1��6E   $��sdfsd-sdfsdf-sdfsdf-sdf��6U   $ Ensemble partiel :��5�       . #��[ 5�      $��10,10,10,9.8q�6J   �� 5�      -   5        $��	sourceTxt��5�   "   $��1��63   $��0��6@    . $ Source :��5�      $��Interne��6E   #��[ 5�      $��10,10.2,10,9.6q�6V   �� 5�      -   5        $��creationDateTxt��5�   "   $��1��69   $��1��6F    . $ Date de creation :��5�      $��
00-00-0000��6O   #��[ 5�      $��10,10.2,10,9.6q�6V   5�      5�      5�      �� 5�      $��1��6   $��Disabled=�6+   $
��Auto=�6T   .��5�      �� .+�5�      �� -   5        $��CauseTxt��5�       . $|��vDetail de affaire de non conformite Detail de affaire de non conformiteDetail de affaire de non conformite Detail mite��6@   $ Cause :��5�      $
 Wrap=�6D   #��[ 5�      $��10q�6V   �� 5�      -   5        $��ActionDescriptionTxt��5�       . $|��vDetail de affaire de non conformite Detail de affaire de non conformiteDetail de affaire de non conformite Detail mite��6L   $ Description de l'action :��5�      $
 Wrap=�6V   #��[ 5�      $��10q�6V   �� 5�      -   5        $��ActionTypeTxt��5�       . $ Type d'action :��5�      #��[ 5�      $��10q�6F   �� 5      -   5        $��FixerNameTxt��5       . $ Etablie par :��5     #��[ 5     $��10q�6F   �� 5     -   5        $��FixerFunctionTxt��5      . $ 
Fonction :��5     #��[ 5     $��10q�6F   �� 5
     -   5        $��FixerStructureTxt��5
      . $0 *Structure responsable de mise en oueuvre :��5     #��[ 5     $��10q�6F   �� 5     $2��,Temp planifie pour lever le non-conformite :��6    $��	10,20,0,4q�6T   � 5     $��0,0,0,30q�6    5     �� 5     $��* �6/   �� 5     $��* �6/   .+�5     �� -   5        $��	StartDate��5  "   $��0��63    . $ Date de debut :��5     $��
00-00-0000��6L   #��[ 5     $��10,10.2,10,9.6q�6V   �� 5     -   5        $��EndDate��5  "   $��1��61    . $ Date de fin :��5     $��
00-00-0000��6J   #��[ 5     $��10,10.2,10,9.6q�6V   5"     5'     5)     �� 5,     $��2��6   $��Disabled=�6+   $
��Auto=�6T   .��5-     �� -   5        $��PicContainer��5-     $��Right=�61   5.     52     55     5:     