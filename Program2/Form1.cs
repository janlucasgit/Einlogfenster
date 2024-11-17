namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Admin;
        public string User;

        public string PasswordAdmin = "12345";
        public string PasswordUser;
        private void Eingabe_TextChanged(object sender, EventArgs e)
        {


        }



        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (Eingabe.Text == PasswordAdmin)
                {

                    Ausgabe_Textbox.Text = "Du hast dich als Administrator angemeldet";
                }
                else
                {
                    Ausgabe_Textbox.Text = "Du hast dich als User angemeldet";
                }
            }
        }

        
    }
}
