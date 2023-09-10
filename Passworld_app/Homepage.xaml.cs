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

namespace Passworld_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        public Homepage()
        {
            InitializeComponent();
        }
        
        public void YourGotFocusEvent(object sender, RoutedEventArgs e)
        {
            SearchPassword.Text = string.Empty;
            SearchPassword.GotFocus -= YourGotFocusEvent;
            if (SearchPassword.IsFocused == false && string.IsNullOrWhiteSpace(SearchPassword.Text))
            {
                SearchPassword.Text = "Search Password";
            }
        }
        
        private void NewPwd_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}