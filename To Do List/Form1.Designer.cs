namespace To_Do_List
{
    partial class Form1
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
            this.Todolist = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ToDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // Todolist
            // 
            this.Todolist.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todolist.Location = new System.Drawing.Point(12, 9);
            this.Todolist.Name = "Todolist";
            this.Todolist.Size = new System.Drawing.Size(813, 85);
            this.Todolist.TabIndex = 0;
            this.Todolist.Text = "To Do List ";
            this.Todolist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(12, 97);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(832, 26);
            this.TitleTextbox.TabIndex = 1;
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(12, 148);
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(832, 26);
            this.DescriptionTextbox.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Location = new System.Drawing.Point(12, 70);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(832, 24);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 126);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(832, 24);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(630, 180);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(214, 42);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(12, 180);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(199, 42);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(418, 180);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(206, 42);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(217, 180);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(195, 42);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ToDoListView
            // 
            this.ToDoListView.BackgroundColor = System.Drawing.Color.White;
            this.ToDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListView.Location = new System.Drawing.Point(12, 240);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.RowHeadersWidth = 62;
            this.ToDoListView.RowTemplate.Height = 28;
            this.ToDoListView.Size = new System.Drawing.Size(832, 190);
            this.ToDoListView.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(856, 442);
            this.Controls.Add(this.ToDoListView);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.Todolist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Todolist;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView ToDoListView;
    }
}

