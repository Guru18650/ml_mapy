namespace ml_mapy
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF5cWWJCf0x3TXxbf1x0ZFZMZF9bQXBPIiBoS35RckViWH5fdXBWQ2ZeU0N2");
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}