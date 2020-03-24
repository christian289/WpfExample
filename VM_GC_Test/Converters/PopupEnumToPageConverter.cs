using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using VM_GC_Test.Common;

namespace VM_GC_Test.Converters
{
    public class PopupEnumToPageConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            if (value is Enum && ((int)value) > 0)
            {
                string page = ((Enum)value).GetEnumAttributeValue<string>(0);

                if (parameter != null)
                {
                    page += $"?parameter={parameter}";
                }

                Uri uri = new Uri(page, UriKind.Relative);
                return uri.ToString();
            }

            return null;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
