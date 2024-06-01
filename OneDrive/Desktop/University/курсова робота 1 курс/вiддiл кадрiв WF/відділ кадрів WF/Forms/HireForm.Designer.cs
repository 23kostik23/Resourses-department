namespace відділ_кадрів_WF
{
    partial class HireForm
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
            OkButton = new Button();
            NameLabel = new Label();
            NameInput = new TextBox();
            SurnameInput = new TextBox();
            SurnameLabel = new Label();
            AgeInput = new TextBox();
            AgeLabel = new Label();
            SalaryInput = new TextBox();
            SalaryLabel = new Label();
            SexLabel = new Label();
            SexInput = new ComboBox();
            PositionLabel = new Label();
            PositionInput = new ComboBox();
            DivisionLabel = new Label();
            DivisionInput = new ComboBox();
            EducationInput = new ComboBox();
            EducationLabel = new Label();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(694, 409);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 0;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(114, 32);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(78, 55);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(125, 27);
            NameInput.TabIndex = 2;
            // 
            // SurnameInput
            // 
            SurnameInput.Location = new Point(342, 55);
            SurnameInput.Name = "SurnameInput";
            SurnameInput.Size = new Size(125, 27);
            SurnameInput.TabIndex = 4;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(369, 32);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(67, 20);
            SurnameLabel.TabIndex = 3;
            SurnameLabel.Text = "Surname";
            // 
            // AgeInput
            // 
            AgeInput.Location = new Point(608, 55);
            AgeInput.Name = "AgeInput";
            AgeInput.Size = new Size(125, 27);
            AgeInput.TabIndex = 6;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(632, 32);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(92, 20);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Age(18 - 80)";
            // 
            // SalaryInput
            // 
            SalaryInput.Location = new Point(78, 174);
            SalaryInput.Name = "SalaryInput";
            SalaryInput.Size = new Size(125, 27);
            SalaryInput.TabIndex = 8;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(102, 151);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(77, 20);
            SalaryLabel.TabIndex = 7;
            SalaryLabel.Text = "Salary(0+)";
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(384, 151);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(32, 20);
            SexLabel.TabIndex = 9;
            SexLabel.Text = "Sex";
            // 
            // SexInput
            // 
            SexInput.FormattingEnabled = true;
            SexInput.Items.AddRange(new object[] { "Male", "Female" });
            SexInput.Location = new Point(329, 174);
            SexInput.Name = "SexInput";
            SexInput.Size = new Size(151, 28);
            SexInput.TabIndex = 10;
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new Point(233, 266);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(61, 20);
            PositionLabel.TabIndex = 11;
            PositionLabel.Text = "Position";
            // 
            // PositionInput
            // 
            PositionInput.FormattingEnabled = true;
            PositionInput.Items.AddRange(new object[] { "Ceo", "Manager", "Office", "Security", "Cleaner" });
            PositionInput.Location = new Point(192, 288);
            PositionInput.Name = "PositionInput";
            PositionInput.Size = new Size(151, 28);
            PositionInput.TabIndex = 14;
            // 
            // DivisionLabel
            // 
            DivisionLabel.AutoSize = true;
            DivisionLabel.Location = new Point(512, 266);
            DivisionLabel.Name = "DivisionLabel";
            DivisionLabel.Size = new Size(62, 20);
            DivisionLabel.TabIndex = 13;
            DivisionLabel.Text = "Division";
            // 
            // DivisionInput
            // 
            DivisionInput.FormattingEnabled = true;
            DivisionInput.Items.AddRange(new object[] { "div1", "div2", "div3", "div4" });
            DivisionInput.Location = new Point(467, 289);
            DivisionInput.Name = "DivisionInput";
            DivisionInput.Size = new Size(151, 28);
            DivisionInput.TabIndex = 16;
            // 
            // EducationInput
            // 
            EducationInput.FormattingEnabled = true;
            EducationInput.Items.AddRange(new object[] { "BA", "MA", "PhD" });
            EducationInput.Location = new Point(594, 174);
            EducationInput.Name = "EducationInput";
            EducationInput.Size = new Size(151, 28);
            EducationInput.TabIndex = 12;
            // 
            // EducationLabel
            // 
            EducationLabel.AutoSize = true;
            EducationLabel.Location = new Point(632, 151);
            EducationLabel.Name = "EducationLabel";
            EducationLabel.Size = new Size(75, 20);
            EducationLabel.TabIndex = 15;
            EducationLabel.Text = "Education";
            // 
            // HireForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "HireForm";
            Text = "HireForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Label NameLabel;
        private TextBox NameInput;
        private TextBox SurnameInput;
        private Label SurnameLabel;
        private TextBox AgeInput;
        private Label AgeLabel;
        private TextBox SalaryInput;
        private Label SalaryLabel;
        private Label SexLabel;
        private ComboBox SexInput;
        private TextBox textBox1;
        private Label PositionLabel;
        private ComboBox PositionInput;
        private Label DivisionLabel;
        private ComboBox DivisionInput;
        private ComboBox EducationInput;
        private Label EducationLabel;
    }
}