using System.Xml;

namespace відділ_кадрів_WF
{
    partial class FireForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(694, 409);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 18;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(487, 22);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(451, 45);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(125, 27);
            NameInput.TabIndex = 2;
            // 
            // SurnameInput
            // 
            SurnameInput.Location = new Point(616, 45);
            SurnameInput.Name = "SurnameInput";
            SurnameInput.Size = new Size(125, 27);
            SurnameInput.TabIndex = 4;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(643, 22);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(67, 20);
            SurnameLabel.TabIndex = 3;
            SurnameLabel.Text = "Surname";
            // 
            // AgeInput
            // 
            AgeInput.Location = new Point(451, 124);
            AgeInput.Name = "AgeInput";
            AgeInput.Size = new Size(125, 27);
            AgeInput.TabIndex = 6;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(469, 101);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(92, 20);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Age(18 - 80)";
            // 
            // SalaryInput
            // 
            SalaryInput.Location = new Point(616, 124);
            SalaryInput.Name = "SalaryInput";
            SalaryInput.Size = new Size(125, 27);
            SalaryInput.TabIndex = 8;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(643, 101);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(77, 20);
            SalaryLabel.TabIndex = 7;
            SalaryLabel.Text = "Salary(0+)";
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(480, 177);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(32, 20);
            SexLabel.TabIndex = 9;
            SexLabel.Text = "Sex";
            // 
            // SexInput
            // 
            SexInput.FormattingEnabled = true;
            SexInput.Items.AddRange(new object[] { "Male", "Female" });
            SexInput.Location = new Point(425, 200);
            SexInput.Name = "SexInput";
            SexInput.Size = new Size(151, 28);
            SexInput.TabIndex = 10;
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new Point(466, 252);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(61, 20);
            PositionLabel.TabIndex = 11;
            PositionLabel.Text = "Position";
            // 
            // PositionInput
            // 
            PositionInput.FormattingEnabled = true;
            PositionInput.Items.AddRange(new object[] { "Ceo", "Manager", "Office", "Security", "Cleaner" });
            PositionInput.Location = new Point(425, 274);
            PositionInput.Name = "PositionInput";
            PositionInput.Size = new Size(151, 28);
            PositionInput.TabIndex = 14;
            // 
            // DivisionLabel
            // 
            DivisionLabel.AutoSize = true;
            DivisionLabel.Location = new Point(661, 251);
            DivisionLabel.Name = "DivisionLabel";
            DivisionLabel.Size = new Size(62, 20);
            DivisionLabel.TabIndex = 13;
            DivisionLabel.Text = "Division";
            // 
            // DivisionInput
            // 
            DivisionInput.FormattingEnabled = true;
            DivisionInput.Items.AddRange(new object[] { "div1", "div2", "div3", "div4" });
            DivisionInput.Location = new Point(616, 274);
            DivisionInput.Name = "DivisionInput";
            DivisionInput.Size = new Size(151, 28);
            DivisionInput.TabIndex = 16;
            // 
            // EducationInput
            // 
            EducationInput.FormattingEnabled = true;
            EducationInput.Items.AddRange(new object[] { "BA", "MA", "PhD" });
            EducationInput.Location = new Point(616, 200);
            EducationInput.Name = "EducationInput";
            EducationInput.Size = new Size(151, 28);
            EducationInput.TabIndex = 12;
            // 
            // EducationLabel
            // 
            EducationLabel.AutoSize = true;
            EducationLabel.Location = new Point(660, 177);
            EducationLabel.Name = "EducationLabel";
            EducationLabel.Size = new Size(75, 20);
            EducationLabel.TabIndex = 15;
            EducationLabel.Text = "Education";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(12, 52);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Size = new Size(381, 364);
            listBox1.TabIndex = 0;
            listBox1.MouseDoubleClick += ListBox_DoubleClick;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 40);
            label1.TabIndex = 18;
            label1.Text = "Швидко натисніть двічі на обраного робітника щоб швидко видалити його";
            // 
            // FireForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
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
            Name = "FireForm";
            Text = "FireForm";
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
        private ListBox listBox1;
        private Label label1;
    }
}