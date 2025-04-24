using System.ComponentModel;
using System.Windows.Forms.VisualStyles;
using AppContext = LAB4.Models.AppContext;

namespace LAB4
{
    public partial class FormAddGenre : Form
    {
        private AppContext db;

        public FormAddGenre()
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
            FormAddGenre formAddGenre = new FormAddGenre();
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

        private void FormAddGenre_Load(object sender, EventArgs e)
        {

        }
    }
}