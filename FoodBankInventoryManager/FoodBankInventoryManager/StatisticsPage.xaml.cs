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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodBankInventoryManager
{
    /// <summary>
    /// Interaction logic for StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        public StatisticsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            L2S_FoodBankDBDataContext dbContext = new L2S_FoodBankDBDataContext();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPage.isAnAdministrator==true)
            {
                HomePage h = new HomePage(true);
                LoginPage.isAnAdministrator = true;
                this.NavigationService.Navigate(h);
            }
            else
            {
                HomePage h = new HomePage(false);
                LoginPage.isAnAdministrator = false;
                this.NavigationService.Navigate(h);
            }
        }
    }
}
