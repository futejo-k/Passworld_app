using System.Windows;
using System.Windows.Controls;

namespace Passworld_app;

public partial class NewPwd : Page
{
    public NewPwd()
    {
        InitializeComponent();
    }
    
    private void Back_OnClick(object sender, RoutedEventArgs e)
    {
        Homepage homepage = new Homepage();
        this.Content = homepage.Content;
    }
}