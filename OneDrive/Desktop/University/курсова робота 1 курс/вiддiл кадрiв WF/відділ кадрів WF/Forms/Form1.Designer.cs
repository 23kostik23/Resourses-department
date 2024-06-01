namespace відділ_кадрів_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            HireButton = new Button();
            FireButton = new Button();
            SearchButton = new Button();
            EditButton = new Button();
            SaveButton = new Button();
            LoadButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "База даних робітників";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(401, 406);
            textBox1.TabIndex = 1;
            textBox1.Text = "Відділ кадрів пустий";
            // 
            // HireButton
            // 
            HireButton.Location = new Point(456, 32);
            HireButton.Name = "HireButton";
            HireButton.Size = new Size(135, 42);
            HireButton.TabIndex = 2;
            HireButton.Text = "Hire Worker";
            HireButton.UseVisualStyleBackColor = true;
            HireButton.Click += HireButton_Click;
            // 
            // FireButton
            // 
            FireButton.Location = new Point(630, 32);
            FireButton.Name = "FireButton";
            FireButton.Size = new Size(135, 42);
            FireButton.TabIndex = 3;
            FireButton.Text = "Fire Worker";
            FireButton.UseVisualStyleBackColor = true;
            FireButton.Click += FireButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(456, 101);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(135, 41);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search Workers";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(630, 101);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(135, 41);
            EditButton.TabIndex = 5;
            EditButton.Text = "Edit Worker";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(435, 385);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(353, 53);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save Data";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(456, 167);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(135, 41);
            LoadButton.TabIndex = 6;
            LoadButton.Text = "Load Data";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(SearchButton);
            Controls.Add(FireButton);
            Controls.Add(HireButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Відділ кадрів";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button HireButton;
        private Button FireButton;
        private Button SearchButton;
        private Button EditButton;
        private Button SaveButton;
        private Button LoadButton;
    }
}
