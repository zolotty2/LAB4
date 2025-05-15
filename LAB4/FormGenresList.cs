using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = LAB4.Models.AppContext;
using Genre = LAB4.Models.Genre;
namespace LAB4
{
    public partial class FormGenresList : Form
    {
        public FormGenresList()
        {
            InitializeComponent();
        }

        private AppContext db;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewGenre.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

            dataGridViewGenre.Columns["id"].Visible = false;
            dataGridViewGenre.Columns["TitlesGenres"].Visible = false;

            dataGridViewGenre.Columns["GenreName"].HeaderText = "Жанр аниме";
        }
        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormUpdateGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Genre genre = new Genre();
            genre.GenreName = formAddGenre.textBoxGenre.Text;
            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewGenre.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;

        }
        private void BtnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenre.SelectedRows.Count == 0)
                return;

            int index = dataGridViewGenre.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenre[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }
            Genre genre = db.Genres.Find(id);
            FormUpdateGenre formAddGenre = new();
            formAddGenre.textBoxGenre.Text = genre.GenreName;

            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel) return;
            genre.GenreName = formAddGenre.textBoxGenre.Text;
            db.Genres.Update(genre);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");

            this.dataGridViewGenre.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }
        private void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenre.SelectedRows.Count == 0) return;

            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите удалить запись.\nВсе связанные данные будут удалены.", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewGenre.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenre[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);
            db.Genres.Remove(genre);
            db.SaveChanges();

            MessageBox.Show("Удаление завершенно");
            this.dataGridViewGenre.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }
        private void FormGenresList_Load(object sender, EventArgs e)
        {

        }
    }
}
