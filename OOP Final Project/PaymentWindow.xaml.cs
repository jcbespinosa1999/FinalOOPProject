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

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public static int counter;
        public PaymentWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void verifyButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkValidity = true;
        
               
            for (counter = 0; counter <= DataStorage.pinEightDigits.Count; counter++)
            {
                int enteredPin = Convert.ToInt32(txtVerify.Text);
                if (enteredPin == DataStorage.pinEightDigits[counter])
                    break;
            }
            if (checkValidity == true)
            {
                PaymentDetailsWindow openPaymentDetailsWindow = new PaymentDetailsWindow();
                openPaymentDetailsWindow.Show();
                this.Hide();
            }           

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            TransactionWindow openTransactionWindow = new TransactionWindow();
            openTransactionWindow.Show();
            this.Close();
        }
    }
}
