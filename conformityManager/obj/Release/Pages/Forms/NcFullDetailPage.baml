   M S B A M L   `   `   `  ����   conformityManager4    .conformityManager.Pages.Forms.NcFullDetailPage   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008        MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �   N� Title$ UserPage��$��Disabled=�$	��960��$	��600�� � 	Resources  �� MergedDictionaries �� Source��  �� $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?�%    .��]� .+�(  "MaterialDesignThemes.Wpf.ColorZone  $	��Top=�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�	   Mode$	 PrimaryLight=�$��8q�.��]� .+��� -   $��caseTitleLabel��$��Center=�$
��Left=�$��	16 0 16 0q�$
��Left=�$*��$Titre de l'affaire de non conformite����  # MaterialDesignRaisedLightButton#��[ $��Right=�
 �� 	IsDefault
 . $2��,materialDesign:DialogHost.CloseDialogCommand��
���  ��
���  ��
�������$
��Auto��$��Center=�$��Right=���O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem ��9system&clr-namespace:System;assembly=mscorlib     True��.��X  $��Bottom=�$ Depth3=�$��0q�$	 PrimaryLight=�$��Stretch=�
�������$��Stretch=�$��Stretch=���. .��� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+�&   MaterialDesignThemes.Wpf.Flipper  -   $��FinaliseFlipper��  MaterialDesignCardFlipper#��[ $��Stretch=�$��Stretch=�   FrontContent �� -   $��FinaliseFlipperFrontBtn��  MaterialDesignFlatButton#��[    FlipCommand#��Z $��8q� � ToolTip$" Realiser la non conformité.��$	��220��.��
Realiser   BackContent ]� $��Stretch=�$��Stretch=�$��
10,10,10,0q�$	��220��.+��� $
��Left=�$+��%Etes vous sure de vouloir continuer ?��$	��Top=��� $ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��10q�$��Right=�$��Center=�
����� �
�������
����� �#��[ .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Check=��� $��10q�$
��Left=�$��Center=�
����p��
�������
����p��#��Z #��[ .��  $ Close=�  -   $��ValidateFlipper��#��[ $��Stretch=�$��Stretch=� �� -   $��ValidateFlipperFrontBtn��#��[ #��Z $��8q�$! Valider la non conformité.��$	��220��.��	Valider ]� $��Stretch=�$��Stretch=�$��
10,10,10,0q�$	��220��.+��� $
��Left=�$+��%Etes vous sure de vouloir continuer ?��$	��Top=��� $ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��10q�$��Right=�$��Center=�
����� �
�������
����� �#��[ .��  $ Check=��� $��10q�$
��Left=�$��Center=�
����p��
�������
����p��#��Z #��[ .��  $ Close=�  -   $��ResetFlipper��#��[ $��Stretch=�$��Stretch=� �� -	   #��[ #��Z $��8q�$K EEffacer tous les données concernant la levée de la non conformité.��$	��220��.��Reinitialiser ]� $��Stretch=�$��Stretch=�$��
10,10,10,0q�$	��220��.+��� $
��Left=�$/��)Etes vous sure de vouloir reinitialiser ?��$	��Top=��� $ 
Horizontal=�$��Center=�$��Center=�.+��� -
   $��10q�$��Right=�$��Center=�
����� �
�������
����� �#��[ .��  $ Check=��� $��10q�$
��Left=�$��Center=�
����p��
�������
����p��#��Z #��[ .��  $ Close=��� -     MaterialDesignRaisedButton#��[ $  Imprimer la liste visible.��$��5q�$	��4,2q�$��Right=�$��Center=�.���� $ 
Horizontal=�.+��� $��Imprimer��$��Center=�  $ Printer=�$��2,0,0,0q�$��30��$��30���  � ColumnDefinitions �� $��2* ��� $��2* ��� $��* �.+��� $��0��$��Disabled=�$
��Auto=�.���� $��10q�$��0��.+��  �� $��* ��� $��* �.+��� -   $��userFullNameTxt��$��0�� �� 
IsReadOnly . )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Auteur :��$��Auteur�� % !MaterialDesignFloatingHintTextBox#��[ $��10,10.2,10,9.6q��� -   $��structureTxt��$��1�� . $ Structure :��$��Nom de structure 01��#��[ $��10,10.2,10,9.6q��� -   $��NcDescriptionTxt�� . $����Detail de affaire de non conformite Detail de affaire de non conformiteDetail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite Detail de affaire de non conformite��$ Description :�� �� TextWrapping$
 Wrap=�#��[ $��10q��  �� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* �.+��� -   $��	n_planTxt��$��0��$��0��$��1561651 65165 51165��$ Numero Plan :�� . #��[ $��10,10,10,9.8q��� -   $��partial_setTxt��$��0��$��1��$��sdfsd-sdfsdf-sdfsdf-sdf��$ Ensemble partiel :�� . #��[ $��10,10,10,9.8q��� -   $��	sourceTxt��$��1��$��0�� . $ Source :��$��Interne��#��[ $��10,10.2,10,9.6q��� -   $��creationDateTxt��$��1��$��1�� . $ Date de creation :��$��
00-00-0000��#��[ $��10,10.2,10,9.6q��� $��1��$��Disabled=�$
��Auto=�.���� .+��� -   $��CauseTxt�� . $|��vDetail de affaire de non conformite Detail de affaire de non conformiteDetail de affaire de non conformite Detail mite��$ Cause :��$
 Wrap=�#��[ $��10q��� -   $��ActionDescriptionTxt�� . $|��vDetail de affaire de non conformite Detail de affaire de non conformiteDetail de affaire de non conformite Detail mite��$ Description de l'action :��$
 Wrap=�#��[ $��10q��� -   $��ActionTypeTxt�� . $ Type d'action :��#��[ $��10q��� -   $��FixerNameTxt�� . $ Etablie par :��#��[ $��10q��� -   $��FixerFunctionTxt�� . $ 
Fonction :��#��[ $��10q��� -   $��FixerStructureTxt�� . $0 *Structure responsable de mise en oueuvre :��#��[ $��10q��� $2��,Temp planifie pour lever le non-conformite :��$��	10,20,0,4q�� $��0,0,0,30q� �� $��* ��� $��* �.+��� -   $��	StartDate��$��0�� . $ Date de debut :��$��
00-00-0000��#��[ $��10,10.2,10,9.6q��� -   $��EndDate��$��1�� . $ Date de fin :��$��
00-00-0000��#��[ $��10,10.2,10,9.6q��� $��2��$��Disabled=�$
��Auto=�.���� -   $��PicContainer��$��Right=�