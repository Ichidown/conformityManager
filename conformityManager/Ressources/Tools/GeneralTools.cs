using System.Windows.Media.Imaging;

namespace conformityManager.Ressources.Tools
{
    public static class GeneralTools
    {

        public static BitmapImage BytessToImage(byte[] array) // Convert byte[] to BitmapImage
        {
            using (var ms = new System.IO.MemoryStream(array))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }



    }
}
