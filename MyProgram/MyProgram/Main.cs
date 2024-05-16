using MyProgram.Model;
using MyProgram.Resourses;
using System.Drawing;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;

namespace MyProgram
{
    public partial class Main : Form
    {
        private static List<MyInstitution> _institution = new List<MyInstitution>();
        private static MyInstitution _currentInstitution;

        public Main()
        {
            InitializeComponent();

            this.ComboBoxCategory.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }

        private List<MyInstitution> GetRandomInstitution(int size)
        {
            List<MyInstitution> MyInstitutions = new List<MyInstitution>(size);
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                MyInstitution newInstitution = new MyInstitution();
                newInstitution.Title = Enum.GetNames(typeof(Title)).Cast<string>().ToArray()[ran.Next(0, 10)];
                newInstitution.Address = Enum.GetNames(typeof(Address)).Cast<string>().ToArray()[ran.Next(0, 7)] + "_" + ran.Next(13, 130);
                newInstitution.Category = Enum.GetNames(typeof(Category)).Cast<string>().ToArray()[ran.Next(0, 7)];
                newInstitution.Rating = ran.NextDouble() + ran.Next(0, 5);
                MyInstitutions.Add(newInstitution);

            }
            return MyInstitutions;
        }

        private void ListBoxInstitution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxInstitution.SelectedIndex < 0)
            {
                TextBoxTitle.Enabled = false;
                TextBoxAddress.Enabled = false;
                ComboBoxCategory.Enabled = false;
                TextBoxRating.Enabled = false;

                TextBoxTitle.Clear();
                TextBoxAddress.Clear();
                ComboBoxCategory.SelectedIndex = -1;
                TextBoxRating.Clear();
            }
            else
            {
                TextBoxTitle.Enabled = true;
                TextBoxAddress.Enabled = true;
                ComboBoxCategory.Enabled = true;
                TextBoxRating.Enabled = true;

                _currentInstitution = _institution[ListBoxInstitution.SelectedIndex];

                TextBoxTitle.Text = _currentInstitution.Title;
                TextBoxAddress.Text = _currentInstitution.Address;
                ComboBoxCategory.Text = _currentInstitution.Category;
                TextBoxRating.Text = _currentInstitution.Rating.ToString();
            }
        }

        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxTitle.Text) || TextBoxTitle.Text.Count() > 200)
            {
                ButtonChange.Enabled = false;
                return;
            }
            ButtonChange.Enabled = true;
        }

        private void ChangeTextElemListBoxInstitution()
        {
            ListBoxInstitution.Items[ListBoxInstitution.SelectedIndex] = _institution[ListBoxInstitution.SelectedIndex].Address +
                " --> " + _institution[ListBoxInstitution.SelectedIndex].Title;
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            _currentInstitution.Title = TextBoxTitle.Text;
            _currentInstitution.Address = TextBoxAddress.Text;
            _currentInstitution.Category = ComboBoxCategory.Text;
            _currentInstitution.Rating = double.Parse(TextBoxRating.Text);
            ChangeTextElemListBoxInstitution();
            ListBoxInstitution.Sorted = true;

            _institution = Write(_institution);
        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxAddress.Text) || TextBoxAddress.Text.Count() > 100)
            {
                ButtonChange.Enabled = false;
                return;
            }
            ButtonChange.Enabled = true;
        }

        private void TextBoxRating_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxRating.Text))
            {
                TextBoxRating.BackColor = AppColors.trueText;
                ButtonChange.Enabled = false;
                return;
            }
            if (!double.TryParse(TextBoxRating.Text, out double rating) || double.Parse(TextBoxRating.Text) < 0 || double.Parse(TextBoxRating.Text) > 5)
            {
                TextBoxRating.BackColor = AppColors.falseText;
                ButtonChange.Enabled = false;
                return;
            }
            TextBoxRating.BackColor = AppColors.trueText;
            ButtonChange.Enabled = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            MyInstitution newInstitution = GetRandomInstitution(1)[0];
            _institution.Add(newInstitution);

            _institution = Write(_institution);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxInstitution.SelectedIndex < 0) return;
            _institution.RemoveAt(ListBoxInstitution.SelectedIndex);
            ListBoxInstitution.Items.RemoveAt(ListBoxInstitution.SelectedIndex);

            _institution = Write(_institution);
        }

        private List<MyInstitution> Write(List<MyInstitution> list)
        {
            ListBoxInstitution.Items.Clear();
            list = list.OrderBy(s => s.Address).ThenBy(s => s.Title).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                ListBoxInstitution.Items.Add($"{list[i].Address} --> {list[i].Title}");
            }
            return list;
        }

        public void SaveData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";
            string data = JsonSerializer.Serialize(_institution);

            File.WriteAllText(path, data);
        }

        public void LoadData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";

            if (!File.Exists(path)) return;

            string data = File.ReadAllText(path);

            _institution = JsonSerializer.Deserialize<List<MyInstitution>>(data);

            _institution = Write(_institution);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}