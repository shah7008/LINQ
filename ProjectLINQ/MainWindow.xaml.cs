using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectLINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchBt_Click(object sender, RoutedEventArgs e)
        {
            string query=searchTb.Text;
            //now find query in file 1 and textblock 1 populates with matched line 
            //After first the 2 and 3 textblocks populates with files 2 and 3 having alternates of textblock 1

            String strPath = @"C:\jimmybuffett";
            var songs = from song in Directory.GetFiles(strPath, "*", SearchOption.AllDirectories)
                        where File.ReadAllLines(song).Contains(query)
                        select song;

            foreach (var song in songs)
            {
                textBlock1.Text = textBlock1.Text + song;
            }
        }
    }
}
