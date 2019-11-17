using conformityManager.Ressources.Structures;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace conformityManager.Pages
{
    public partial class NcFileFormPage : Page
    {
        private NcManagementPage ncManagementPage;
        public List<ImageFile> imageList = new List<ImageFile>();
        public NcFileFormPage(NcManagementPage ncManagementPage, bool isHse) // NEW CONSTRUCTOR
        {
            this.ncManagementPage = ncManagementPage;
            InitializeComponent();

            NcFileFormTitleTxt.Text = "Nouvelle affaire de non conformite " + (isHse ? "HSE" : "Qualite");
        }


        private void addPicture(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                //imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
                Frame newFrame = new Frame();
                newFrame.Margin = new Thickness(4);
                newFrame.Content = new PickPage(this, newFrame, new BitmapImage(new Uri(op.FileName)));

                imageList.Add(new ImageFile(Path.GetFileName(op.FileName), Path.GetExtension(op.FileName), File.ReadAllBytes(op.FileName)));




                //string filename = Path.GetFileName(op.FileName);
                //string contentType = Path.GetExtension(op.FileName); //May not be right  --------- FileUpload1.PostedFile.ContentType;




                PicContainer.Children.Add(newFrame);
            }
        }

        public void removePicture(Frame picFrame)
        {
            PicContainer.Children.Remove(picFrame);
        }

        private void ConfirmFileCreationBtnClick(object sender, RoutedEventArgs e)
        {
            if (case_titleTxt.Text!="" && 
                n_planTxt.Text != "" && 
                par_setTxt.Text != "" &&
                clientTxt.Text != "" &&
                structureTxt.Text != "" &&
                sourceComboBox.SelectedIndex != -1 && 
                descriptionTxt.Text != "")
            {
                //returnedNcFileId > 0 ? true : false;
                int returnedNcFileId = ncManagementPage.mainWindow.sqlTools.CreateNcFileSQL(ncManagementPage.mainWindow.loginUser.Value.id, ncManagementPage.isHse, case_titleTxt.Text, n_planTxt.Text, par_setTxt.Text, clientTxt.Text, structureTxt.Text, sourceComboBox.SelectedIndex, descriptionTxt.Text, ncManagementPage.mainWindow);

                if (returnedNcFileId > 0)
                {
                    if (ncManagementPage.isHse)
                        ncManagementPage.HsePage.RefreshNcCaseDataGrid();
                    else
                        ncManagementPage.QualityPage.RefreshNcCaseDataGrid();
                    
                    // Upload images here
                    if (imageList.Count > 0)
                    {
                        if (ncManagementPage.mainWindow.sqlTools.CreateImageSQL(returnedNcFileId, imageList, ncManagementPage.mainWindow)) // upload images
                        {
                            Console.WriteLine("image saved");
                        }
                    }

                    ncManagementPage.mainWindow.newSuccessMessageQueue("Ficher de non conformite crèe avec succès.");
                    ncManagementPage.NewFormDialog.IsOpen = false;
                    
                    
                }
                else
                    ncManagementPage.mainWindow.newErrorMessageQueue("Erreur de creation du Ficher de non conformite.");
            }
            else
                ncManagementPage.mainWindow.newErrorMessageQueue("Vous devez completer le formulaire.");
        }





        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }



    }
}
