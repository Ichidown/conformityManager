using System;
using System.Windows;
using System.Windows.Controls;

namespace conformityManager.Pages
{
    public partial class NcFixFormPage : Page
    {
        private NcManagementPage ncManagementPage;
        public NcFixFormPage(NcManagementPage ncManagementPage)
        {
            this.ncManagementPage = ncManagementPage;
            InitializeComponent();
        }

        private void ConfirmFixBtnClick(object sender, RoutedEventArgs e)
        {
            if (CauseTxt.Text == "" ||
                DescriptionTxt.Text == "" ||
                FixerNameTxt.Text == "" ||
                FixerFunctionTxt.Text == "" ||
                FixerStructureTxt.Text == "" ||
                StartDate.Text == "" ||
                EndDate.Text == "")
            {
                ncManagementPage.mainWindow.newErrorMessageQueue("Vous devez completer le formulaire");
            }
            else
            {
                if (ncManagementPage.mainWindow.sqlTools.addNcFileFix(
                    ncManagementPage.focussedNcListPage.NcCaseList[ncManagementPage.focussedNcListPage.NcCaseDataGrid.SelectedIndex].id,
                    ncManagementPage.mainWindow.loginUser.Value.id,
                    CauseTxt.Text,
                    DescriptionTxt.Text,
                    ActionTypeFlipper.IsFlipped,
                    FixerNameTxt.Text,
                    FixerFunctionTxt.Text,
                    FixerStructureTxt.Text,
                    StartDate.Text,
                    EndDate.Text,
                    ncManagementPage.mainWindow))
                {
                    ncManagementPage.focussedNcListPage.RefreshNcCaseDataGrid();
                    ncManagementPage.SecondDialog.IsOpen = false;
                    ncManagementPage.mainWindow.newSuccessMessageQueue("Operation reussie");
                }
                else
                    ncManagementPage.mainWindow.newErrorMessageQueue("Erreur de l'operation");
            }
            
        }
        
    }
}
