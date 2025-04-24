using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using AppContext = LAB4.Models.AppContext;
using Type = LAB4.Models.Type;

namespace LAB4
{
    public partial class FormListTypes : Form
    {
        private AppContext db;
        public FormListTypes()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Types.Load();
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

            dataGridViewTypes.Columns["id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            dataGridViewTypes.Columns["TypeName"].HeaderText = "Тип аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;

        }
        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new();
            DialogResult result = formAddType.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Type type = new Type();
            type.TypeName = formAddType.textBoxStatus.Text;
            db.Types.Add(type);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

        }

        private void BtnUpdateType_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }
            Type type = db.Types.Find(id);
            FormAddType formAddType = new();
            formAddType.textBoxStatus.Text = type.TypeName;

            DialogResult result = formAddType.ShowDialog(this);

            if (result == DialogResult.Cancel) return;
            type.TypeName = formAddType.textBoxStatus.Text;
            db.Types.Update(type);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");

            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        private void BtnDeleteType_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0) return;

            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите удалить запись.\nВсе связанные данные будут удалены.", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.OK)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Type type = db.Types.Find(id);
            db.Types.Remove(type);
            db.SaveChanges();

            MessageBox.Show("Удаление завершенно");
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        private void FormListTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
