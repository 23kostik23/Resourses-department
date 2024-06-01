using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using відділ_кадрів_WF.Models;

namespace відділ_кадрів_WF
{
    public partial class FireForm : Form
    {
        private ResouresDepartament _resouresDepartament;
        public FireForm(ResouresDepartament resouresDepartament)
        {
            InitializeComponent();
            _resouresDepartament = resouresDepartament;
            listBox1.Items.AddRange(_resouresDepartament.GetWorkersInList().ToArray());
        }
        public void OkButton_Click(object sender, EventArgs e)
        {
            string workerName = NameInput.Text.Trim();
            string workerSurname = SurnameInput.Text.Trim();
            int workerAge;
            try
            {
                workerAge = Convert.ToInt32(AgeInput.Text.Trim());
                if (workerAge < 0) workerAge *= -1;
                else if (workerAge > 0 && workerAge < 18) workerAge = 18;
                else if (workerAge > 80) workerAge = 80; //Нехай у нащій програмі найбільшим віком прийняття на роботу буде 80 років
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid Age input, \r\n{ex}");
                AgeInput.Text = "0";
                workerAge = 0;
            }
            string workerSex = SexInput.Text.Trim();
            int workerSalary;
            try
            {
                workerSalary = Convert.ToInt32(SalaryInput.Text.Trim());
                if (workerSalary < 0) workerSalary *= -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid Salary input, \r\n{ex}");
                SalaryInput.Text = "0";
                workerSalary = 0;
            }
            string workerEducation = EducationInput.Text.Trim();
            string workerPosition = PositionInput.Text.Trim();
            string workerDivision = DivisionInput.Text.Trim();
            Worker worker = new Worker(workerName, workerSurname, workerAge, workerSalary, workerSex, workerEducation, workerPosition, workerDivision);
            _resouresDepartament.DeleteWorker(worker);
            DialogResult = DialogResult.OK;
        }
        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                var selectedItem = listBox1.Items[index];
                _resouresDepartament.DeleteWorkerWithDateTime(listBox1.SelectedItem as Worker);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
