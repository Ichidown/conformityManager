using conformityManager.Pages.Other;
using conformityManager.Ressources.Structures;
using conformityManager.Ressources.Tools;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;

namespace conformityManager.Pages.Forms
{
    public partial class NcFullDetailPage : Page
    {
        NcManagementPage ncManagementPage;
        NcFile ncFile;
        NcFileDetails ncFileDetails;
        NcFileFix ncFileFix;

        public NcFullDetailPage(NcManagementPage ncManagementPage, NcFile ncFile, NcFileDetails ncFileDetails, NcFileFix ncFileFix)
        {
            this.ncManagementPage = ncManagementPage;
            this.ncFile = ncFile;
            this.ncFileDetails = ncFileDetails;
            this.ncFileFix = ncFileFix;
            InitializeComponent();

            

            // hide non allowed buttons
            if (!ncManagementPage.mainWindow.loginUser.Value.user_type) // the current user is not an admin
            {
                ValidateFlipper.Visibility = Visibility.Collapsed;
                FinaliseFlipper.Visibility = Visibility.Collapsed;
            }

            if (!ncFile.is_valid || ncFile.state==2)
                FinaliseFlipper.Visibility = Visibility.Collapsed;

            if (!ncManagementPage.mainWindow.loginUser.Value.user_type &&  // the current user is not an admin
                ncManagementPage.mainWindow.loginUser.Value.id != ncFile.fix_user_id) // the current user is not the fixer
                ResetFlipper.Visibility = Visibility.Collapsed;

            

            initializeData(ncFile, ncFileDetails, ncFileFix);// populate text fields
            
            // populate Image List
            for (int i = 0; i < ncManagementPage.ncCaseBitmapImageList.Count; i++)
            {
                Frame newFrame = new Frame
                {
                    Margin = new Thickness(4),
                    Content = new ZoomPicPage(ncManagementPage, i)
                };

                PicContainer.Children.Add(newFrame);
            }

            if(ncFile.is_valid)
                ValidateFlipperFrontBtn.Content = "Anuler validation";
        }


        public void FinaliseNcFileFix(object sender, RoutedEventArgs e)
        {
            //NcFile ncFile = ncManagementPage.focussedNcListPage.NcCaseList[ncManagementPage.focussedNcListPage.NcCaseDataGrid.SelectedIndex];

            if (ncManagementPage.mainWindow.sqlTools.finaliseNcFileFix(ncFile.id, ncManagementPage.mainWindow))
            {
                ncManagementPage.focussedNcListPage.RefreshNcCaseDataGrid();
                ncManagementPage.NewFormDialog.IsOpen = false;
                ncManagementPage.mainWindow.newSuccessMessageQueue("Realisation du fichier de non conformite avec success.");
            }
            else
                ncManagementPage.mainWindow.newErrorMessageQueue("Erreur de tentative de realisation du fichier de non conformite.");








        }


        public void ValidateNcFileFix(object sender, RoutedEventArgs e)
        {
            //NcFile ncFile = ncManagementPage.focussedNcListPage.NcCaseList[ncManagementPage.focussedNcListPage.NcCaseDataGrid.SelectedIndex];

            if (ncManagementPage.mainWindow.sqlTools.validateNcFileFix(ncFile.id, !ncFile.is_valid, ncManagementPage.mainWindow))
            {
                ncManagementPage.focussedNcListPage.RefreshNcCaseDataGrid();
                ncManagementPage.NewFormDialog.IsOpen = false;
                ncManagementPage.mainWindow.newSuccessMessageQueue("Validation du fichier de non conformite avec success.");
            }
            else
                ncManagementPage.mainWindow.newErrorMessageQueue("Erreur de tentative de validation du fichier de non conformite.");
        }


        public void ResetNcFileFix(object sender, RoutedEventArgs e)
        {
            if (ncManagementPage.mainWindow.sqlTools.resetNcFileFix(ncManagementPage.focussedNcListPage.NcCaseList[ncManagementPage.focussedNcListPage.NcCaseDataGrid.SelectedIndex].id,ncManagementPage.mainWindow))
            {
                ncManagementPage.focussedNcListPage.RefreshNcCaseDataGrid();
                ncManagementPage.NewFormDialog.IsOpen = false;
                ncManagementPage.mainWindow.newSuccessMessageQueue("Restoration du fichier de non conformite avec success.");
            }
            else
                ncManagementPage.mainWindow.newErrorMessageQueue("Erreur de tentative de restoration du fichier de non conformite.");
        }


        private void initializeData(NcFile ncFile, NcFileDetails ncFileDetails, NcFileFix ncFileFix)
        {
            // NcFile case
            caseTitleLabel.Text = ncFile.case_title;
            userFullNameTxt.Text = ncFile.nc_user_full_Name;
            structureTxt.Text = ncFile.structure_name;
            NcDescriptionTxt.Text = ncFileDetails.description;
            n_planTxt.Text = ncFileDetails.n_plan;
            partial_setTxt.Text = ncFileDetails.partial_set;
            sourceTxt.Text = ncFile.source ? "Externe" : "Interne";
            creationDateTxt.Text = ncFile.creation_date;

            //NcFile fix
            CauseTxt.Text = ncFileFix.cause;
            ActionDescriptionTxt.Text = ncFileFix.action_description;
            ActionTypeTxt.Text = ncFileFix.action_type == 2 ? "Réalisée" : ncFileFix.action_type == 1 ? "En cours" : "Non entamée";
            FixerNameTxt.Text = ncFileFix.fixer_full_name;
            FixerFunctionTxt.Text = ncFileFix.fixer_function;
            FixerStructureTxt.Text = ncFileFix.fixer_structure_name;
            StartDate.Text = ncFileFix.estimated_start_date;
            EndDate.Text = ncFileFix.estimated_end_date;
            
        }

        public void PrintNcFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Office Files(Document or Excel)|*.docx;";
            saveFileDialog1.Title = "Enregistrer le formulaire";
            //saveFileDialog1.FileName = ncFile.case_title;
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                String printResponce = PrintingTools.NewDocXFile(saveFileDialog1.FileName, ncFile, ncFileDetails, ncFileFix);
                if (printResponce == "ok")
                {
                    ncManagementPage.mainWindow.newSuccessMessageQueue("Création du fichier avec succès.");
                    ncManagementPage.NewFormDialog.IsOpen = false;
                }
                else
                    ncManagementPage.mainWindow.newErrorMessageQueue("Erreur d'accès au fichier : " + printResponce);
                
            }

        }

        public void FinaliseFlipperClick(object sender, RoutedEventArgs e)
        {
            ValidateFlipper.IsFlipped = false;
            ResetFlipper.IsFlipped = false;
        }

        public void ValidateFlipperClick(object sender, RoutedEventArgs e)
        {
            ResetFlipper.IsFlipped = false;
            FinaliseFlipper.IsFlipped = false;
        }

        public void ResetFlipperClick(object sender, RoutedEventArgs e)
        {
            ValidateFlipper.IsFlipped = false;
            FinaliseFlipper.IsFlipped = false;
        }



        

    }
}
