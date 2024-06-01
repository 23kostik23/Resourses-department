using System.Windows.Forms;

namespace відділ_кадрів_WF
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SearchListBox = new ListBox();
            EducationInput = new ComboBox();
            EducationLabel = new Label();
            DivisionInput = new ComboBox();
            DivisionLabel = new Label();
            PositionInput = new ComboBox();
            PositionLabel = new Label();
            SexInput = new ComboBox();
            SexLabel = new Label();
            SalaryInput = new TextBox();
            SalaryLabel = new Label();
            AgeInput = new TextBox();
            AgeLabel = new Label();
            SurnameInput = new TextBox();
            SurnameLabel = new Label();
            NameInput = new TextBox();
            NameLabel = new Label();
            OkButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // SearchListBox
            // 
            SearchListBox.FormattingEnabled = true;
            SearchListBox.HorizontalScrollbar = true;
            SearchListBox.Location = new Point(12, 52);
            SearchListBox.Name = "SearchListBox";
            SearchListBox.Size = new Size(394, 384);
            SearchListBox.TabIndex = 13;
            SearchListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // EducationInput
            // 
            EducationInput.FormattingEnabled = true;
            EducationInput.Items.AddRange(new object[] { "BA", "MA", "PhD" });
            EducationInput.Location = new Point(642, 187);
            EducationInput.Name = "EducationInput";
            EducationInput.Size = new Size(151, 28);
            EducationInput.TabIndex = 29;
            // 
            // EducationLabel
            // 
            EducationLabel.AutoSize = true;
            EducationLabel.Location = new Point(680, 164);
            EducationLabel.Name = "EducationLabel";
            EducationLabel.Size = new Size(75, 20);
            EducationLabel.TabIndex = 32;
            EducationLabel.Text = "Education";
            // 
            // DivisionInput
            // 
            DivisionInput.FormattingEnabled = true;
            DivisionInput.Items.AddRange(new object[] { "div1", "div2", "div3", "div4" });
            DivisionInput.Location = new Point(643, 279);
            DivisionInput.Name = "DivisionInput";
            DivisionInput.Size = new Size(151, 28);
            DivisionInput.TabIndex = 33;
            // 
            // DivisionLabel
            // 
            DivisionLabel.AutoSize = true;
            DivisionLabel.Location = new Point(688, 256);
            DivisionLabel.Name = "DivisionLabel";
            DivisionLabel.Size = new Size(62, 20);
            DivisionLabel.TabIndex = 30;
            DivisionLabel.Text = "Division";
            // 
            // PositionInput
            // 
            PositionInput.FormattingEnabled = true;
            PositionInput.Items.AddRange(new object[] { "Ceo", "Manager", "Office", "Security", "Cleaner" });
            PositionInput.Location = new Point(434, 279);
            PositionInput.Name = "PositionInput";
            PositionInput.Size = new Size(151, 28);
            PositionInput.TabIndex = 31;
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new Point(479, 256);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(61, 20);
            PositionLabel.TabIndex = 28;
            PositionLabel.Text = "Position";
            // 
            // SexInput
            // 
            SexInput.FormattingEnabled = true;
            SexInput.Items.AddRange(new object[] { "Male", "Female" });
            SexInput.Location = new Point(434, 187);
            SexInput.Name = "SexInput";
            SexInput.Size = new Size(151, 28);
            SexInput.TabIndex = 27;
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(496, 164);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(32, 20);
            SexLabel.TabIndex = 26;
            SexLabel.Text = "Sex";
            // 
            // SalaryInput
            // 
            SalaryInput.Location = new Point(662, 112);
            SalaryInput.Name = "SalaryInput";
            SalaryInput.Size = new Size(125, 27);
            SalaryInput.TabIndex = 25;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(688, 89);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(77, 20);
            SalaryLabel.TabIndex = 24;
            SalaryLabel.Text = "Salary(0+)";
            // 
            // AgeInput
            // 
            AgeInput.Location = new Point(443, 112);
            AgeInput.Name = "AgeInput";
            AgeInput.Size = new Size(125, 27);
            AgeInput.TabIndex = 23;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(467, 89);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(92, 20);
            AgeLabel.TabIndex = 22;
            AgeLabel.Text = "Age(18 - 80)";
            // 
            // SurnameInput
            // 
            SurnameInput.Location = new Point(662, 45);
            SurnameInput.Name = "SurnameInput";
            SurnameInput.Size = new Size(125, 27);
            SurnameInput.TabIndex = 21;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(688, 22);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(67, 20);
            SurnameLabel.TabIndex = 20;
            SurnameLabel.Text = "Surname";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(443, 45);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(125, 27);
            NameInput.TabIndex = 19;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(479, 22);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 18;
            NameLabel.Text = "Name";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(434, 388);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(340, 48);
            OkButton.TabIndex = 35;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(425, 358);
            label1.Name = "label1";
            label1.Size = new Size(362, 27);
            label1.TabIndex = 34;
            label1.Text = "Залиште ті поля пустими, які не хочете змінювати";
            // 
            // label2
            // 
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(394, 45);
            label2.TabIndex = 35;
            label2.Text = "Спочатку оберіть робітника зі списку зліва, потім міняйте його параметри справа";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EducationInput);
            Controls.Add(EducationLabel);
            Controls.Add(DivisionInput);
            Controls.Add(DivisionLabel);
            Controls.Add(PositionInput);
            Controls.Add(PositionLabel);
            Controls.Add(SexInput);
            Controls.Add(SexLabel);
            Controls.Add(SalaryInput);
            Controls.Add(SalaryLabel);
            Controls.Add(AgeInput);
            Controls.Add(AgeLabel);
            Controls.Add(SurnameInput);
            Controls.Add(SurnameLabel);
            Controls.Add(NameInput);
            Controls.Add(NameLabel);
            Controls.Add(OkButton);
            Controls.Add(SearchListBox);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void OkButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox SearchListBox;
        private ComboBox EducationInput;
        private Label EducationLabel;
        private ComboBox DivisionInput;
        private Label DivisionLabel;
        private ComboBox PositionInput;
        private Label PositionLabel;
        private ComboBox SexInput;
        private Label SexLabel;
        private TextBox SalaryInput;
        private Label SalaryLabel;
        private TextBox AgeInput;
        private Label AgeLabel;
        private TextBox SurnameInput;
        private Label SurnameLabel;
        private TextBox NameInput;
        private Label NameLabel;
        private Button OkButton;
        private Label label1;
        private Label label2;
    }
}