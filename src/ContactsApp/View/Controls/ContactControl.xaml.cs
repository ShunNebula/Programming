using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        #region Конструктор

        public ContactControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Обработчики событий

        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string newText = (sender as TextBox).Text + e.Text;
            Regex regex = new Regex("[^0-9+\\-\\(\\)\\s]+");
            e.Handled = regex.IsMatch(e.Text) || newText.Length > 100;
        }

        private void PhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (!string.IsNullOrEmpty(text))
                {
                    string newText = (sender as TextBox).Text + text;
                    Regex regex = new Regex("[^0-9+\\-\\(\\)\\s]+");
                    if (regex.IsMatch(text) || newText.Length > 100)
                    {
                        e.CancelCommand();
                    }
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        #endregion
    }
}