namespace відділ_кадрів_WF
{
    partial class EditAfterSearchForm
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
            WorkerLabel = new Label();
            label1 = new Label();
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
            SuspendLayout();
            // 
            // WorkerLabel
            // 
            WorkerLabel.AllowDrop = true;
            WorkerLabel.AutoSize = true;
            WorkerLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WorkerLabel.Location = new Point(12, 22);
            WorkerLabel.MaximumSize = new Size(350, 400);
            WorkerLabel.Name = "WorkerLabel";
            WorkerLabel.Size = new Size(91, 38);
            WorkerLabel.TabIndex = 1;
            WorkerLabel.Text = "label1";
            // 
            // label1
            // 
            label1.Location = new Point(413, 358);
            label1.Name = "label1";
            label1.Size = new Size(362, 27);
            label1.TabIndex = 52;
            label1.Text = "Залиште ті поля пустими, які не хочете змінювати";
            // 
            // EducationInput
            // 
            EducationInput.FormattingEnabled = true;
            EducationInput.Items.AddRange(new object[] { "BA", "MA", "PhD" });
            EducationInput.Location = new Point(630, 187);
            EducationInput.Name = "EducationInput";
            EducationInput.Size = new Size(151, 28);
            EducationInput.TabIndex = 47;
            // 
            // EducationLabel
            // 
            EducationLabel.AutoSize = true;
            EducationLabel.Location = new Point(668, 164);
            EducationLabel.Name = "EducationLabel";
            EducationLabel.Size = new Size(75, 20);
            EducationLabel.TabIndex = 50;
            EducationLabel.Text = "Education";
            // 
            // DivisionInput
            // 
            DivisionInput.FormattingEnabled = true;
            DivisionInput.Items.AddRange(new object[] { "div1", "div2", "div3", "div4" });
            DivisionInput.Location = new Point(631, 279);
            DivisionInput.Name = "DivisionInput";
            DivisionInput.Size = new Size(151, 28);
            DivisionInput.TabIndex = 51;
            // 
            // DivisionLabel
            // 
            DivisionLabel.AutoSize = true;
            DivisionLabel.Location = new Point(676, 256);
            DivisionLabel.Name = "DivisionLabel";
            DivisionLabel.Size = new Size(62, 20);
            DivisionLabel.TabIndex = 48;
            DivisionLabel.Text = "Division";
            // 
            // PositionInput
            // 
            PositionInput.FormattingEnabled = true;
            PositionInput.Items.AddRange(new object[] { "Ceo", "Manager", "Office", "Security", "Cleaner" });
            PositionInput.Location = new Point(422, 279);
            PositionInput.Name = "PositionInput";
            PositionInput.Size = new Size(151, 28);
            PositionInput.TabIndex = 49;
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new Point(467, 256);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(61, 20);
            PositionLabel.TabIndex = 46;
            PositionLabel.Text = "Position";
            // 
            // SexInput
            // 
            SexInput.FormattingEnabled = true;
            SexInput.Items.AddRange(new object[] { "Male", "Female" });
            SexInput.Location = new Point(422, 187);
            SexInput.Name = "SexInput";
            SexInput.Size = new Size(151, 28);
            SexInput.TabIndex = 45;
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(484, 164);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(32, 20);
            SexLabel.TabIndex = 44;
            SexLabel.Text = "Sex";
            // 
            // SalaryInput
            // 
            SalaryInput.Location = new Point(650, 112);
            SalaryInput.Name = "SalaryInput";
            SalaryInput.Size = new Size(125, 27);
            SalaryInput.TabIndex = 43;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(676, 89);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(77, 20);
            SalaryLabel.TabIndex = 42;
            SalaryLabel.Text = "Salary(0+)";
            // 
            // AgeInput
            // 
            AgeInput.Location = new Point(431, 112);
            AgeInput.Name = "AgeInput";
            AgeInput.Size = new Size(125, 27);
            AgeInput.TabIndex = 41;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(455, 89);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(92, 20);
            AgeLabel.TabIndex = 40;
            AgeLabel.Text = "Age(18 - 80)";
            // 
            // SurnameInput
            // 
            SurnameInput.Location = new Point(650, 45);
            SurnameInput.Name = "SurnameInput";
            SurnameInput.Size = new Size(125, 27);
            SurnameInput.TabIndex = 39;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(676, 22);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(67, 20);
            SurnameLabel.TabIndex = 38;
            SurnameLabel.Text = "Surname";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(431, 45);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(125, 27);
            NameInput.TabIndex = 37;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(467, 22);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 36;
            NameLabel.Text = "Name";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(422, 388);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(340, 48);
            OkButton.TabIndex = 53;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // EditAfterSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(WorkerLabel);
            Name = "EditAfterSearchForm";
            Text = "EditAfterSearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WorkerLabel;
        private Label label1;
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
    }
}