
using conformityManager.Pages.SubPages;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;

namespace conformityManager.Pages
{
    public partial class AdminPage : Page
    {
        MainWindow mainWindow;

        //ValidationPage validationPage;
        NcManagementPage ncManagementPage;
        UserManagementPage userManagementPage;
        LogPage logPage;

        public AdminPage(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            //validationPage = new ValidationPage(mainWindow);
            

            InitializeComponent();

            AdminFullNameTxt.Text = mainWindow.loginUser.Value.full_name;
            AdminJobTxt.Text = mainWindow.loginUser.Value.function;
            
            ncManagementPage = new NcManagementPage(mainWindow);
            userManagementPage = new UserManagementPage(mainWindow);
            logPage = new LogPage(mainWindow);

            //ValidationFrame.Content = validationPage;
            NcManagementFrame.Content = ncManagementPage;
            UsersFrame.Content = userManagementPage;
            LogFrame.Content = logPage;
        }


        // on section change
        public void pickedPageEvent(object sender, RoutedEventArgs e)
        {
            HideAllPopUps();
            MainTransitioner.SelectedIndex = ((ListBox)sender).SelectedIndex; // change section page

            switch (MainTransitioner.SelectedIndex)
            {
                case 0: break;
                case 1: break;
                case 2: logPage.Refresh(); break;
            }
        }

        private void HideAllPopUps()
        {
            // hide all visible forms
            //validationPage.QuitPage();
            ncManagementPage.QuitPage();
            userManagementPage.QuitPage();
            logPage.QuitPage();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            HideAllPopUps();
            this.mainWindow.LoadLoginPage();
        }
    }
}
