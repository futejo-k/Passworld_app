using System.Windows;
using System.Windows.Controls;

namespace Passworld_app;

public partial class NewPwd : Window
{
    public NewPwd()
    {
        InitializeComponent();
    }
    
    private void Back_OnClick(object sender, RoutedEventArgs e)
    {
        this.Hide();
        (new Homepage()).Show();
        this.Close();
    }
}