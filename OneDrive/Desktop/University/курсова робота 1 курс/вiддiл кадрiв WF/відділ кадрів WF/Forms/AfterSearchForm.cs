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
    public partial class AfterSearchForm : Form
    {
        private Worker _worker;
        private ResouresDepartament _resoursesDepartament;
        public AfterSearchForm(ResouresDepartament resouresDepartament, Worker worker)
        {
            InitializeComponent();
            _resoursesDepartament = resouresDepartament;
            _worker = worker;
            WorkerLabel.Text = worker.ToString();
        }

        public void FireButton_Click(object sender, EventArgs e)
        {
            _resoursesDepartament.DeleteWorker(_worker);
            DialogResult = DialogResult.OK;
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            EditAfterSearchForm EditAfterSearchForm = new EditAfterSearchForm(_resoursesDepartament, _worker);
            EditAfterSearchForm.ShowDialog();
        }
    }
}
