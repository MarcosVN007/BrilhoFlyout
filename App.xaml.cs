using Microsoft.UI.Xaml;

namespace BrilhoFlyout;

public partial class App : Application
{
    public static TrayIcon Tray;

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        Tray = new TrayIcon();
        Tray.Init();
    }
}