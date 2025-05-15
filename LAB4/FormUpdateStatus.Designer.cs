namespace LAB4
{
    partial class FormUpdateStatus
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
            components = new System.ComponentModel.Container();
            panelFill = new Panel();
            textBoxStatus = new TextBox();
            labelType = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            BtnSaveChanges = new Button();
            BtnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(textBoxStatus);
            panelFill.Controls.Add(labelType);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(399, 70);
            panelFill.TabIndex = 1;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Dock = DockStyle.Top;
            textBoxStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxStatus.Location = new Point(10, 35);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(379, 33);
            textBoxStatus.TabIndex = 1;
            textBoxStatus.TextChanged += textBoxType_TextChanged;
            textBoxStatus.Validating += nameBox_Validating;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Top;
            labelType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelType.Location = new Point(10, 10);
            labelType.Margin = new Padding(3, 15, 3, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(128, 25);
            labelType.TabIndex = 0;
            labelType.Text = "Статус аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.BackColor = Color.White;
            flowLayoutPanelBottom.Controls.Add(BtnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(BtnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 70);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(399, 61);
            flowLayoutPanelBottom.TabIndex = 2;
            // 
            // BtnSaveChanges
            // 
            BtnSaveChanges.AutoSize = true;
            BtnSaveChanges.DialogResult = DialogResult.OK;
            BtnSaveChanges.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnSaveChanges.Location = new Point(13, 13);
            BtnSaveChanges.Name = "BtnSaveChanges";
            BtnSaveChanges.Size = new Size(115, 35);
            BtnSaveChanges.TabIndex = 0;
            BtnSaveChanges.Text = "Сохранить";
            BtnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.AutoSize = true;
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnCancel.Location = new Point(134, 13);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(100, 35);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "Отмена";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormUpdateStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 131);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Name = "FormUpdateStatus";
            Text = "FormAddStatus";
            Load += FormAddStatus_Load;
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        protected internal TextBox textBoxStatus;
        private Label labelType;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button BtnSaveChanges;
        private Button BtnCancel;
        private ErrorProvider errorProvider1;
    }
}