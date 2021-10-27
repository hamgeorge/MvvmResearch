using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ExpanderSearch
{
    public class LevelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ImageSource imageSource = new BitmapImage(new Uri("pack://application:,,,/ExpanderSearch;component/images/normal.png"));
            int n = 0; //(int)value;
            switch (n)
            {
                case 1:
                    imageSource = new BitmapImage(new Uri("/Images/warning.png", UriKind.Relative));
                    break;
                case 2:
                    imageSource = new BitmapImage(new Uri("/Images/error.png", UriKind.Relative));
                    break;
                case 0:
                default:
                    break;
            }
            return imageSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
