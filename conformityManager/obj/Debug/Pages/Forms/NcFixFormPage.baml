   M S B A M L   `   `   `  ����L  HconformityManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:MoustakbalManager.Tools.ValidationRules'MoustakbalManager.Tools.ValidationRules  5      +    %conformityManager.Pages.NcFixFormPage   5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Rvalidationdomain5clr-namespace:MoustakbalManager.Tools.ValidationRules     5         MaterialDesignBody#���   5      $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5	   
    N� Title$ UserPage��5      $��Disabled=�6   $	��400��6L    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?�6%   %    5      .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�5      $��16q�5      .��5      ]� .+�5       �� $��Center=�6   $
��Left=�67   $��	16 0 16 0q�5!      $
��Left=�6&   $)��#Lever fichier de non conformite HSE��5"      �� 5$       # MaterialDesignRaisedLightButton#��[ 6   $��Right=�6R   	 �� 	IsDefault	 . $2��,materialDesign:DialogHost.CloseDialogCommand��5%   &   
���  ��
���  ��
�������$
��Auto��5&   K   $��Center=�6Y   $��Right=�6t   ��5'      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5(   )   ��6   9system&clr-namespace:System;assembly=mscorlib     6)   True��5*      .��5+   /   X5-      5.      5/      �� 52   
   -   5        $��CauseTxt��52   '   $��10,10,10,20q�6    * &MaterialDesignOutlinedTextFieldTextBox#��[ 53   	   $	��Top=�54   	   $	��100��55   	   
 �� AcceptsReturn
 .  �� TextWrapping$
 Wrap=�57   	   " �� VerticalScrollBarVisibility$
 Auto=�58   	   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cause(s) probable(s) :��59   	   {�5:   	   ��  �� Path$ 	IsChecked� �� ElementName$; 5MaterialDesignOutlinedTextFieldTextBoxEnabledComboBox��.��6r   ��5;      �� 5<      $	 Tag�6    �� UpdateSourceTrigger$ PropertyChanged=�6L    �� RelativeSource 6%   �� *Self+ �� ValidationRules 5=      D   >MoustakbalManager.Tools.ValidationRules.NotEmptyValidationRule  5>      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 6B   5@      .��5A      5B      �� 5F   
   -   5        $��DescriptionTxt��5F   (   $��10,10,10,20q�6   #��[ 5G   	   $	��Top=�5H   	   $	��100��5I   	   
 . $
 Wrap=�5K   	   $
 Auto=�5L   	   $ Description de l'action :��5M   	   {�5N   	   �� $ 	IsChecked�$; 5MaterialDesignOutlinedTextFieldTextBoxEnabledComboBox��.��6q   ��5O      �� 5P      $	 Tag�6   $ PropertyChanged=�6L    6%   �� *Self+ 5Q        5R       . 6B   5T      .��5U      5V      &   MaterialDesignThemes.Wpf.Flipper  5Y   
   -   5        $��ActionTypeFlipper��5Y   I   $��0,0,10,0q�67    � ToolTip$7 1Type de l'action de levée de la non conformité.��6b     MaterialDesignCardFlipper#��[ 5Z      $��Right=�6@   $��Center=�6\   $��Center=�6�   $��Center=�6�   ��5Y   !   Z� ��5Z   �   Z�    FrontContent 5[      �� 5\        MaterialDesignFlatButton#��[ 5]         FlipCommand#��Z 5^      .��6K   
Correction5`         BackContent 5c      �� 5d      #��[ 5e      #��Z 5f      .��6K   
Corrective5h      5j      �� 5n   
   -   5        $��FixerNameTxt��5n       �� 	MaxLength$ 40��6&   $ Etablie par :��5o       % !MaterialDesignFloatingHintTextBox#��[ 5p      $��10q�6F   .��6S   ��5q      �� 5r      $	 Tag�6   $ PropertyChanged=�6L    6%   �� *Self+ 5s        5t       . 6B   5v      .��5w      5x      �� 5z   
   -   5        $��FixerFunctionTxt��5z      $ 50��6*   $ 
Fonction :��5{      #��[ 5|      $��10q�6F   .��6S   ��5}      �� 5~      $	 Tag�6   $ PropertyChanged=�6L    6%   �� *Self+ 5        5�       . 6B   5�      .��5�      5�      �� 5�   
   -   5        $��FixerStructureTxt��5�      $ 50��6+   $0 *Structure responsable de mise en oueuvre :��5�      #��[ 5�      $��10q�6F   .��6S   ��5�      �� 5�      $	 Tag�6   $ PropertyChanged=�6L    6%   �� *Self+ 5�        5�       . 6B   5�      .��5�      5�      �� 5�   
   $2��,Temp planifie pour lever le non-conformite :��6   $��	10,20,0,4q�6H   � 5�   
   $��0,0,0,30q�6    � ColumnDefinitions 5�      �� 5�      $	��19* �6#   �� 5�      $	��81* �6#   �� 5�      $
��100* �6#   .+�5�      (  "System.Windows.Controls.DatePicker  -   5        $��	StartDate��5�      $��0��5�      $��10,10,10,10.2q�6)    � Language$ fr-CA�5�       ( $MaterialDesignFloatingHintDatePicker#��[ 6    $ Date de debut��5�      $��2��6>      SelectedDate 5�      �� 5�      $	 Tag�6   $ PropertyChanged=�6P    6)   �� *Self+ 5�        5�       . 6F   5�      5�        5�      -   5        $��EndDate��5�      $��2��5�      $��10,10,10,10.2q�6)   $ fr-CA�5�      #��[ 6    $ Date de fin��5�       5�      �� 5�      $	 Tag�6   $ PropertyChanged=�6P    6)   �� *Self+ 5�        5�       . 6F   5�      5�      5�      �� 5�   
   -	   5         $	  MaterialDesignRaisedAccentButton#��[	 5�   ,   $
��Auto��6f   $��Center=�6t   $��Center=�6�   .��5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� $��Confirmer Creation��6   $��Center=�66   '  !MaterialDesignThemes.Wpf.PackIcon  5�      �	  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]] 	  Kind$ Check=�6*   $��4q�67   5�      5�      5�      5�      