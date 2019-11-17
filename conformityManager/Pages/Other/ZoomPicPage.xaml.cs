using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace conformityManager.Pages.Other
{
    public partial class ZoomPicPage : Page
    {
        NcManagementPage ncManagementPage;
        int index;
        public ZoomPicPage(NcManagementPage ncManagementPage, int index)
        {
            this.index = index;
            this.ncManagementPage = ncManagementPage;
            InitializeComponent();
            ImageX.Source = ncManagementPage.ncCaseBitmapImageList[index];
        }

        private void ImageZoomClick(object sender, RoutedEventArgs e)
        {
            ncManagementPage.OpenImageViewerDialog(index);
        }
    }
    
}