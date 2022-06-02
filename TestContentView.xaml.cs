using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleDataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestContentView : ContentView
    {
        public static readonly BindableProperty ArbitraryGuidProperty = BindableProperty.Create(nameof(ArbitraryGuid),
                                                                                                typeof(string),
                                                                                                typeof(TestContentView),
                                                                                                null,
                                                                                                BindingMode.OneTime,
                                                                                                propertyChanged: ArbitraryGuidPropertyChanged);

        private static void ArbitraryGuidPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var currentTestContentView = bindable as TestContentView;
            currentTestContentView.UpdateViewModelGuid();
        }

        private void UpdateViewModelGuid()
        {
            if (Guid.TryParse(ArbitraryGuid, out var result))
                viewModel.Guid = result;
        }

        //public string arbitraryGuid
        public string ArbitraryGuid
        {
            get
            {

                // I have this here so I can check the value on a breakpoint before it returns
                var test = (string)GetValue(ArbitraryGuidProperty);

                return test;

            }
            set => SetValue(ArbitraryGuidProperty, value);
        }

        private TestContentViewModel viewModel;

        public TestContentView()
        {
            ArbitraryGuid = "Not Set";
            BindingContext = viewModel = new TestContentViewModel();

            InitializeComponent();

            //BindingContextChanged += TestContentView_BindingContextChanged;


        }

        //private void TestContentView_BindingContextChanged(object sender, EventArgs e)
        //{
        //    BindingContextChanged -= TestContentView_BindingContextChanged;
        //    if (BindingContext != viewModel)
        //        BindingContext = viewModel;
        //    BindingContextChanged += TestContentView_BindingContextChanged;
        //}
    }
}