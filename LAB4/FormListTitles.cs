using LAB4.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = LAB4.Models.AppContext;
using Type = LAB4.Models.Type;


namespace LAB4
{
    public partial class FormListTitles : Form
    {
        private AppContext db;
        public FormListTitles()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTitles.Load();
            this.dataGridViewTitle.DataSource = this.db.AnimeTitles
                .Include(i => i.Type)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.Name,
                    i.OriginalName,
                    i.CountSeries,
                    i.Duration,
                    i.Studio,
                    i.Discription,



                })
                .OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();

            dataGridViewTitle.Columns["id"].Visible = false;
            //Изменение текста
            dataGridViewTitle.Columns["TypeName"].HeaderText = "Тип";
            dataGridViewTitle.Columns["Name"].HeaderText = "Имя";
            dataGridViewTitle.Columns["OriginalName"].HeaderText = "Оригенальное имя";
            dataGridViewTitle.Columns["CountSeries"].HeaderText = "Количество серий";
            dataGridViewTitle.Columns["Duration"].HeaderText = "Длительность серии";
            dataGridViewTitle.Columns["Studio"].HeaderText = "Студия";
            dataGridViewTitle.Columns["Discription"].HeaderText = "Описание";


        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void FormListTitles_Load(object sender, EventArgs e)
        {
            //
        }

        private void BtnAddTitle_Click(object sender, EventArgs e)
        {
            FormUpdateTitle formUpdateTitle = new FormUpdateTitle();

            this.db.Types.Load();
            List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
            formUpdateTitle.comboBoxTypes.DataSource = types;
            formUpdateTitle.comboBoxTypes.DisplayMember = "TypeName";
            formUpdateTitle.comboBoxTypes.ValueMember = "id";

            DialogResult result = formUpdateTitle.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            AnimeTitle animeTitle = new()
            {
                Name = formUpdateTitle.textBoxName.Text,
                OriginalName = formUpdateTitle.textBoxOriginalName.Text,
                CountSeries = Convert.ToInt16(formUpdateTitle.numericUpDownCountSeries.Value),
                Duration = Convert.ToInt16(formUpdateTitle.numericUpDownDuration.Value),
                Studio = formUpdateTitle.textBoxStudio.Text,
                Discription = formUpdateTitle.textBoxDescription.Text
            };
            Type type = (Type)formUpdateTitle.comboBoxTypes.SelectedItem;
            animeTitle.IdType = type.Id;
            db.AnimeTitles.Add(animeTitle);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.dataGridViewTitle.DataSource = this.db.AnimeTitles
                .Include(i => i.Type)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.Name,
                    i.OriginalName,
                    i.CountSeries,
                    i.Duration,
                    i.Studio,
                    i.Discription,



                })
                .OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();
        }

        private void BtnUpdateTitle_Click(object sender, EventArgs e)
        {
            if (dataGridViewTitle.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTitle.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridViewTitle[0, index].Value.ToString(), out id);
            if (!converted)
                return;
            AnimeTitle animeTitle = db.AnimeTitles.Find(id);
            FormUpdateTitle formUpdateTitle = new FormUpdateTitle();

            formUpdateTitle.textBoxName.Text = animeTitle.Name;
            formUpdateTitle.textBoxOriginalName.Text = animeTitle.OriginalName;
            formUpdateTitle.numericUpDownCountSeries.Value = animeTitle.CountSeries;
            formUpdateTitle.numericUpDownDuration.Value = animeTitle.Duration;
            formUpdateTitle.textBoxStudio.Text = animeTitle.Studio;
            formUpdateTitle.textBoxDescription.Text = animeTitle.Discription;

            this.db.Types.Load();
            List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
            formUpdateTitle.comboBoxTypes.DataSource = types;
            formUpdateTitle.comboBoxTypes.DisplayMember = "TypeName";
            formUpdateTitle.comboBoxTypes.ValueMember = "id";

            formUpdateTitle.comboBoxTypes.SelectedItem = animeTitle.Type;

            DialogResult result = formUpdateTitle.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            animeTitle.Name = formUpdateTitle.textBoxName.Text;
            animeTitle.OriginalName = formUpdateTitle.textBoxOriginalName.Text;
            animeTitle.CountSeries = Convert.ToInt16(formUpdateTitle.numericUpDownCountSeries.Value);
            animeTitle.Duration = Convert.ToInt16(formUpdateTitle.numericUpDownDuration.Value);
            animeTitle.Studio = formUpdateTitle.textBoxStudio.Text;
            animeTitle.Discription = formUpdateTitle.textBoxDescription.Text;

            Type type = (Type)formUpdateTitle.comboBoxTypes.SelectedItem;
            animeTitle.IdType = type.Id;
            db.AnimeTitles.Update(animeTitle);
            db.SaveChanges();
            MessageBox.Show("Объект изменён",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridViewTitle.DataSource = this.db.AnimeTitles
                .Include(i => i.Type)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.Name,
                    i.OriginalName,
                    i.CountSeries,
                    i.Duration,
                    i.Studio,
                    i.Discription,



                })
                .OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();

        }

        private void BtnDeleteTitle_Click(object sender, EventArgs e)
        {
            if (dataGridViewTitle.SelectedRows.Count == 0) return;

            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите удалить запись.\nВсе связанные данные будут удалены.", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;
            int index = dataGridViewTitle.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridViewTitle[0, index].Value.ToString(), out id);
            if (!converted)
                return;
            AnimeTitle animeTitle = db.AnimeTitles.Find(id);
            db.AnimeTitles.Remove(animeTitle);
            db.SaveChanges();

            MessageBox.Show("Объект удaлён",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.dataGridViewTitle.DataSource = this.db.AnimeTitles
                .Include(i => i.Type)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.Name,
                    i.OriginalName,
                    i.CountSeries,
                    i.Duration,
                    i.Studio,
                    i.Discription,



                })
                .OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();

        }
    }
}
