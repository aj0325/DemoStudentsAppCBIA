using DevExpress.Maui.Core;
using Microsoft.Maui.ApplicationModel;

namespace Demo.DemoCBIA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("SYNCFUSION_KEY");
            //Current.RequestedTheme = OSAppTheme.Light;
            MainPage = new AppShell();
        }
        //protected override void OnStart()
        //{
        //    base.OnStart();
        //    ThemeManager.Initialize();
        //}

    }
}