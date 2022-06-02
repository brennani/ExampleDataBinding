using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleDataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestMainPage : ContentPage
    {
        private Guid mainPageID = Guid.NewGuid();
        public Guid MainPageID
        {
            get => mainPageID;
            set => mainPageID = value;
        }

        public TestMainPage()
        {
            BindingContext = this;
            InitializeComponent();

            

            //var layout = new StackLayout();

            //var label = new Label() { Text = MainPageID.ToString() };

            //var contentView = new TestContentView() { ArbitraryGuid = MainPageID.ToString() };

            //layout.Children.Add(label);
            //layout.Children.Add(contentView);

            //Content = layout;
        }

    }
}