   M S B A M L   `   `   `  ����   conformityManager9    3conformityManager.Pages.SubPages.UserManagementPage   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008        MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �   N� Title$ UserPage��$��Disabled=�.��)  #MaterialDesignThemes.Wpf.DialogHost  -     Name$ NewFormDialog��   IsOpen .  $��Stretch=�$��Stretch=�   DialogContent  � -     �Name$ UserFormFrame��	  � NavigationUIVisibility$	 Hidden=�.��  -   $ DeleateDialog�� .  $��Stretch=�$��Stretch=� �� $��10q�.+�'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind$
 AlertCircleOutline=�$��80��$��80��$��Center=� J� Opacity$	 0.5Q�$��0,0,0,10q��� $+��%Êtes-vous sure de vouloir supprimer?��$��
20,0,20,20q�$	 0.7Q� % !MaterialDesignSubheadingTextBlock#��[ $��Center=�� .+��� -   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=� # MaterialDesignRaisedLightButton#��[    CloseDialogCommand#��Z $	��100��
���\\��
���\\��
������� � ToolTip$5 /Confirmer la suppression de la non-conformité.��$
��Left=�$��Center=�.��	Confirmer�� #��[ $ Depth0=�#��Z $	��100��
�������
�������
�������$3 -Annuler la suppression de la non-conformité.��$��Right=�$��Center=�.��	Annuler.��#  MaterialDesignThemes.Wpf.Card  $	��Top=�$��10,10,10,40q�$��Center=�.��]� $	��Top=�$
��Left=�.+��� $	��top=� �� Orientation$ 
Horizontal=�$��4q�$��Right=�.+��� -    $  MaterialDesignRaisedAccentButton#��[ $! Cree un nouvel utilisateur.��$��6,0,0,0q�$	��4,2q�.���� $ 
Horizontal=�.+��� $��Nouveau utilisateur��$��Center=�  $
 AccountMultiplePlus=�$��4q�&   System.Windows.Controls.DataGrid  -   $��UserDataGrid��   
IsReadOnly . $��0 8 0 0q�   CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q�   ColumnHeaderPadding$ 8q� � 	Resources   RowMenu � DataContext �� RelativeSource��%  &	       ��  �� *PlacementTarget.DataContext+ �� *Self+.@�m� -   ���� $ 
Horizontal=�.+�  $
 
LeadPencil=�$��4q��� $��Modifier��$��Center=�m� -   ���� $ 
Horizontal=�.+�  $
 DeleteForever=�$��4q��� $��	Supprimer��$��Center=�   RowStyle ��  �� 
TargetType)	  #System.Windows.Controls.DataGridRow" 	 .���  �� Property �@�ContextMenu �� Value# [    Columns 0
  *System.Windows.Controls.DataGridTextColumn
   0 ,MaterialDesignDataGridTextColumnEditingStyle1  +System.Windows.Controls.DataGridBoundColumn   EditingElementStyle# [ ,  &System.Windows.Controls.DataGridColumn   Header$ ID��    Binding  �� *id+
  $ Identifiant��  �� *
username+
  $ Nom complet��  �� *	full_name+
  $ Fonction��  �� *
function+