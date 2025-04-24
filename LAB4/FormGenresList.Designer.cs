namespace LAB4
{
    partial class FormGenresList
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
            panelFill = new Panel();
            dataGridViewGenre = new DataGridView();
            flowLayoutPanelTop = new FlowLayoutPanel();
            BtnAddGenre = new Button();
            BtnUpdateGenre = new Button();
            BtnDeleteGenre = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenre).BeginInit();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewGenre);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelFill.Location = new Point(0, 48);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(886, 438);
            panelFill.TabIndex = 4;
            // 
            // dataGridViewGenre
            // 
            dataGridViewGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenre.BackgroundColor = Color.White;
            dataGridViewGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenre.Dock = DockStyle.Fill;
            dataGridViewGenre.Location = new Point(10, 10);
            dataGridViewGenre.MultiSelect = false;
            dataGridViewGenre.Name = "dataGridViewGenre";
            dataGridViewGenre.ReadOnly = true;
            dataGridViewGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenre.Size = new Size(866, 418);
            dataGridViewGenre.TabIndex = 1;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(BtnAddGenre);
            flowLayoutPanelTop.Controls.Add(BtnUpdateGenre);
            flowLayoutPanelTop.Controls.Add(BtnDeleteGenre);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(886, 48);
            flowLayoutPanelTop.TabIndex = 3;
            // 
            // BtnAddGenre
            // 
            BtnAddGenre.AutoSize = true;
            BtnAddGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnAddGenre.Location = new Point(3, 3);
            BtnAddGenre.Name = "BtnAddGenre";
            BtnAddGenre.Size = new Size(106, 42);
            BtnAddGenre.TabIndex = 0;
            BtnAddGenre.Text = "Добавить";
            BtnAddGenre.UseVisualStyleBackColor = true;
            BtnAddGenre.Click += BtnAddGenre_Click;
            // 
            // BtnUpdateGenre
            // 
            BtnUpdateGenre.AutoSize = true;
            BtnUpdateGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnUpdateGenre.Location = new Point(115, 3);
            BtnUpdateGenre.Name = "BtnUpdateGenre";
            BtnUpdateGenre.Size = new Size(151, 42);
            BtnUpdateGenre.TabIndex = 1;
            BtnUpdateGenre.Text = "Редактировать";
            BtnUpdateGenre.UseVisualStyleBackColor = true;
            BtnUpdateGenre.Click += BtnUpdateGenre_Click;
            // 
            // BtnDeleteGenre
            // 
            BtnDeleteGenre.AutoSize = true;
            BtnDeleteGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnDeleteGenre.Location = new Point(272, 3);
            BtnDeleteGenre.Name = "BtnDeleteGenre";
            BtnDeleteGenre.Size = new Size(92, 42);
            BtnDeleteGenre.TabIndex = 3;
            BtnDeleteGenre.Text = "Удалить";
            BtnDeleteGenre.UseVisualStyleBackColor = true;
            BtnDeleteGenre.Click += BtnDeleteGenre_Click;
            // 
            // FormGenresList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 486);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Name = "FormGenresList";
            Text = "FormGenresList";
            Load += FormGenresList_Load;
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenre).EndInit();
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewGenre;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Button BtnAddGenre;
        private Button BtnUpdateGenre;
        private Button BtnDeleteGenre;
    }
}