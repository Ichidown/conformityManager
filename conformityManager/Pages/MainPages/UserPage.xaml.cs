
using System.Windows;
using System.Windows.Controls;

namespace conformityManager.Pages
{
    public partial class UserPage : Page
    {
        MainWindow mainWindow;
        NcManagementPage ncManagementPage;

        public UserPage(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();

            UserFullNameTxt.Text = mainWindow.loginUser.Value.full_name;
            UserJobTxt.Text = mainWindow.loginUser.Value.function;

            ncManagementPage = new NcManagementPage(mainWindow);

            NcManagementFrame.Content = ncManagementPage;

            
        }

        // UI input
        private void LogOut(object sender, RoutedEventArgs e)
        {
            ncManagementPage.QuitPage(); // hide all visible forms
            this.mainWindow.LoadLoginPage();
        }

    }
}
