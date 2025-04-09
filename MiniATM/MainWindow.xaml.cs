using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiniATM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double balance = 10000;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CheckBalance_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Your balance is {balance} Rupees");
        }
        private void Withdraw_Click(object sender ,RoutedEventArgs e)
        {
            var amount=Microsoft.VisualBasic.Interaction.InputBox("Enter the amount to withdraw:", "Withdraw", "0");
            if(double.TryParse(amount, out double value) && value > 0 && value <= balance)
            {
                balance -= value;
                MessageBox.Show($"You have successfully withdrawn {value} Rupees. Your new balance is {balance} Rupees.");
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a positive number less than or equal to your balance.");
            }
        }
        private void Deposit_Click(object sender , RoutedEventArgs e)
        {
            var amount=Microsoft.VisualBasic.Interaction.InputBox("Enter the amount to deposit:", "Deposit", "0");
            if(double.TryParse(amount,out double value) && value > 0)
            {
                balance += value;
                MessageBox.Show($"You have successfully deposited {value} Rupees. Your new balance is {balance} Rupees.");
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a positive number.");
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for using our ATM. Goodbye!");
            Close();
        }
    }
}