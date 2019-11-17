using conformityManager.Ressources.Interfaces;
using conformityManager.Ressources.Structures;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace conformityManager.Pages.SubPages
{

    public partial class LogPage : Page, SubPageInterface
    {
        MainWindow mainWindow;
        //private string TestData = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
        //private List<string> words;
        //private int maxword;
        //private int index;
        // private System.Threading.Timer Timer;
        //private Random random;
        bool shouldUpdateLogList = true;
        private ObservableCollection<Log> LogList { get; set; } = new ObservableCollection<Log>();


        // public ObservableCollection<LogEntry> LogEntries { get; set; } 


        public LogPage(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();

            //random = new Random();
            //words = TestData.Split(' ').ToList();
            //maxword = words.Count - 1;

            DataContext = LogList;// = new ObservableCollection<Log>();

            //RefreshLogEntryList(); // should be called when in sight 1st time and when updated

            // RefreshLog(null,null);

            //Timer = new Timer(x => AddRandomEntry(), null, 1000, 10);

        }

        public void Refresh()
        {
            if (shouldUpdateLogList)
            {
                RefreshLogList();
                shouldUpdateLogList = false;
            }
        }


        private void RefreshLog(object sender, RoutedEventArgs e)
        {
            RefreshLogList();
        }

        private void RefreshLogList()
        {
            mainWindow.sqlTools.RefreshLogListSQL(mainWindow, LogList);
            ResultCountBadge.Badge = LogList.Count + " Logs";
        }



        /*private void AddRandomEntry()
        {
            Dispatcher.BeginInvoke((Action)(() => LogEntries.Add(GetRandomEntry())));
        }*/

        /*private LogEntry GetRandomEntry()
        {
            if (true)
            {
                return new LogEntry()
                {
                    Index = index++,
                    DateTime = DateTime.Now,
                    Message = string.Join(" ", Enumerable.Range(5, random.Next(10, 50))
                                                         .Select(x => words[random.Next(0, maxword)])),
                };
            }

            return new CollapsibleLogEntry()
            {
               Index = index++,
                DateTime = DateTime.Now,
                Message = string.Join(" ", Enumerable.Range(5, random.Next(10, 50)).Select(x => words[random.Next(0, maxword)]))//,
                //Contents = Enumerable.Range(5, random.Next(5, 10)).Select(i => GetRandomEntry()).ToList()
            };

        }*/

        public void QuitPage()
        {
            
        }
    }
}
