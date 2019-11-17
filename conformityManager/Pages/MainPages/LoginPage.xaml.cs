using System;
using System.Windows;
using System.Windows.Controls;
using System.Timers;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using conformityManager.Ressources.Tools;
using conformityManager.Ressources.Structures;
using System.Diagnostics;
using MaterialDesignThemes.Wpf;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace conformityManager.Pages
{
    public partial class LoginPage : Page
    {
        private MainWindow mainWindow;
        
        //private Timer myTimer;
        //private String BackgroundPath = @"../../Ressources/Images/labbe-chaudronnerie-industrielle-chaudronnerie-inox2.jpg";

        public LoginPage(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;

            InitializeComponent();


            /*SourceTxt.Text = "127.0.0.1";
            portTxt.Text = "3306";
            DatabaseTxt.Text = "ncdb";*/

            SourceTxt.Text = Properties.Settings.Default.Source;
            portTxt.Text = Properties.Settings.Default.Port;
            DatabaseTxt.Text = Properties.Settings.Default.Database;
            DbUserTxt.Text = Properties.Settings.Default.Root;
            DbPassTxt.Password = Properties.Settings.Default.Pass;

            // Create a timer for moving + changing background
            /*myTimer = new Timer();
            // Tell the timer what to do when it elapses
            myTimer.Elapsed += new ElapsedEventHandler(TimerTickEvent);
            // Set it to go off every five seconds
            myTimer.Interval = 1000;
            // And start it
            myTimer.Enabled = true;*/



            // Properties.Settings.Default.
        }

        private void TimerTickEvent(object source, ElapsedEventArgs e)
        {
            /*ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage
            (new Uri(@"pack://../../Ressources/Images/labbe-chaudronnerie-industrielle-chaudronnerie-inox2.jpg"));
            MainGrid.Background = myBrush;*/
        }

        private void Identify(object sender, RoutedEventArgs e)
        {
            if (SourceTxt.Text == "" || portTxt.Text == "" || DatabaseTxt.Text == "" || DbUserTxt.Text=="")
            {
                mainWindow.newErrorMessageQueue("Veillez completer la configuration pour la connection au serveur.");
            }
            else if (UserTextBox.Text == "" || PasswordTextBox.Password == "")
            {
                mainWindow.newErrorMessageQueue("Veillez completer les informations d'identification.");
            }
            else
            {
                mainWindow.sqlTools.InitializeSqlTools(mainWindow, SourceTxt.Text, portTxt.Text, DatabaseTxt.Text, DbUserTxt.Text, DbPassTxt.Password);
                mainWindow.loginUser = mainWindow.sqlTools.LoginSQL(UserTextBox.Text, PasswordTextBox.Password, mainWindow);

                if (mainWindow.loginUser.HasValue)
                {
                    // save connection settings
                    if (Properties.Settings.Default.Source != SourceTxt.Text ||
                        Properties.Settings.Default.Port != portTxt.Text ||
                        Properties.Settings.Default.Database != DatabaseTxt.Text ||
                        Properties.Settings.Default.Root != DbUserTxt.Text ||
                        Properties.Settings.Default.Pass != DbPassTxt.Password)
                    {
                        Properties.Settings.Default.Source = SourceTxt.Text;
                        Properties.Settings.Default.Port = portTxt.Text;
                        Properties.Settings.Default.Database = DatabaseTxt.Text;
                        Properties.Settings.Default.Root = DbUserTxt.Text;
                        Properties.Settings.Default.Pass = DbPassTxt.Password;
                        Properties.Settings.Default.Save();
                    }
                    

                    if (mainWindow.loginUser.Value.id != -1)
                    {
                        if (mainWindow.loginUser.Value.user_type)
                            mainWindow.LoadAdminPage();
                        else
                            mainWindow.LoadUserPage();
                        mainWindow.newSuccessMessageQueue("Bienvenu " + mainWindow.loginUser.Value.full_name);
                    }
                    else
                        mainWindow.newErrorMessageQueue("Utilisateur introuvable.");
                }
            }  
        }


        /*private void closeMsgSnackbar(object sender, RoutedEventArgs e)
        {
            MsgSnackbar.IsActive = false;
        }*/



        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void LoginTextBoxKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Identify(null,null);
        }

        
    }

    
}
