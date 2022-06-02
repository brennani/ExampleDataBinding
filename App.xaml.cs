using Xamarin.Forms;

namespace ExampleDataBinding
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new TestMainPage();

            // the codebehind solution is NewTestMainPage
            //MainPage = new NewTestMainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
