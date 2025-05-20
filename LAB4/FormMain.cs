namespace LAB4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }

        private void BtnGenres_Click(object sender, EventArgs e)
        {
            FormGenresList formGenresList = new FormGenresList();
            formGenresList.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            FormStatusList formStatusList = new FormStatusList();
            formStatusList.Show();
        }

        private void BtnShowTitles_Click(object sender, EventArgs e)
        {
            FormListTitles formListTitles = new FormListTitles();
            formListTitles.Show();
        }
    }
}
