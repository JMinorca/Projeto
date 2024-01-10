
using System.Security.Cryptography.X509Certificates;

namespace FIRST
{
    public partial class Main : Form
    {

       
        //Resistor windowB = new Resistor();
        ResistorSMD windowC = new ResistorSMD();
        public int language = 0;
        public bool languageselected = false;

        public Main()
        {
            InitializeComponent();
        }


        public static class SharedData
        {
            public static int SharedLanguage;
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
            //Resistor windowB = new Resistor();
            Resistor fMain = new Resistor();
            //language = languagecombobox.SelectedIndex;
            switch (languagecombobox.Text)
            {
                case "English": language = 0; languageselected = true; break;

                case "Português": language = 1; languageselected = true; break;   

                default: language = 0; break;
                   
            }
            if (languageselected == true) { fMain.defineLanguage(language); fMain.Show(); languageselected = false; }
            else { fMain.defineLanguage(0); fMain.Show();}

            this.Hide();

            //Close();
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
    }
}
