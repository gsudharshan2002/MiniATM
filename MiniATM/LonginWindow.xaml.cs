using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MiniATM
{
    /// <summary>
    /// Interaction logic for LonginWindow.xaml
    /// </summary>
    /// 
   

    public partial class LonginWindow : Window
    {
        private const string pin = "1234";
        public LonginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (pinBox.Password == pin)
            {
                MessageBox.Show("Login successful!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid PIN. Please try again.");
            }
        }
    }
}
