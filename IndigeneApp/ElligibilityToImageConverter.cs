using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace IndigeneApp
{
    public class ElligibilityToImageConverter : IValueConverter
    {
        private const String elligibilityImage = "Media\appbar.billing.png";
        private const String inelligibilityImage = "Media\appbar.base.select.png";
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            Boolean status = ((Boolean)value);
            return ((status == true) ? elligibilityImage : inelligibilityImage);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return null;
        }
    }
}
