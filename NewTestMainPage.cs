using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ExampleDataBinding
{
    public class NewTestMainPage : ContentPage
    {
        private Guid mainPageID = Guid.NewGuid();
        public Guid MainPageID
        {
            get => mainPageID;
            set => mainPageID = value;
        }

        public NewTestMainPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label() { Text = MainPageID.ToString() },
                    new TestContentView() { ArbitraryGuid = MainPageID.ToString() }
                }
            };
        }
    }
}