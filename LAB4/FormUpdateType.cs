using System.ComponentModel;
using AppContext = LAB4.Models.AppContext;
namespace LAB4
{
public partial class FormUpdateType : Form
{
    private AppContext db;
    public FormUpdateType()

    {
        InitializeComponent();
        this.db = new AppContext();
    }

    private void FormAddType_Load(object sender, EventArgs e)
    {
        //
    }

    private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatus.Text))
            {
                errorProvider.SetError(textBoxStatus, "Поле не может быть пустым!");
                BtnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                BtnSaveChanges.Enabled = true;

            }
            FormUpdateType formAddType = new FormUpdateType();
            string newTypeAnime = textBoxStatus.Text;

            bool exists = db.Types.Any(t => t.TypeName == newTypeAnime);



            if (exists)
            {
                BtnSaveChanges.Enabled = false;
                errorProvider.SetError(textBoxStatus, "Поле должно быть уникальным");

            }
            else
            {
                errorProvider.Clear();
                BtnSaveChanges.Enabled = true;

            }
        }
       

    private void nameBox_Validating(object sender, CancelEventArgs e)
    {
        if (String.IsNullOrEmpty(textBoxStatus.Text))
        {
            errorProvider.SetError(textBoxStatus, "Поле не может быть пустым");
            BtnSaveChanges.Enabled = false;
        }
        else
        {
            errorProvider.Clear();
            BtnSaveChanges.Enabled = true;
        }
    }
            
    }
}


