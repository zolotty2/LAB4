using System.ComponentModel;
using AppContext = LAB4.Models.AppContext;

namespace LAB4
{
    public partial class FormUpdateGenre : Form
    {
        private AppContext db;

        public FormUpdateGenre()
        {
            InitializeComponent();
            this.db = new AppContext();
        }

        private void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenre.Text))
            {
                errorProvider1.SetError(textBoxGenre, "Поле не может быть пустым!");
                BtnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                BtnSaveChanges.Enabled = true;

            }
            FormUpdateGenre formAddGenre = new FormUpdateGenre();
            string newGenreAnime = textBoxGenre.Text;

            bool exists = db.Genres.Any(t => t.GenreName == newGenreAnime);//.ToLower()



            if (exists)
            {
                BtnSaveChanges.Enabled = false;
                errorProvider1.SetError(textBoxGenre, "Поле должно быть уникальным");

            }
            else
            {
                errorProvider1.Clear();
                BtnSaveChanges.Enabled = true;

            }
        }

        private void TextBoxGenre_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenre.Text))
            {
                errorProvider1.SetError(textBoxGenre, "Поле не может быть пустым");
                BtnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                BtnSaveChanges.Enabled = true;
            }
        }

        private void FormUpdateGenre_Load(object sender, EventArgs e)
        {
            //
        }
    }
}