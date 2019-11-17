using conformityManager.Pages.Forms;
using conformityManager.Pages.Other;
using conformityManager.Ressources.Interfaces;
using conformityManager.Ressources.Structures;
using conformityManager.Ressources.Tools;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Xceed.Words.NET;

namespace conformityManager.Pages
{
    public partial class NcManagementPage : Page, SubPageInterface
    {
        public NonConformityListPage QualityPage, HsePage, focussedNcListPage;
        NcFileFormPage ncFileFormPage;
        NcFixFormPage ncFixFormPage;
        NcDetailPage ncDetailPage;
        NcFullDetailPage ncFullDetailPage;
        ImageViewerPage imageViewerPage;
        public List<BitmapImage> ncCaseBitmapImageList = new List<BitmapImage>();
        //public int focussedRow;
        public MainWindow mainWindow;
        public bool isHse = false;


        public NcManagementPage(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();

            // create pages instances
            QualityPage = new NonConformityListPage(this,false);
            HsePage = new NonConformityListPage(this,true);
            imageViewerPage = new ImageViewerPage(this);

            // set pages to their frames\
            QualityFrame.Content = QualityPage;
            HseFrame.Content = HsePage;
            //SecondFrame.Content = imageViewerPage;

            focussedNcListPage = QualityPage;
        }




        private void SwitchToQuality(object sender, RoutedEventArgs e)
        {
            //focussedRow = 0;
            focussedNcListPage = QualityPage;
            MainTransitioner.SelectedIndex = 0;
            isHse = false;
        }

        public void SwitchToHSE(object sender, RoutedEventArgs e)
        {
            //focussedRow = 1;
            focussedNcListPage = HsePage;
            MainTransitioner.SelectedIndex = 1;
            isHse = true;
        }

        public void ShowNewNcForm(object sender, RoutedEventArgs e)
        {
            ncFileFormPage = new NcFileFormPage(this, isHse);
            NcFileFormFrame.Content = ncFileFormPage;
            NewFormDialog.IsOpen = true;
        }

        public void ShowNcDetailForm(NonConformityListPage nonConformityListPage)//, int index)
        {
            // Get focussed NcCase (NOT OPTIMAL)
            /*int currentId = 0;
            int ix = 0;
            while (ix < focussedNcListPage.NcCaseList.Count) // && focussedNcListPage.NcCaseList[ix].id != ((NcFile)focussedNcListPage.NcCaseDataGrid.Items[focussedNcListPage.NcCaseDataGrid.SelectedIndex]).id)
            //for(int i=0;i< focussedNcListPage.NcCaseList.Count;i++)
            {
                if(focussedNcListPage.NcCaseList[ix].id == ((NcFile)focussedNcListPage.NcCaseDataGrid.Items[focussedNcListPage.NcCaseDataGrid.SelectedIndex]).id)
                {
                    currentId = ix;
                    ix = focussedNcListPage.NcCaseList.Count; // to exit the loop
                }
                ix++;
            }*/
            // ---------------------------------



            NcFile ncCase = (NcFile)focussedNcListPage.NcCaseDataGrid.Items[focussedNcListPage.NcCaseDataGrid.SelectedIndex];//focussedNcListPage.NcCaseList[currentId];// focussedNcListPage.NcCaseDataGrid.SelectedIndex];

            Nullable<NcFileDetails> ncFileDetail = mainWindow.sqlTools.GetNcFileDetailSQL(ncCase.id, mainWindow);

            if (ncFileDetail.HasValue)
            {

                // get Bitmap images from server
                ncCaseBitmapImageList.Clear();
                ncCaseBitmapImageList.AddRange(mainWindow.sqlTools.GetImageListSQL(ncCase.id, mainWindow));            


            if (ncCase.estimated_start_date != "")
                {
                    Nullable<NcFileFix> ncFileFix = mainWindow.sqlTools.GetNcFileFixSQL(ncCase.id, mainWindow);
                    ncFullDetailPage = new NcFullDetailPage(this, ncCase, ncFileDetail.Value, ncFileFix.Value);
                    NcFileFormFrame.Content = ncFullDetailPage;
                }
                else
                {
                    ncDetailPage = new NcDetailPage(this, ncCase, ncFileDetail.Value);
                    NcFileFormFrame.Content = ncDetailPage;
                }
                NewFormDialog.IsOpen = true;
            }

        }

        public void ConfirmRemoveNcFile(object sender, RoutedEventArgs e)
        {
            // deleate images related to ncFile
            mainWindow.sqlTools.RemoveImageSQL(focussedNcListPage.NcCaseList[focussedNcListPage.NcCaseDataGrid.SelectedIndex].id, mainWindow);
            if(mainWindow.sqlTools.RemoveNcFileSQL(focussedNcListPage.NcCaseList[focussedNcListPage.NcCaseDataGrid.SelectedIndex].id, mainWindow))
            {
                mainWindow.newSuccessMessageQueue("Supression du ficher de Non conformite avec success.");
                focussedNcListPage.RefreshNcCaseDataGrid();
            }

        }

        public void ShowEditNcForm()
        {
            ncFixFormPage = new NcFixFormPage(this);
            SecondFrame.Content = ncFixFormPage;
            SecondDialog.IsOpen = true;
            NewFormDialog.IsOpen = false;
        }

        public void OpenImageViewerDialog(int index)
        {
            imageViewerPage.ImageX.Source = ncCaseBitmapImageList[index];
            imageViewerPage.currentIndex = index;
            SecondFrame.Content = imageViewerPage;
            SecondDialog.IsOpen = true;
        }

        public int GetNavigationImageIndex(bool isPrevious,int currentIndex)
        {
            if (isPrevious)
            {
                if (currentIndex - 1 < 0)
                    return ncCaseBitmapImageList.Count - 1;
                else
                    return currentIndex - 1;
            }
            else
            {
                if (currentIndex + 1 > ncCaseBitmapImageList.Count-1)
                    return 0;
                else
                    return currentIndex + 1;
            }
        }




        public void PrintNcFileList(object sender, RoutedEventArgs e)
        {
            //Print here

            //Console.WriteLine(focussedNcListPage.ToString());

            /*
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX  " + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            // Directory containing many .docx documents.
            DirectoryInfo di = new DirectoryInfo(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);

            // Load the document.
            using (DocX document = DocX.Load(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+ "\\Template01.docx"))
            {
                // Replace text in this document.
                document.ReplaceText("<Title>", "Hello file");

                // Save changes made to this document.
                document.Save();
            } // Release this document from memory.

            */


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Office Files(Document or Excel)|*.xlsx;";
            saveFileDialog1.Title = "Enregistrer la liste";
            // saveFileDialog1.FileName = DateTime.Now.ToString();
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                String printResponce = PrintingTools.NewExcelFile(saveFileDialog1.FileName, focussedNcListPage.NcCaseList);
                if (printResponce == "ok")
                {
                    mainWindow.newSuccessMessageQueue("Création du fichier avec succès.");
                }
                else
                    mainWindow.newErrorMessageQueue("Erreur d'accès au fichier : " + printResponce);
            }




        }

        



        public void QuitPage()
        {
            NewFormDialog.IsOpen = false;
            DeleateDialog.IsOpen = false;
            SecondDialog.IsOpen = false;
        }




        

    }
}
