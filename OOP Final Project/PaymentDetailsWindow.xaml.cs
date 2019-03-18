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
    /// Interaction logic for PaymentDetailsWindow.xaml
    /// </summary>
    public partial class PaymentDetailsWindow : Window
    {
        public PaymentDetailsWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            paymentName.Text = DataStorage.customerList[PaymentWindow.counter];
            paymentCarat.Text = DataStorage.qualityOfJewelry[PaymentWindow.counter];
            paymentJewelry.Text = DataStorage.typeOfJewelry[PaymentWindow.counter];
            paymentDisount.Text = Convert.ToString(DataStorage.discount[PaymentWindow.counter]);
            paymentBalance.Text = Convert.ToString(DataStorage.amountLoaned[PaymentWindow.counter]);
            paymentActualValue.Text = Convert.ToString(DataStorage.actualValue[PaymentWindow.counter]);
            paymentWeight.Text = DataStorage.weightOfJewelry[PaymentWindow.counter];
            paymentDate.Text = DataStorage.dateOfTransaction[PaymentWindow.counter];
            paymentDetails.Text = DataStorage.details[PaymentWindow.counter];
        }

        private void paymentButton_Click(object sender, RoutedEventArgs e)
        {
            DataStorage.amountLoaned[PaymentWindow.counter] = DataStorage.amountLoaned[PaymentWindow.counter] - Convert.ToDecimal(txtPayment.Text);
            if (DataStorage.amountLoaned[PaymentWindow.counter] <= 0)
            {
                MessageBox.Show("The loan is fully paid!");
                PaymentDetailsWindow openPaymentDetailsWindow = new PaymentDetailsWindow();
                openPaymentDetailsWindow.Show();
                this.Close();
            }
            else
            {
                PaymentDetailsWindow openPaymentDetailsWindow = new PaymentDetailsWindow();
                openPaymentDetailsWindow.Show();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            PaymentWindow openPaymentWindow = new PaymentWindow();
            openPaymentWindow.Show();
            this.Close();
        }
    }
}
