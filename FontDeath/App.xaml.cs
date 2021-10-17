using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace FontDeath
{
    sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            if (Window.Current.Content is null)
                Window.Current.Content = new MainPage();

            Window.Current.Activate();
        }
    }
}
