namespace відділ_кадрів_WF
{
    partial class AfterSearchForm
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
            EditButton = new Button();
            FireButton = new Button();
            SuspendLayout();
            // 
            // WorkerLabel
            // 
            WorkerLabel.AllowDrop = true;
            WorkerLabel.AutoSize = true;
            WorkerLabel.MaximumSize = new Size(600, 400);
            WorkerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WorkerLabel.Location = new Point(12, 20);
            WorkerLabel.Name = "WorkerLabel";
            WorkerLabel.TabIndex = 0;
            WorkerLabel.Text = "label1";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(477, 272);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(222, 106);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // FireButton
            // 
            FireButton.Location = new Point(114, 272);
            FireButton.Name = "FireButton";
            FireButton.Size = new Size(215, 106);
            FireButton.TabIndex = 2;
            FireButton.Text = "Fire";
            FireButton.UseVisualStyleBackColor = true;
            FireButton.Click += FireButton_Click;
            // 
            // AfterSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FireButton);
            Controls.Add(EditButton);
            Controls.Add(WorkerLabel);
            Name = "AfterSearchForm";
            Text = "AfterSearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WorkerLabel;
        private Button EditButton;
        private Button FireButton;
    }
}