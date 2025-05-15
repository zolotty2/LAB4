namespace LAB4
{
    partial class FormListTitles
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            BtnAddTitle = new Button();
            BtnUpdateTitle = new Button();
            BtnDeleteTitle = new Button();
            panelFill = new Panel();
            dataGridViewTitle = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitle).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(BtnAddTitle);
            flowLayoutPanelTop.Controls.Add(BtnUpdateTitle);
            flowLayoutPanelTop.Controls.Add(BtnDeleteTitle);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(731, 41);
            flowLayoutPanelTop.TabIndex = 1;
            // 
            // BtnAddTitle
            // 
            BtnAddTitle.AutoSize = true;
            BtnAddTitle.Location = new Point(3, 3);
            BtnAddTitle.Name = "BtnAddTitle";
            BtnAddTitle.Size = new Size(106, 35);
            BtnAddTitle.TabIndex = 0;
            BtnAddTitle.Text = "Добавить";
            BtnAddTitle.UseVisualStyleBackColor = true;
            BtnAddTitle.Click += BtnAddTitle_Click;
            // 
            // BtnUpdateTitle
            // 
            BtnUpdateTitle.AutoSize = true;
            BtnUpdateTitle.Location = new Point(115, 3);
            BtnUpdateTitle.Name = "BtnUpdateTitle";
            BtnUpdateTitle.Size = new Size(151, 35);
            BtnUpdateTitle.TabIndex = 1;
            BtnUpdateTitle.Text = "Редактировать";
            BtnUpdateTitle.UseVisualStyleBackColor = true;
            BtnUpdateTitle.Click += BtnUpdateTitle_Click;
            // 
            // BtnDeleteTitle
            // 
            BtnDeleteTitle.AutoSize = true;
            BtnDeleteTitle.Location = new Point(272, 3);
            BtnDeleteTitle.Name = "BtnDeleteTitle";
            BtnDeleteTitle.Size = new Size(92, 35);
            BtnDeleteTitle.TabIndex = 2;
            BtnDeleteTitle.Text = "Удалить";
            BtnDeleteTitle.UseVisualStyleBackColor = true;
            BtnDeleteTitle.Click += BtnDeleteTitle_Click;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewTitle);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 41);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(731, 333);
            panelFill.TabIndex = 3;
            // 
            // dataGridViewTitle
            // 
            dataGridViewTitle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTitle.BackgroundColor = Color.White;
            dataGridViewTitle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTitle.Dock = DockStyle.Fill;
            dataGridViewTitle.Location = new Point(10, 10);
            dataGridViewTitle.MultiSelect = false;
            dataGridViewTitle.Name = "dataGridViewTitle";
            dataGridViewTitle.ReadOnly = true;
            dataGridViewTitle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTitle.Size = new Size(711, 313);
            dataGridViewTitle.TabIndex = 1;
            // 
            // FormListTitles
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(731, 374);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTitles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListTitles";
            Load += FormListTitles_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button BtnAddTitle;
        private Button BtnUpdateTitle;
        private Button BtnDeleteTitle;
        private Panel panelFill;
        private DataGridView dataGridViewTitle;
    }
}