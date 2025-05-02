namespace LAB4
{
    partial class FormUpdateGenre
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
            textBoxGenre = new TextBox();
            labelGenre = new Label();
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
            panelFill.Controls.Add(textBoxGenre);
            panelFill.Controls.Add(labelGenre);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(594, 92);
            panelFill.TabIndex = 1;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Dock = DockStyle.Top;
            textBoxGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxGenre.Location = new Point(10, 35);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(574, 33);
            textBoxGenre.TabIndex = 1;
            textBoxGenre.TextChanged += TextBoxGenre_TextChanged;
            textBoxGenre.Validating += TextBoxGenre_Validating;
            textBoxGenre.Validated += TextBoxGenre_TextChanged;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Dock = DockStyle.Top;
            labelGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGenre.Location = new Point(10, 10);
            labelGenre.Margin = new Padding(3, 15, 3, 0);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(120, 25);
            labelGenre.TabIndex = 0;
            labelGenre.Text = "Жанр аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.BackColor = Color.White;
            flowLayoutPanelBottom.Controls.Add(BtnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(BtnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 92);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(594, 61);
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
            // FormUpdateGenre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 153);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Name = "FormUpdateGenre";
            Text = "FormAddGenre";
            Load += FormAddGenre_Load;
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
        protected internal TextBox textBoxGenre;
        private Label labelGenre;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button BtnSaveChanges;
        private Button BtnCancel;
        private ErrorProvider errorProvider1;
    }
}