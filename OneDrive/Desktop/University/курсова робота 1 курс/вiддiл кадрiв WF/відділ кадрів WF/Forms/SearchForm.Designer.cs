namespace відділ_кадрів_WF
{
    partial class SearchForm
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
            SearchTextBox = new TextBox();
            DivisionInput = new ListBox();
            DivisionLabel = new Label();
            PositionInput = new ListBox();
            PositionLabel = new Label();
            EducationInput = new ListBox();
            EducationLabel = new Label();
            SexInput = new ListBox();
            SexLabel = new Label();
            SearchTextBoxLabel = new Label();
            SearchListBox = new ListBox();
            SearchListBoxLabel = new Label();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(694, 409);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 14;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Location = new Point(12, 31);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.ReadOnly = true;
            SearchTextBox.ScrollBars = ScrollBars.Vertical;
            SearchTextBox.Size = new Size(776, 132);
            SearchTextBox.TabIndex = 2;
            // 
            // DivisionInput
            // 
            DivisionInput.FormattingEnabled = true;
            DivisionInput.Items.AddRange(new object[] { "div1", "div2", "div3", "div4", "ELSE" });
            DivisionInput.Location = new Point(212, 299);
            DivisionInput.Name = "DivisionInput";
            DivisionInput.Size = new Size(150, 104);
            DivisionInput.TabIndex = 9;
            DivisionInput.SelectedIndexChanged += DivisionInput_SelectedIndexChanged;
            // 
            // DivisionLabel
            // 
            DivisionLabel.AutoSize = true;
            DivisionLabel.Location = new Point(253, 276);
            DivisionLabel.Name = "DivisionLabel";
            DivisionLabel.Size = new Size(62, 20);
            DivisionLabel.TabIndex = 4;
            DivisionLabel.Text = "Division";
            // 
            // PositionInput
            // 
            PositionInput.FormattingEnabled = true;
            PositionInput.Items.AddRange(new object[] { "Ceo", "Manager", "Office", "Security", "Cleaner", "ELSE" });
            PositionInput.Location = new Point(38, 299);
            PositionInput.Name = "PositionInput";
            PositionInput.Size = new Size(150, 104);
            PositionInput.TabIndex = 7;
            PositionInput.SelectedIndexChanged += PositionInput_SelectedIndexChanged;
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new Point(78, 276);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(61, 20);
            PositionLabel.TabIndex = 6;
            PositionLabel.Text = "Position";
            // 
            // EducationInput
            // 
            EducationInput.FormattingEnabled = true;
            EducationInput.Items.AddRange(new object[] { "MA", "BA", "PhD", "ELSE" });
            EducationInput.Location = new Point(38, 189);
            EducationInput.Name = "EducationInput";
            EducationInput.Size = new Size(150, 84);
            EducationInput.TabIndex = 3;
            EducationInput.SelectedIndexChanged += EducationInput_SelectedIndexChanged;
            // 
            // EducationLabel
            // 
            EducationLabel.AutoSize = true;
            EducationLabel.Location = new Point(78, 166);
            EducationLabel.Name = "EducationLabel";
            EducationLabel.Size = new Size(75, 20);
            EducationLabel.TabIndex = 8;
            EducationLabel.Text = "Education";
            // 
            // SexInput
            // 
            SexInput.FormattingEnabled = true;
            SexInput.Items.AddRange(new object[] { "Male", "Female", "ELSE" });
            SexInput.Location = new Point(212, 200);
            SexInput.Name = "SexInput";
            SexInput.Size = new Size(150, 64);
            SexInput.TabIndex = 5;
            SexInput.SelectedIndexChanged += SexInput_SelectedIndexChanged;
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(266, 166);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(32, 20);
            SexLabel.TabIndex = 10;
            SexLabel.Text = "Sex";
            // 
            // SearchTextBoxLabel
            // 
            SearchTextBoxLabel.AutoSize = true;
            SearchTextBoxLabel.Location = new Point(179, 8);
            SearchTextBoxLabel.Name = "SearchTextBoxLabel";
            SearchTextBoxLabel.Size = new Size(471, 20);
            SearchTextBoxLabel.TabIndex = 11;
            SearchTextBoxLabel.Text = "Відділ кадрів(динамічно оновлюється після введених параметрів)";
            // 
            // SearchListBox
            // 
            SearchListBox.FormattingEnabled = true;
            SearchListBox.HorizontalScrollbar = true;
            SearchListBox.Location = new Point(403, 259);
            SearchListBox.Name = "SearchListBox";
            SearchListBox.Size = new Size(385, 144);
            SearchListBox.TabIndex = 12;
            SearchListBox.MouseDoubleClick += SearchListBox_DoubleClick;
            // 
            // SearchListBoxLabel
            // 
            SearchListBoxLabel.Location = new Point(450, 212);
            SearchListBoxLabel.Name = "SearchListBoxLabel";
            SearchListBoxLabel.Size = new Size(327, 44);
            SearchListBoxLabel.TabIndex = 13;
            SearchListBoxLabel.Text = "Тут можна обрати одного певного робітника (нажміть двічі по певному робітнику)";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchListBoxLabel);
            Controls.Add(SearchListBox);
            Controls.Add(SearchTextBoxLabel);
            Controls.Add(SexLabel);
            Controls.Add(SexInput);
            Controls.Add(EducationLabel);
            Controls.Add(EducationInput);
            Controls.Add(PositionLabel);
            Controls.Add(PositionInput);
            Controls.Add(DivisionLabel);
            Controls.Add(DivisionInput);
            Controls.Add(SearchTextBox);
            Controls.Add(OkButton);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private TextBox SearchTextBox;
        private ListBox DivisionInput;
        private Label DivisionLabel;
        private ListBox PositionInput;
        private Label PositionLabel;
        private ListBox EducationInput;
        private Label EducationLabel;
        private ListBox SexInput;
        private Label SexLabel;
        private Label SearchTextBoxLabel;
        private ListBox SearchListBox;
        private Label SearchListBoxLabel;
    }
}