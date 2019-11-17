using conformityManager.Pages;
using conformityManager.Ressources.Structures;
using conformityManager.Ressources.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace conformityManager
{
    public partial class MainWindow : Window
    {
        public Nullable<User> loginUser;// structures dont support a NULL value, Nullable is to provide that support
        // public Page CurrentPage;
        private Page currentPage;//loginPage, adminPage, userPage;
        public SqlTools sqlTools;
        public String errorMsg, successMsg = "";

        public MainWindow()
        {
            sqlTools = new SqlTools();
            InitializeComponent();

            //MsgSuccessSnackbar.Background = new SolidColorBrush(Colors.DarkSeaGreen);
            //MsgErrorSnackbar.Background = new SolidColorBrush(Colors.IndianRed);

            LoadLoginPage();
            //LoadUserPage();
            //LoadAdminPage();




            ////////////////////////////////////////////////////////////////////
            /// REMOVE THIS UGLY CODE
            ////////////////////////////////////////////////////////////////////
            ///
            int i = 1, j = 2, dd = 3;

            String s = "abfcdefgh";
            String s2 = s.Remove(s.IndexOf('f'), 2).Insert(0, "X");


            //Console.WriteLine(replaceCharacter(s,2," "));
            //Console.WriteLine(s.Replace('a','z'));
            //Console.WriteLine(s2);

            /*Dictionary<int, int> d = new Dictionary<int, int>()
                {
                    { 1,100},
                };
            d.Add(2, 232);
            Console.WriteLine(d[1].ToString());*/

            //Hashtable ht = new Hashtable();


            ////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////




        }

        /*String replaceCharacter(String source,int index, String newCharacter)
        {


            return source.Remove(index,1).Insert(index, newCharacter);
        }*/

        public void LoadLoginPage()
        {
            MainTransitioner.SelectedIndex = 0;
            this.currentPage = new LoginPage(this);
            MainFrame.Content = this.currentPage;
        }

        public void LoadUserPage()
        {
            MainTransitioner.SelectedIndex = 1;
            this.currentPage = new UserPage(this);
            UserFrame.Content = this.currentPage;
        }

        public void LoadAdminPage()
        {
            MainTransitioner.SelectedIndex = 2;
            this.currentPage = new AdminPage(this);
            AdminFrame.Content = this.currentPage;
        }




        // SNACKBAR message

        public void newSuccessMessageQueue(String message)
        {
            if (successMsg != message || !MsgSuccessSnackbar.IsActive)
            {
                successMsg = message;

                TextBlock snackBarText = new TextBlock();
                snackBarText.Foreground = new SolidColorBrush(Colors.White);
                snackBarText.Text = message;

                MsgSuccessSnackbar.MessageQueue.Enqueue(snackBarText);//, "X", param => { }, "");
            }
        }


        public void newErrorMessageQueue(String message)
        {
            if(errorMsg != message || !MsgErrorSnackbar.IsActive)
            {
                errorMsg = message;

                TextBlock snackBarText = new TextBlock();
                snackBarText.Foreground = new SolidColorBrush(Colors.White);
                snackBarText.Text = message;

                MsgErrorSnackbar.MessageQueue.Enqueue(snackBarText);
            }
        }



    }
}
