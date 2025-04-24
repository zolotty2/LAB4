namespace LAB4
{
    partial class FormMain
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
            btnTypes = new Button();
            BtnGenres = new Button();
            BtnStatus = new Button();
            SuspendLayout();
            // 
            // btnTypes
            // 
            btnTypes.AutoSize = true;
            btnTypes.BackColor = SystemColors.ButtonFace;
            btnTypes.Font = new Font("Segoe UI", 14F);
            btnTypes.Location = new Point(12, 12);
            btnTypes.Name = "btnTypes";
            btnTypes.Size = new Size(328, 36);
            btnTypes.TabIndex = 0;
            btnTypes.Text = "Список типов аниме";
            btnTypes.UseVisualStyleBackColor = false;
            btnTypes.Click += BtnTypes_Click;
            // 
            // BtnGenres
            // 
            BtnGenres.AutoSize = true;
            BtnGenres.BackColor = SystemColors.ButtonFace;
            BtnGenres.Font = new Font("Segoe UI", 14F);
            BtnGenres.Location = new Point(12, 54);
            BtnGenres.Name = "BtnGenres";
            BtnGenres.Size = new Size(328, 36);
            BtnGenres.TabIndex = 1;
            BtnGenres.Text = "Список жанров аниме";
            BtnGenres.UseVisualStyleBackColor = false;
            BtnGenres.Click += BtnGenres_Click;
            // 
            // BtnStatus
            // 
            BtnStatus.AutoSize = true;
            BtnStatus.BackColor = SystemColors.ButtonFace;
            BtnStatus.Font = new Font("Segoe UI", 14F);
            BtnStatus.Location = new Point(12, 96);
            BtnStatus.Name = "BtnStatus";
            BtnStatus.Size = new Size(328, 36);
            BtnStatus.TabIndex = 2;
            BtnStatus.Text = "Список статусов аниме";
            BtnStatus.UseVisualStyleBackColor = false;
            BtnStatus.Click += BtnStatus_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1143, 630);
            Controls.Add(BtnStatus);
            Controls.Add(BtnGenres);
            Controls.Add(btnTypes);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Главная Форма";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTypes;
        private Button BtnGenres;
        private Button BtnStatus;
    }
}
