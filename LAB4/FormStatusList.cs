using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = LAB4.Models.AppContext;
using Status = LAB4.Models.Status;

namespace LAB4
{
    public partial class FormStatusList : Form
    {
        private AppContext db;
        public FormStatusList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Statuses.Load();
            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();

            dataGridViewStatus.Columns["id"].Visible = false;
            dataGridViewStatus.Columns["TitlesStatuses"].Visible = false;

            dataGridViewStatus.Columns["StatusName"].HeaderText = "Статус аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;

        }
        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new();
            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Status status = new Status();
            status.StatusName = formAddStatus.textBoxStatus.Text;
            db.Statuses.Add(status);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();

        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }
            Status status = db.Statuses.Find(id);
            FormAddStatus formAddStatus = new();
            formAddStatus.textBoxStatus.Text = status.StatusName;

            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel) return;
            status.StatusName = formAddStatus.textBoxStatus.Text;
            db.Statuses.Update(status);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }

        private void BtnDeleteType_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0) return;

            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите удалить запись.\nВсе связанные данные будут удалены.", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.OK)
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Status status = db.Statuses.Find(id);
            db.Statuses.Remove(status);
            db.SaveChanges();

            MessageBox.Show("Удаление завершенно");
            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }


        private void FormStatusList_Load(object sender, EventArgs e)
        {

        }
    }
}
