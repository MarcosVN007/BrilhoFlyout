using H.NotifyIcon;
using Microsoft.UI.Xaml.Controls;

namespace BrilhoFlyout;

public class TrayIcon
{
    private TaskbarIcon _tray;

    public void Init()
    {
        _tray = new TaskbarIcon
        {
            IconSource = "Assets/brightness.ico",
            ToolTipText = "Controle de brilho"
        };

        _tray.LeftClickCommand = new DelegateCommand(OpenFlyout);
    }

    private void OpenFlyout()
    {
        var fly = new BrilhoFlyout();
        fly.Show();
    }
}