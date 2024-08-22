using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer
{
    public partial class AppShell : Shell
    {
        public MainModel MainModel { get; set; }
        public AppShell()
        {
            InitializeComponent();
            MainModel = new MainModel();
            BindingContext = MainModel;
        }
    }
}
