using System.ComponentModel;
using AppContext = LAB4.Models.AppContext;
namespace LAB4
{
    public partial class FormUpdateStatus : Form
    {
        private AppContext db;
        public FormUpdateStatus()

        {
            InitializeComponent();
            this.db = new AppContext();
        }

        private void FormAddType_Load(object sender, EventArgs e)
        {

        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatus.Text))
            {
                errorProvider1.SetError(textBoxStatus, "Поле не может быть пустым!");
                BtnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                BtnSaveChanges.Enabled = true;

            }
            FormUpdateStatus formAddStatus = new FormUpdateStatus();
            string newStatusAnime = textBoxStatus.Text;

            bool exists = db.Statuses.Any(t => t.StatusName == newStatusAnime);//.ToLower()



            if (exists)
            {
                BtnSaveChanges.Enabled = false;
                errorProvider1.SetError(textBoxStatus, "Поле должно быть уникальным");

            }
            else
            {
                errorProvider1.Clear();
                BtnSaveChanges.Enabled = true;

            }
        }
        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatus.Text))
            {
                errorProvider1.SetError(textBoxStatus, "Поле не может быть пустым");
                BtnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                BtnSaveChanges.Enabled = true;
            }
        }

        private void FormAddStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
