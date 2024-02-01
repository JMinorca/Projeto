
using System.Security.Cryptography.X509Certificates;

namespace FIRST
{
    public partial class Main : Form
    {

        ResistorSMD windowC = new ResistorSMD();
        public static int idioma = 0;
        public static bool languageselected = false;

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //SharedData.SharedLanguage = languagecombobox.SelectedIndex; /// enviar escolha de lingua para os outros form
            languageselected = true;
        }

        public void button1_Click_2(object sender, EventArgs e)
        {


            switch (languagecombobox.Text)
            {
                case "English": idioma = 0; languageselected = true; break;

                case "Português": idioma = 1; languageselected = true; break;

                default: idioma = 0; break;

            }
            Resistor fMain = new Resistor();
            fMain.Idioma(idioma);
            fMain.Show();
            languageselected = false;

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ResistorSMD windowC = new ResistorSMD();
            this.Hide();
            windowC.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            ResistorColour fMain = new ResistorColour();
           // fMain.Idioma(idioma);
            fMain.Show();
             this.Hide();
        }
    }
}
