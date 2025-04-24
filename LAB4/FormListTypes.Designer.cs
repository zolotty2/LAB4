namespace LAB4
{
    partial class FormListTypes
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
            BtnAddType = new Button();
            BtnUpdateType = new Button();
            BtnDeleteType = new Button();
            dataGridViewTypes = new DataGridView();
            panelFill = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(BtnAddType);
            flowLayoutPanelTop.Controls.Add(BtnUpdateType);
            flowLayoutPanelTop.Controls.Add(BtnDeleteType);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(666, 41);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // BtnAddType
            // 
            BtnAddType.AutoSize = true;
            BtnAddType.Location = new Point(3, 3);
            BtnAddType.Name = "BtnAddType";
            BtnAddType.Size = new Size(106, 35);
            BtnAddType.TabIndex = 0;
            BtnAddType.Text = "Добавить";
            BtnAddType.UseVisualStyleBackColor = true;
            BtnAddType.Click += BtnAddType_Click;
            // 
            // BtnUpdateType
            // 
            BtnUpdateType.AutoSize = true;
            BtnUpdateType.Location = new Point(115, 3);
            BtnUpdateType.Name = "BtnUpdateType";
            BtnUpdateType.Size = new Size(151, 35);
            BtnUpdateType.TabIndex = 1;
            BtnUpdateType.Text = "Редактировать";
            BtnUpdateType.UseVisualStyleBackColor = true;
            BtnUpdateType.Click += BtnUpdateType_Click;
            // 
            // BtnDeleteType
            // 
            BtnDeleteType.AutoSize = true;
            BtnDeleteType.Location = new Point(272, 3);
            BtnDeleteType.Name = "BtnDeleteType";
            BtnDeleteType.Size = new Size(92, 35);
            BtnDeleteType.TabIndex = 2;
            BtnDeleteType.Text = "Удалить";
            BtnDeleteType.UseVisualStyleBackColor = true;
            BtnDeleteType.Click += BtnDeleteType_Click;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(646, 380);
            dataGridViewTypes.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 41);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(666, 400);
            panelFill.TabIndex = 2;
            // 
            // FormListTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 441);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTypes";
            Text = "Список типов аниме";
            Load += FormListTypes_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button BtnAddType;
        private Button BtnUpdateType;
        private Button BtnDeleteType;
        private DataGridView dataGridViewTypes;
        private Panel panelFill;
    }
}