namespace LAB4
{
    partial class FormUpdateTitle
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
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxStudio = new TextBox();
            labelStudio = new Label();
            numericUpDownDuration = new NumericUpDown();
            labelDuration = new Label();
            numericUpDownCountSeries = new NumericUpDown();
            labelCountSeries = new Label();
            labelType = new Label();
            comboBoxTypes = new ComboBox();
            textBoxName = new TextBox();
            labelName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            BtnSaveChanges = new Button();
            BtnCancel = new Button();
            textBoxOriginalName = new TextBox();
            labelOriginName = new Label();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountSeries).BeginInit();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(textBoxDescription);
            panelFill.Controls.Add(labelDescription);
            panelFill.Controls.Add(textBoxStudio);
            panelFill.Controls.Add(labelStudio);
            panelFill.Controls.Add(numericUpDownDuration);
            panelFill.Controls.Add(labelDuration);
            panelFill.Controls.Add(numericUpDownCountSeries);
            panelFill.Controls.Add(labelCountSeries);
            panelFill.Controls.Add(labelType);
            panelFill.Controls.Add(comboBoxTypes);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(flowLayoutPanelBottom);
            panelFill.Controls.Add(textBoxOriginalName);
            panelFill.Controls.Add(labelOriginName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 676);
            panelFill.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDescription.Location = new Point(10, 423);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(780, 150);
            textBoxDescription.TabIndex = 16;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDescription.Location = new Point(10, 395);
            labelDescription.Margin = new Padding(3, 15, 3, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(99, 25);
            labelDescription.TabIndex = 15;
            labelDescription.Text = "Описание";
            // 
            // textBoxStudio
            // 
            textBoxStudio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxStudio.Location = new Point(10, 358);
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.Size = new Size(780, 33);
            textBoxStudio.TabIndex = 14;
            // 
            // labelStudio
            // 
            labelStudio.AutoSize = true;
            labelStudio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStudio.Location = new Point(10, 330);
            labelStudio.Margin = new Padding(3, 15, 3, 0);
            labelStudio.Name = "labelStudio";
            labelStudio.Size = new Size(72, 25);
            labelStudio.TabIndex = 13;
            labelStudio.Text = "Студия";
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownDuration.Location = new Point(10, 290);
            numericUpDownDuration.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(780, 33);
            numericUpDownDuration.TabIndex = 12;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDuration.Location = new Point(10, 262);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(317, 25);
            labelDuration.TabIndex = 11;
            labelDuration.Text = "Продолжительность серии (минут)";
            // 
            // numericUpDownCountSeries
            // 
            numericUpDownCountSeries.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownCountSeries.Location = new Point(10, 226);
            numericUpDownCountSeries.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownCountSeries.Name = "numericUpDownCountSeries";
            numericUpDownCountSeries.Size = new Size(780, 33);
            numericUpDownCountSeries.TabIndex = 10;
            // 
            // labelCountSeries
            // 
            labelCountSeries.AutoSize = true;
            labelCountSeries.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCountSeries.Location = new Point(10, 198);
            labelCountSeries.Name = "labelCountSeries";
            labelCountSeries.Size = new Size(130, 25);
            labelCountSeries.TabIndex = 9;
            labelCountSeries.Text = "Кол-во серий";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelType.Location = new Point(10, 129);
            labelType.Name = "labelType";
            labelType.Size = new Size(44, 25);
            labelType.TabIndex = 7;
            labelType.Text = "Тип";
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.BackColor = Color.White;
            comboBoxTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Location = new Point(10, 157);
            comboBoxTypes.Margin = new Padding(10, 3, 3, 3);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(780, 33);
            comboBoxTypes.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Top;
            textBoxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(10, 93);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(780, 33);
            textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(10, 68);
            labelName.Margin = new Padding(3, 15, 3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 25);
            labelName.TabIndex = 4;
            labelName.Text = "Имя";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.BackColor = Color.White;
            flowLayoutPanelBottom.Controls.Add(BtnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(BtnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(10, 605);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(780, 61);
            flowLayoutPanelBottom.TabIndex = 3;
            // 
            // BtnSaveChanges
            // 
            BtnSaveChanges.AutoSize = true;
            BtnSaveChanges.DialogResult = DialogResult.OK;
            BtnSaveChanges.Dock = DockStyle.Fill;
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
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnCancel.Location = new Point(134, 13);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(100, 35);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "Отмена";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxOriginalName
            // 
            textBoxOriginalName.Dock = DockStyle.Top;
            textBoxOriginalName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOriginalName.Location = new Point(10, 35);
            textBoxOriginalName.Name = "textBoxOriginalName";
            textBoxOriginalName.Size = new Size(780, 33);
            textBoxOriginalName.TabIndex = 1;
            // 
            // labelOriginName
            // 
            labelOriginName.AutoSize = true;
            labelOriginName.Dock = DockStyle.Top;
            labelOriginName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOriginName.Location = new Point(10, 10);
            labelOriginName.Margin = new Padding(3, 15, 3, 0);
            labelOriginName.Name = "labelOriginName";
            labelOriginName.Size = new Size(178, 25);
            labelOriginName.TabIndex = 0;
            labelOriginName.Text = "Оригинальное имя";
            // 
            // FormUpdateTitle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 676);
            Controls.Add(panelFill);
            Name = "FormUpdateTitle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список тайтлов анме";
            Load += FormUpdateTitle_Load;
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountSeries).EndInit();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        protected internal TextBox textBoxOriginalName;
        private Label labelOriginName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button BtnSaveChanges;
        private Button BtnCancel;
        protected internal TextBox textBoxName;
        private Label labelName;
        private Label labelType;
        private Label labelCountSeries;
        private Label labelDuration;
        protected internal TextBox textBoxStudio;
        private Label labelStudio;
        protected internal TextBox textBoxDescription;
        private Label labelDescription;
        protected internal ComboBox comboBoxTypes;
        protected internal NumericUpDown numericUpDownCountSeries;
        protected internal NumericUpDown numericUpDownDuration;
    }
}