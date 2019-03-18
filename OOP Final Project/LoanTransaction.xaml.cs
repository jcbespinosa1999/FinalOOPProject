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
    /// Interaction logic for LoanTransaction.xaml
    /// </summary>
    public partial class LoanTransaction : Window
    {  
        public LoanTransaction()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            foreach (string item in DataStorage.customerList)
            {
                cmbNameList.Items.Add(item);
            }
        }

        private void CalculationLogic()
        {
            decimal weight;
            decimal discount;

            switch (cmbJewelryQuality.Text)
            {
                case "10k":
                    if (txtbWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtbWeight.Text);

                    if (txtbDiscount.Text == "")
                        discount = 0;

                    else
                        discount = Convert.ToDecimal(txtbDiscount.Text)/100;

                    actualValueText.Text = Convert.ToString(DataStorage.priceList[0] * weight - (DataStorage.priceList[0] * weight * discount));
                    break;

                case "18k":
                    if (txtbWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtbWeight.Text);

                    if (txtbDiscount.Text == "")
                        discount = 0;

                    else
                        discount = Convert.ToDecimal(txtbDiscount.Text) / 100;

                    actualValueText.Text = Convert.ToString(DataStorage.priceList[1] * weight - (DataStorage.priceList[1] * weight * discount));
                    break;

                case "21k":
                    if (txtbWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtbWeight.Text);

                    if (txtbDiscount.Text == "")
                        discount = 0;
                    else
                        discount = Convert.ToDecimal(txtbDiscount.Text) / 100;

                    actualValueText.Text = Convert.ToString(DataStorage.priceList[2] * weight - (DataStorage.priceList[2] * weight * discount));
                    break;
            }


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void WeightTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculationLogic();
        }

        private void txtDiscount_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculationLogic();
        }

        private void cmbJewelryQuality_DropDownClosed(object sender, EventArgs e)
        {
            CalculationLogic();
        }

        private void txtJewelryType_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void addNameButton_Click(object sender, RoutedEventArgs e)
        {
            AddNameWindow openAddNameWindow = new AddNameWindow();
            openAddNameWindow.ShowDialog();
            cmbNameList.Items.Clear();
            foreach (string item in DataStorage.customerList)
            {
                cmbNameList.Items.Add(item);
            } 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int codeListSize = DataStorage.pinEightDigits.Count - 1;
            int counter = 0;
            Random pin = new Random();
            int randomPin = pin.Next(10000000, 99999999);       
            if (counter >= 1)
            {
                if (randomPin == DataStorage.pinEightDigits[counter])
                    randomPin = pin.Next(10000000, 99999999);
            }
            counter++;
          
            DataStorage.pinEightDigits.Add(randomPin);
            DataStorage.typeOfJewelry.Add(txtJewelryType.Text);
            DataStorage.weightOfJewelry.Add(txtbWeight.Text);
            DataStorage.discount.Add(Convert.ToInt32(txtbDiscount.Text));
            DataStorage.amountLoaned.Add(Convert.ToDecimal(txtbAmountLoaned.Text));
            DataStorage.actualValue.Add(Convert.ToDecimal(actualValueText.Text));
            DataStorage.qualityOfJewelry.Add(cmbJewelryQuality.Text);
            DataStorage.dateOfTransaction.Add(txtDate.Text);
            DataStorage.details.Add(txtbDetails.Text);
            MessageBox.Show("Your eight digit pin is: " + Convert.ToString(randomPin));
            this.Close();
            App.Current.MainWindow.Show();
            this.Hide();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            TransactionWindow openTransactionWindow = new TransactionWindow();
            openTransactionWindow.Show();
            this.Close();
        }
    }
    
}
