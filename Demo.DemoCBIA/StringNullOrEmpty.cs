using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DemoCBIA
{
    public class StringNullOrEmpty : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string stringValue = value as string;

            // Check if the value is null or empty
            if (string.IsNullOrEmpty(stringValue))
            {
                return " ";
            }
            else if (stringValue.Equals("string", StringComparison.OrdinalIgnoreCase)) // Case-insensitive comparison
            {
                return " "; // Handle the case where the answer is "string"
            }
            else
            {
                return stringValue; // Handle other non-empty values
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

    
}
