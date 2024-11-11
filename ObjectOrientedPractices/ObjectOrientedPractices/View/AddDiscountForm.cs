using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.View
{
    public partial class AddDiscountForm : Form
    {
        public Category SelectedCategory { get; private set; }

        public AddDiscountForm()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SelectedCategory = (Category)CategoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
