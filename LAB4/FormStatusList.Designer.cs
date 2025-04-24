namespace LAB4
{
    partial class FormStatusList
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
            dataGridViewStatus = new DataGridView();
            flowLayoutPanelTop = new FlowLayoutPanel();
            BtnAddStatus = new Button();
            BtnUpdateStatus = new Button();
            BtnDeleteStatus = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).BeginInit();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewStatus);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelFill.Location = new Point(0, 48);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 402);
            panelFill.TabIndex = 6;
            // 
            // dataGridViewStatus
            // 
            dataGridViewStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatus.BackgroundColor = Color.White;
            dataGridViewStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatus.Dock = DockStyle.Fill;
            dataGridViewStatus.Location = new Point(10, 10);
            dataGridViewStatus.MultiSelect = false;
            dataGridViewStatus.Name = "dataGridViewStatus";
            dataGridViewStatus.ReadOnly = true;
            dataGridViewStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatus.Size = new Size(780, 382);
            dataGridViewStatus.TabIndex = 1;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(BtnAddStatus);
            flowLayoutPanelTop.Controls.Add(BtnUpdateStatus);
            flowLayoutPanelTop.Controls.Add(BtnDeleteStatus);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(800, 48);
            flowLayoutPanelTop.TabIndex = 5;
            // 
            // BtnAddStatus
            // 
            BtnAddStatus.AutoSize = true;
            BtnAddStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnAddStatus.Location = new Point(3, 3);
            BtnAddStatus.Name = "BtnAddStatus";
            BtnAddStatus.Size = new Size(106, 42);
            BtnAddStatus.TabIndex = 0;
            BtnAddStatus.Text = "Добавить";
            BtnAddStatus.UseVisualStyleBackColor = true;
            BtnAddStatus.Click += BtnAddType_Click;
            // 
            // BtnUpdateStatus
            // 
            BtnUpdateStatus.AutoSize = true;
            BtnUpdateStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnUpdateStatus.Location = new Point(115, 3);
            BtnUpdateStatus.Name = "BtnUpdateStatus";
            BtnUpdateStatus.Size = new Size(151, 42);
            BtnUpdateStatus.TabIndex = 1;
            BtnUpdateStatus.Text = "Редактировать";
            BtnUpdateStatus.UseVisualStyleBackColor = true;
            BtnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // BtnDeleteStatus
            // 
            BtnDeleteStatus.AutoSize = true;
            BtnDeleteStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnDeleteStatus.Location = new Point(272, 3);
            BtnDeleteStatus.Name = "BtnDeleteStatus";
            BtnDeleteStatus.Size = new Size(92, 42);
            BtnDeleteStatus.TabIndex = 3;
            BtnDeleteStatus.Text = "Удалить";
            BtnDeleteStatus.UseVisualStyleBackColor = true;
            BtnDeleteStatus.Click += BtnDeleteType_Click;
            // 
            // FormStatusList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Name = "FormStatusList";
            Text = "FormStatusList";
            Load += FormStatusList_Load;
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).EndInit();
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewStatus;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Button BtnAddStatus;
        private Button BtnUpdateStatus;
        private Button BtnDeleteStatus;
    }
}