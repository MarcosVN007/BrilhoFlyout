using Microsoft.UI.Xaml;
using monitorcontrol;
using System.Linq;

namespace BrilhoFlyout;

public sealed partial class BrilhoFlyout : Window
{
    public BrilhoFlyout()
    {
        InitializeComponent();

        var display = Microsoft.UI.Windowing.DisplayArea.Primary;
        this.MoveAndResize(
            display.WorkArea.Width - 340,
            display.WorkArea.Height - 140,
            320,
            90
        );

        using var mon = MonitorControl.GetMonitors().First();
        SliderBrilho.Value = mon.GetLuminance();

        SliderBrilho.ValueChanged += (_, e) =>
        {
            using var m = MonitorControl.GetMonitors().First();
            m.SetLuminance((int)e.NewValue);
        };
    }
}