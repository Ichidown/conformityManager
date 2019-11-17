using System;
using System.Windows;
using System.Windows.Controls;

namespace conformityManager.Pages.Other
{
    public partial class ImageViewerPage : Page
    {
        NcManagementPage ncManagementPage;
        public int currentIndex;
        public ImageViewerPage(NcManagementPage ncManagementPage)
        {
            this.ncManagementPage = ncManagementPage;

            InitializeComponent();
        }

        private void NextImage(object sender, RoutedEventArgs e)
        {
            currentIndex = ncManagementPage.GetNavigationImageIndex(false, currentIndex);
            ImageX.Source = ncManagementPage.ncCaseBitmapImageList[currentIndex];
        }

        private void PreviousImage(object sender, RoutedEventArgs e)
        {
            currentIndex = ncManagementPage.GetNavigationImageIndex(true, currentIndex);
            ImageX.Source = ncManagementPage.ncCaseBitmapImageList[currentIndex];
        }
        
        private void QuitSelf(object sender, RoutedEventArgs e)
        {
            ncManagementPage.SecondDialog.IsOpen = false;
        }
    }

}
