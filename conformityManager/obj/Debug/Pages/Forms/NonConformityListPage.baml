   M S B A M L   `   `   `  ����L  HconformityManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:conformityManager.Ressources.DataConverters+conformityManager.Ressources.DataConverters  5      3    -conformityManager.Pages.NonConformityListPage   5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Tdataconverters9clr-namespace:conformityManager.Ressources.DataConverters     5         MaterialDesignBody#���   5      $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5	   
    N� Title$ UserPage��5      $��Disabled=�6    � 	Resources 5      A   ;conformityManager.Ressources.DataConverters.BooleanToSource  booleanToSource@   :conformityManager.Ressources.DataConverters.BooleanToValid  booleanToValid@   :conformityManager.Ressources.DataConverters.BooleanToState  booleanToState��%W   &	       &	      &	 &       5   
   6)     5   
   6(     5   
   6(   5      .��5      ]� $��Disabled=�6   ���	#FFF5F4F5.+�5   
   #  MaterialDesignThemes.Wpf.Card  $	��Top=�6     MaterialDesignBackground#���  63   .��5      � .+�5      9� $��Stretch=�5      $�� ��5      .��5       � ���#ECEEEE$��0,16,0,0q�61   .+�5!      ��  �� Orientation$ 
Horizontal=�5"      $��20q�62   #���   5#      .+�5&      �� -   5        $��validationComboBox��5&   '    �� SelectedIndex$ 1��6A   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Valide��5'      $��10q�6C   $��72��5(       & "MaterialDesignFloatingHintComboBox#��[ 5)      $
��Left=�6W   .@�5*   "   �� .��6/   Tout5,   #   �� 5-   "   .��6/   
Non valide5/   #   �� 50   "   .��6/   Valide52   #   53      �� 55      -   5        $��sourceComboBox��55   '   $��10q�6=   $ Source��56      $��72��57      $ 0��6)   #��[ 58      $
��Left=�6W   .@�59   "   �� .��6/   Tout5;   #   �� 5<   "   .��6/   	Interne5>   #   �� 5?   "   .��6/   	Externe5A   #   5B      (  "System.Windows.Controls.DatePicker  5D      -   5        $��StartCreationDate��5E      $��10q�5D   )   $	��160��5F      	 � Language$	 fr-CA�5G       ( $MaterialDesignFloatingHintDatePicker#��[ 60   $ Debut date de creation��5H      $
��Left=�6W     5J      -   5        $��EndCreationDate��5K      $	��160��5L      $��10q�6+   $	 fr-CA�5M      #��[ 60   $ Fin date de creation��5N      $
��Left=�6U   �� 5Q      -   5        $��fixedComboBox��5Q   '   $��10q�6=   $ Levee��5R      $��72��5S      $ 0��6)   #��[ 5T      $
��Left=�6W   .@�5U   "   �� .��6/   Tout5W   #   �� 5X   "   .��6/   	Non levee5Z   #   �� 5[   "   .��6/   Levee5]   #   5^        5`      -   5        $��StartFixDate��5a      $	��180��5b      $��10q�6+   $	 fr-CA�5c      #��[ 60   $ Debut date de realisation��5d      $
��Left=�6Z     5f      -   5        $��
EndFixDate��5g      $	��180��5h      $��10q�6+   $	 fr-CA�5i      #��[ 60   $ Fin date de realisation��5j      $
��Left=�6X   5k      5l      5m      �� 5o      -   5        $��SearchTextBox��5o      $ 	Recherche��6/   $	��300��6Z   $��4q�6f   $��0q�6q   
 �� 	MaxLength$	
 100��6}    (	 $MaterialDesignFilledTextFieldTextBox#��[	 5p      $	��Top=�6S   $
��Left=�6k   $��60��6�    � ToolTip$g aEntrez un mot clef pour filtrer le resultat puis appuyer sur 'Entrer' pour apliquer la recherche.��5q   3   .��6�   5r      �� 5t      -	   5        $��9q�5t      $��50��6$   $��50��6/   $	��-10q�6O    /
 +MaterialDesignFloatingActionMiniLightButton#��[
 5u      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5v      $+ %Appliquer la recherche / le filtrage.��5w      $	��Top=�6C   $��Right=�6[   .��5x      '	  !MaterialDesignThemes.Wpf.PackIcon	  �
  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]] 
  Kind$ Magnify=�5y      $��40��5z      $��40��5{      5|      5}      5~      &   System.Windows.Controls.DataGrid  5�   
   -
   5        $��NcCaseDataGrid��5�         
IsReadOnly .    SelectionMode$ Single=�5�      $��0 8 0 0q�5�         CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q�5�         ColumnHeaderPadding$ 8q�5�      ��5�      �� *nonConformityCaseList+ 5�        RowMenu � DataContext �� RelativeSource��%  &	       �� 5�      $��RowMenu��6.   -   5         5�   X   �� *PlacementTarget.DataContext+ �� *Self+.@�5�      m� -   5        ��5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   	  $ Magnify=�6:   $��4q�6I   �� 5�   "   $��Detail��6,   $��Center=�6:   5�      5�      m� 5�      -   5        ��5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   	  $ DeleteForever=�6:   $��4q�6O   �� 5�   "   $��	Supprimer��6,   $��Center=�6=   5�      5�      5�      5�         RowStyle 5�      �� 5�       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5�      ��  �� Property �@�ContextMenu �� Value# [ 64   �� 5�       � ��$ 30��6/    �� Triggers 5�      P� 5�       P� Property �@ 
IsSelected P� Value . . �5�      ��  � �� �	#592A45416;   5�      5�         	CellStyle 5�      �� 5�      *  $System.Windows.Controls.DataGridCell"  6    5�      P� 5�       �@ 
IsSelected . . �5�      ��  � �� �	#000000006;   5�      .�5�      ��  � �� �	#8180808064   �� 5�       � ��$ 0,0,1,0q�68   5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn    Header$  Numero��5�      1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 5�      �� *id+5�        5�      $  Affaire��5�      ! 5�      �� *
case_title+5�        5�      $  Auteur��5�      ! 5�      �� *nc_user_full_Name+5�        5�      $  	Structure��5�      ! 5�      �� *structure_name+5�        5�      $  Source��5�      ! 5�   %   �� *source+" �� 	Converter#" [ 5�        5�      $  Date de creation��5�      ! 5�      �� *creation_date+# �� StringFormat$# {0:dd/MM/yyyy}��5�        5�      $  Debut délai planifié��5�      ! 5�      �� *estimated_start_date+5�        5�      $  Fin délai planifié��5�      ! 5�      �� *estimated_end_date+5�        5�      $
  Etat��5�      ! 5�   %   �� *state+#" [ $   ElementStyle$ 5�      �� 5�      " ��6     5�      P� 5�   "    � ��$ Non entamée��6:   . �5�   &   ��  � �� �	#B5CD5C5C6C   �� 5�   &    � ��
 �����6C   �� 5�   &    � ��$ Stretch=�6L   5�   #   P� 5�   "    � ��$ En cours��6:   . �5�   &   ��  � �� �	#B5FFA5006C   �� 5�   &    � ��
 �����6C   �� 5   &    � ��$ Stretch=�6L   5  #   P� 5  "    � ��$ 
Réalisée��6:   . �5  &   ��  � �� �	#B58FBC8F6C   �� 5  &    � ��
 �����6C   �� 5  &    � ��$ Stretch=�6L   5  #   5     5
       5     $  Date de realisation��5     ! 5     �� *
fix_date+5       5     $  Validation R SMI��6%   ! 6?   �� *
is_valid+#" [ $ 5     �� 5     " ��6     5     P� 5  "    � ��$ Valide��6:   . �5  &   ��  � �� �	#B58FBC8F6C   �� 5  &    � ��
 �����6C   �� 5  &    � ��$ Stretch=�6L   5  #   P� 5  "    � ��$ 
Non Valide��6:   . �5  &   ��  � �� �	#B5CD5C5C6C   �� 5  &    � ��
 �����6C   �� 5  &    � ��$ Stretch=�6L   5  #   5!     5#     5'     5*     5-     