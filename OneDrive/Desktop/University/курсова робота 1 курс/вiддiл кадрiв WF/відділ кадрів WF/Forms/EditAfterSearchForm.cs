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
    public partial class EditAfterSearchForm : Form
    {
        private ResouresDepartament _resoursesDepartament;
        private Worker _chosenWorkerBeforeChange;
        public EditAfterSearchForm(ResouresDepartament resouresDepartament, Worker worker)
        {
            InitializeComponent();
            _resoursesDepartament = resouresDepartament;
            _chosenWorkerBeforeChange = worker;
            WorkerLabel.Text = _chosenWorkerBeforeChange.ToString();
        }

        public void OkButton_Click(object sender, EventArgs e)
        {
            string workerAfterChangeName;
            string workerAfterChangeSurname;
            int workerAfterChangeAge;
            int workerAfterChangeSalary;
            string workerAfterChangeSex;
            string workerAfterChangeEducation;
            string workerAfterChangePosition;
            string workerAfterChangeDivision;
            if (_chosenWorkerBeforeChange != null)
            {
                if (!string.IsNullOrEmpty(NameInput.Text))
                {
                    workerAfterChangeName = NameInput.Text;
                }
                else workerAfterChangeName = _chosenWorkerBeforeChange.Name;
                if (!string.IsNullOrEmpty(SurnameInput.Text))
                {
                    workerAfterChangeSurname = SurnameInput.Text;
                }
                else workerAfterChangeSurname = _chosenWorkerBeforeChange.Surname;
                try
                {
                    workerAfterChangeAge = Convert.ToInt32(AgeInput.Text.Trim());
                    if (workerAfterChangeAge < 0) workerAfterChangeAge *= _chosenWorkerBeforeChange.Age;
                    else if (workerAfterChangeAge > 0 && workerAfterChangeAge < 18) workerAfterChangeAge = _chosenWorkerBeforeChange.Age;
                    else if (workerAfterChangeAge > 80) workerAfterChangeAge = _chosenWorkerBeforeChange.Age; //Нехай у нащій програмі найбільшим віком прийняття на роботу буде 80 років
                }
                catch (Exception ex)
                {
                    workerAfterChangeAge = _chosenWorkerBeforeChange.Age;
                }
                try
                {
                    workerAfterChangeSalary = Convert.ToInt32(SalaryInput.Text.Trim());
                    if (workerAfterChangeSalary < 0) workerAfterChangeSalary *= _chosenWorkerBeforeChange.Salary;
                }
                catch (Exception ex)
                {
                    workerAfterChangeSalary = _chosenWorkerBeforeChange.Salary;
                }
                if (!string.IsNullOrEmpty(EducationInput.Text))
                {
                    workerAfterChangeEducation = EducationInput.Text.Trim();
                }
                else workerAfterChangeEducation = _chosenWorkerBeforeChange.Education;
                if (!string.IsNullOrEmpty(SexInput.Text))
                {
                    workerAfterChangeSex = SexInput.Text.Trim();
                }
                else workerAfterChangeSex = _chosenWorkerBeforeChange.Sex;
                if (!string.IsNullOrEmpty(PositionInput.Text))
                {
                    workerAfterChangePosition = PositionInput.Text.Trim();
                }
                else workerAfterChangePosition = _chosenWorkerBeforeChange.Position;
                if (!string.IsNullOrEmpty(DivisionInput.Text))
                {
                    workerAfterChangeDivision = DivisionInput.Text.Trim();
                }
                else workerAfterChangeDivision = _chosenWorkerBeforeChange.Division;
                Worker workerAfterChange = new Worker(workerAfterChangeName, workerAfterChangeSurname, workerAfterChangeAge, workerAfterChangeSalary, workerAfterChangeSex, workerAfterChangeEducation, workerAfterChangePosition, workerAfterChangeDivision);
                _resoursesDepartament.EditWorker(_chosenWorkerBeforeChange, workerAfterChange);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
