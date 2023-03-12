using Microsoft.Win32;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp3
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


        private void Button_Click_Copy(object sender, RoutedEventArgs e)
        {
            text.Copy();
        }

        private void Button_Click_Paste(object sender, RoutedEventArgs e)
        {
            text.Paste();
        }

        private void Button_Click_Cut(object sender, RoutedEventArgs e)
        {
            text.Cut();
        }

        private void Button_Click_SelectAll(object sender, RoutedEventArgs e)
        {
            if (text != null)
            {
                text.Focus();
                text.SelectAll();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("C:\\Users\\StepGuest\\Desktop\\nazim.txt.txt", text.Text);
        }


    }
}