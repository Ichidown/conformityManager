
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace conformityManager.Pages
{
    public partial class PickPage : Page
    {
        private NcFileFormPage ncFileFormPage;
        private Frame containerFrame;
        private BitmapImage bitmapImage;
        public PickPage(NcFileFormPage ncFileFormPage, Frame containerFrame, BitmapImage bitmapImage)
        {
            this.ncFileFormPage = ncFileFormPage;
            this.containerFrame = containerFrame;
            this.bitmapImage = bitmapImage;

            InitializeComponent();

            ImageX.Source = bitmapImage;
        }

        private void removeSelf(object sender, RoutedEventArgs e)
        {
            this.ncFileFormPage.removePicture(containerFrame);
        }
    }
}
