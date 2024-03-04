using System.Windows;



namespace Medical_Office
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var form = new SplashForm();
            form.Show();
        }
    }
}
