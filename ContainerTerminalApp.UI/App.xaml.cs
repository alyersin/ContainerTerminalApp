using ContainerTerminalApp.UI.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ContainerTerminalApp.UI;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    //OVERRIDE LOGIN METHOD GO DEVELOPER MODE
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var mainWindow = new MainWindow();
        mainWindow.Show();

        var loginWindow = new LoginWindow();
        loginWindow.Hide();

    }
}

