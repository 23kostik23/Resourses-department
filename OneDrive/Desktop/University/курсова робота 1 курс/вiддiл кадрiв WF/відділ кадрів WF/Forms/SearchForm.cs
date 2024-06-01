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
    public partial class SearchForm : Form
    {
        private ResouresDepartament _resouresDepartament;
        private List<Worker> _searchListBoxWorkers;

        public SearchForm(ResouresDepartament resouresDepartament)
        {
            InitializeComponent();
            _resouresDepartament = resouresDepartament;
            SearchListBox.Items.AddRange(_resouresDepartament.GetWorkersInList().ToArray());
            SearchTextBox.Text = "Спочатку введіть параметри для пошуку робітників";
        }
        public void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void SearchListBox_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            int index = SearchListBox.SelectedIndex;
            if (index != -1)
            {
                var selectedItem = SearchListBox.Items[index];
                AfterSearchForm AfterSearchForm = new AfterSearchForm(_resouresDepartament, SearchListBox.SelectedItem as Worker);
                AfterSearchForm.ShowDialog();
            }
        }

        private string _selectedEducation;
        private void EducationInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EducationInput.SelectedIndex != -1)
            {
                _selectedEducation = EducationInput.SelectedItem.ToString();
                UpdateSearchResults();
            }
        }

        private string _selectedSex;
        private void SexInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SexInput.SelectedIndex != -1)
            {
                _selectedSex = SexInput.SelectedItem.ToString();
                UpdateSearchResults();
            }
        }

        private string _selectedPosition;
        private void PositionInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPosition = PositionInput.SelectedItem.ToString();
            UpdateSearchResults();
        }

        private string _selectedDivision;
        private void DivisionInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedDivision = DivisionInput.SelectedItem.ToString();
            UpdateSearchResults();
        }

        private void UpdateSearchResults()
        {
            StringBuilder searchResult = new StringBuilder();
            List<Worker> filteredWorkers = _resouresDepartament.GetWorkersInList();

            if (!string.IsNullOrEmpty(_selectedEducation))
            {
                if (_selectedEducation == "ELSE")
                {
                    List<string> excludedEducation = new List<string> { "BA", "MA", "PhD" };
                    filteredWorkers = filteredWorkers.Where(worker => !excludedEducation.Contains(worker.Education)).ToList();
                }
                else filteredWorkers = filteredWorkers.Where(worker => worker.Education == _selectedEducation).ToList();
            }

            if (!string.IsNullOrEmpty(_selectedSex))
            {
                if(_selectedSex == "ELSE")
                {
                    List<string> excludedSex = new List<string> { "Male", "Female" };
                    filteredWorkers = filteredWorkers.Where(worker => !excludedSex.Contains(worker.Sex)).ToList();
                }
                else filteredWorkers = filteredWorkers.Where(worker => worker.Sex == _selectedSex).ToList();
            }

            if (!string.IsNullOrEmpty(_selectedPosition))
            {
                if(_selectedPosition == "ELSE")
                {
                    List<string> excludedPositions = new List<string> { "Ceo", "Manager", "Office", "Security", "Cleaner" };
                    filteredWorkers = filteredWorkers.Where(worker => !excludedPositions.Contains(worker.Position)).ToList();
                }
                else filteredWorkers = filteredWorkers.Where(worker => worker.Position == _selectedPosition).ToList();
            }

            if (!string.IsNullOrEmpty(_selectedDivision))
            {
                if(_selectedDivision == "ELSE")
                {
                    List<string> excludedDivisions = new List<string> { "div1", "div2", "div3", "div4" };
                    filteredWorkers = filteredWorkers.Where(worker => !excludedDivisions.Contains(worker.Division)).ToList();
                }
                else filteredWorkers = filteredWorkers.Where(worker => worker.Division == _selectedDivision).ToList();
            }

            foreach (var worker in filteredWorkers)
            {
                searchResult.AppendLine(worker.ToString() + "\r\n");
            }

            _searchListBoxWorkers = filteredWorkers;
            SearchTextBox.Text = searchResult.ToString();
        }
    }
}
