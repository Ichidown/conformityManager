   M S B A M L   `   `   `  ���� L  HconformityManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:MoustakbalManager.Tools.ValidationRules'MoustakbalManager.Tools.ValidationRules  ,    &conformityManager.Pages.NcFileFormPage   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Rvalidationdomain5clr-namespace:MoustakbalManager.Tools.ValidationRules        MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �   N� Title$ UserPage��$��Disabled=�$	��400��.���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�$��16q�.��]� .+��� -   $��NcFileFormTitleTxt��$��Center=�$
��Left=�$��	16 0 16 0q�$
��Left=�'%Nouveau fichier de non conformite HSE��  # MaterialDesignRaisedLightButton#��[ $��Right=� �� 	IsDefault . $2��,materialDesign:DialogHost.CloseDialogCommand��
���  ��
���  ��
�������$
��Auto��$��Center=�$��Right=���O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem ��9system&clr-namespace:System;assembly=mscorlib     True��.��X�� -   $��case_titleTxt�� �� 	MaxLength$	 100��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Affaire :�� % !MaterialDesignFloatingHintTextBox#��[ $��10q�.������ 	 �� Path$		 Tag�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� RelativeSource �� *Self+ �� ValidationRules D   >MoustakbalManager.Tools.ValidationRules.NotEmptyValidationRule  ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . .���  � ColumnDefinitions �� $��* ��� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* �.+��� -   $��	n_planTxt��$��0��$��0��$ Numero Plan :��$ 30��#��[ $��10,10,10,9.8q�.������ $		 Tag�$
 PropertyChanged=� �� *Self+    . .���� -   $��
par_setTxt��$��1                      ��$��0��$ 40��$ Ensemble partiel :��#��[ $��10,10,10,9.8q�.������ $		 Tag�$
 PropertyChanged=� �� *Self+    . .���� -   $��	clientTxt��$��2��$��0��$ Client :��$	 100��#��[ $��10,10,10,9.8q�.������ $		 Tag�$
 PropertyChanged=� �� *Self+    . .���� -   $��structureTxt��$��0��$��1��$	 100��$ Structure :��#��[ $��10,10.2,10,9.6q�$��2��.������ $		 Tag�$
 PropertyChanged=� �� *Self+    . .���� -   $��sourceComboBox��$��2��$��1��$ Source :��$��10,19.2,10,8.6q�.@��� .��	Interne�� .��	Externe �� Text �� $		 Tag�$
 PropertyChanged=� �� *Self+    . � $��10,20,10,10q�.+��� -   $��descriptionTxt�� * &MaterialDesignOutlinedTextFieldTextBox#��[ $	��Top=�$	��100�� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=�$ Description :��{��� $	 	IsChecked� �� ElementName$; 5MaterialDesignOutlinedTextFieldTextBoxEnabledComboBox��.������ $		 Tag�$
 PropertyChanged=� �� *Self+    . .��#  MaterialDesignThemes.Wpf.Card  $��10,20,10,50q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�.��� $	��120��.+��� $
��Auto=�$��Disabled=� � ToolTip$; 5Inserrez des images représentant la non conformité.��.���� -	   $��PicContainer��$��Right=� �� Orientation$ 
Horizontal=�$��Center=��� -
   $
��Left=�  MaterialDesignRaisedButton#���  $	��Top=�$
��Left=�$��0,0,10,0q�$��0q�$
��Auto�����	#FF5BED52���	#FF5BED52.��'  !MaterialDesignThemes.Wpf.PackIcon  �	  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]] 	  Kind$	 Add=��� -    $  MaterialDesignRaisedAccentButton#��[ $
��Auto��$��Center=�$��Center=�.���� $ 
Horizontal=�.+��� $��Confirmer Creation��$��Center=�  $ FilePlus=�$��4q�