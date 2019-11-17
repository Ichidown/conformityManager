
using conformityManager.Ressources.DataConverters;
using conformityManager.Ressources.Structures;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace conformityManager.Pages.Other
{
    public partial class NcDetailPage : Page
    {
        NcManagementPage ncManagementPage;
        NcFile ncFile;
        public NcDetailPage(NcManagementPage ncManagementPage, NcFile ncFile, NcFileDetails ncFileDetails)
        {
            this.ncManagementPage = ncManagementPage;
            this.ncFile = ncFile;
            InitializeComponent();
            initializeData(ncFile, ncFileDetails);

            
            for (int i=0;i< ncManagementPage.ncCaseBitmapImageList.Count;i++)
            {
                Frame newFrame = new Frame
                {
                    Margin = new Thickness(4),
                    Content = new ZoomPicPage(ncManagementPage, i)
                };

                PicContainer.Children.Add(newFrame);
            }

        }

        private void initializeData(NcFile ncFile, NcFileDetails ncFileDetails)
        {
            DescriptionTxt.Text = ncFileDetails.description;
            caseTitleLabel.Text = ncFile.case_title;
            userFullNameTxt.Text = ncFile.nc_user_full_Name;
            structureTxt.Text = ncFile.structure_name;
            n_planTxt.Text = ncFileDetails.n_plan;
            partial_setTxt.Text = ncFileDetails.partial_set;
            sourceTxt.Text = ncFile.source ? "Externe" : "Interne";
            creationDateTxt.Text = ncFile.creation_date.ToString();
        }

        private void FixBtn_Click(object sender, RoutedEventArgs e)
        {
            ncManagementPage.ShowEditNcForm();
        }

        
    }
}
