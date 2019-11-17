using conformityManager.Ressources.Structures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.ComponentModel;
using System.Windows.Input;

namespace conformityManager.Pages
{
    public partial class NonConformityListPage : Page
    {
        private NcManagementPage ncManagementPage;
        private bool isHse;
        public List<NcFile> NcCaseList;

        public NonConformityListPage(NcManagementPage ncManagementPage, bool isHse)
        {
            this.isHse = isHse;
            this.ncManagementPage = ncManagementPage;
            //this.NcCaseList = nonConformityCaseList;

            InitializeComponent();
            // NcCaseDataGrid.ItemsSource = this.nonConformityCaseList;
            //NcCaseDataGrid.Items.Refresh();
            RefreshNcCaseDataGrid();
            

            MenuItem menuItem = new MenuItem();
            menuItem.Header = "Valider";
            //menuItem.Click = ValidateNcInput;
            //NcCaseDataGrid.ContextMenu.Items.Add(menuItem);

            // NcCaseDataGrid.ContextMenu = new ContextMenu();
        }



        public void RefreshNcCaseDataGrid()//List<NcFile> nonConformityCaseList)
        {
            // NcCaseDataGrid.Items.Clear();
            //this.nonConformityCaseList = nonConformityCaseList;
            
            NcCaseList = ncManagementPage.mainWindow.sqlTools.GetNcFileListSQL(
                isHse, ncManagementPage.mainWindow, SearchTextBox.Text, validationComboBox.SelectedIndex,
                sourceComboBox.SelectedIndex, StartCreationDate.Text, EndCreationDate.Text, 
                fixedComboBox.SelectedIndex, StartFixDate.Text, EndFixDate.Text);





            NcCaseDataGrid.ItemsSource = NcCaseList;
            NcCaseDataGrid.Items.Refresh();
            
        }

        public void DetailNcInput(object sender, RoutedEventArgs e)
        {
            ncManagementPage.ShowNcDetailForm(this);
        }

        public void RemoveNcInput(object sender, RoutedEventArgs e)
        {
            ncManagementPage.DeleateDialog.IsOpen = true;
        }

        public void ContextMenuOpened(object sender, RoutedEventArgs e)
        {
            // show delete button if is admin or same fixer/creator user 
            if (ncManagementPage.mainWindow.loginUser.Value.user_type || //is admin
                (ncManagementPage.mainWindow.loginUser.Value.id == NcCaseList[NcCaseDataGrid.SelectedIndex].nc_user_id && // is creator of nc file
                (ncManagementPage.mainWindow.loginUser.Value.id == NcCaseList[NcCaseDataGrid.SelectedIndex].fix_user_id || // is fixer
                NcCaseList[NcCaseDataGrid.SelectedIndex].fix_user_id == -1)))  // there is no fixer

                ((sender as ContextMenu).Items[1] as MenuItem).Visibility = Visibility.Visible;
            else
                ((sender as ContextMenu).Items[1] as MenuItem).Visibility = Visibility.Collapsed;
        }







        // ------------------------------------------ Filtering --------------------------------------------------

        public void ApplyFilter(object sender, RoutedEventArgs e)
        {
            RefreshNcCaseDataGrid();
        }


        private void SearchTextBoxKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                RefreshNcCaseDataGrid();
        }
        
    }
}
