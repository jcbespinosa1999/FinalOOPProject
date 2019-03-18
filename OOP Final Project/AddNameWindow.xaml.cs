﻿using System;
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
using OOP_Project.Person;

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddNameWindow : Window
    {
        public AddNameWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameFirst.Text != "" || txtNameMiddle.Text != "" || txtNameLast.Text != "")
            {
                bool exist = false;
                PersonClass GetName = new PersonClass(txtNameFirst.Text, txtNameLast.Text, txtNameMiddle.Text);

                foreach (string name in DataStorage.customerList)
                {
                    if (name == GetName.GetFullName())
                    {
                        MessageBox.Show("Error! Name already exists in database!");
                        exist = true;
                    }
                }
                if (!exist)
                {
                    DataStorage.customerList.Add(GetName.GetFullName());
                    int size = DataStorage.customerList.Count - 1;
                    DataStorage.address.Insert(size, txtAddress.Text);
                    DataStorage.contactNumber.Insert(size, txtContactNumber.Text);
                    this.Close();
                }
            }
            this.Close();
        }

        private void txtNameFirst_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
