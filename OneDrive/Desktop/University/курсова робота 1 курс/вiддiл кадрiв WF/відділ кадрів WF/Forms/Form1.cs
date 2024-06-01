using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using відділ_кадрів_WF.Models;

namespace відділ_кадрів_WF
{
    public partial class Form1 : Form
    {
        private ResouresDepartament _resouresDepartament;
        public Form1()
        {
            InitializeComponent();
            _resouresDepartament = new ResouresDepartament();
            this.FormClosed += Form1_FormClosed;
        }

        private void HireButton_Click(object sender, EventArgs e)
        {
            HireForm HireForm = new HireForm(_resouresDepartament);
            DialogResult result = HireForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show($"Робтника було успішно найнято на роботу");
                textBox1.Text = _resouresDepartament.ToString();
            }
        }

        private void FireButton_Click( object sender, EventArgs e)
        {
            if (_resouresDepartament.Count() == 0)
            {
                MessageBox.Show($"Відділ Кадрів пустий");
                return;
            }
            FireForm FireForm = new FireForm(_resouresDepartament);
            DialogResult result = FireForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBox1.Text = _resouresDepartament.ToString();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _resouresDepartament.SaveToFile();
            MessageBox.Show($"Всі дані були збережені!");
        }

        private void LoadButton_Click(object sender, EventArgs e )
        {
            _resouresDepartament.LoadFromFile();
            MessageBox.Show($"Дані були успішно завантажені");
            textBox1.Text = _resouresDepartament.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(_resouresDepartament.Count() == 0)
            {
                MessageBox.Show("Відділ кадрів пустий!");
                return;
            }
            SearchForm SearchForm = new SearchForm(_resouresDepartament);
            DialogResult result = SearchForm.ShowDialog();
            textBox1.Text = _resouresDepartament.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_resouresDepartament.Count() == 0)
            {
                MessageBox.Show($"Відділ Кадрів пустий");
                return;
            }
            EditForm EditForm = new EditForm(_resouresDepartament);
            DialogResult result = EditForm.ShowDialog();
            textBox1.Text = _resouresDepartament.ToString();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Чи хочете ви зберегти дані перед закриттям програми?","Зберегти Дані",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _resouresDepartament.SaveToFile();
            }
        }
    }
}
