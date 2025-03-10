using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace View.ViewModel
{
    /// <summary>
    /// Конвертер, преобразующий значение <see cref="bool"/> в <see cref="Visibility"/>.
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Преобразует значение <see cref="bool"/> в <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Преобразуемое значение типа <see cref="bool"/>.</param>
        /// <param name="targetType">Тип целевого свойства (не используется).</param>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        /// <param name="culture">Культура (не используется).</param>
        /// <returns><see cref="Visibility.Visible"/>, 
        /// если <paramref name="value"/> равно true, 
        /// иначе <see cref="Visibility.Collapsed"/>.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool boolValue = (bool)value;
            return boolValue ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Преобразует значение <see cref="Visibility"/> в <see cref="bool"/>.
        /// </summary>
        /// <param name="value">Преобразуемое значение типа <see cref="Visibility"/>.</param>
        /// <param name="targetType">Тип целевого свойства (не используется).</param>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        /// <param name="culture">Культура (не используется).</param>
        /// <returns><see cref="DependencyProperty.UnsetValue"/>, 
        /// так как обратное преобразование не поддерживается.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
