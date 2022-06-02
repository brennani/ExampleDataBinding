using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ExampleDataBinding
{
    // this is made a static resource in the App.xaml, line 31
    public class GuidToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Guid guid)
                return guid.ToString();
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string toGuid)
            {
                if (Guid.TryParse(toGuid, out Guid result))
                {
                    return result;
                }
            }

            return null;
        }
    }
}
