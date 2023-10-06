using System.Windows;
using System.Windows.Controls;

namespace Passworld_app;

public partial class Homepage : Window
{
    public Homepage()
    {
        InitializeComponent();
    }
    public void YourGotFocusEvent(object sender, RoutedEventArgs e)
    {
            
    }
        
    private void NewPwd_OnClick(object sender, RoutedEventArgs e)
    {
        this.Hide();
        (new NewPwd()).Show();
        this.Close();
    }
}