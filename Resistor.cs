using System.Runtime;
using System.Windows.Forms;
using static FIRST.Main;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace FIRST
{
    public partial class Resistor : Form
    {
            string[] calculatebtn = { "Calculate", "Calcular" };
        
            string[] labelres1 = { "Resistor 1", "Resistência 1" };
       
            string[] labelres2 = { "Resistor 2", "Resistência 2" };
       
            string[] labelres3 = { "Resistor 3", "Resistência 3" };
        
            string[] labelres4 = { "Resistor 4", "Resistência 4" };
       
            string[] slidertext = { "Res: 2", "Res: 2" };
        
            string[] outinfo = { "Equivalent Resistor: ", "Resistência Equivalente: " };
           
        public Resistor()
        {
            InitializeComponent();
        }
        static string FormatNumber(double number)
        {
            string[] suffixes = {" ", "K", "M", "G", "T" }; // Add more suffixes if needed

            int index = 0;

            if (number >=1000)
            {
                while (number >= 1000 && index < suffixes.Length - 1)
                {
                    number /= 1000;
                    index++;
                }
                return $"{number:0.##}{suffixes[index]}";

            }
            else
            {
                string[] minisuffixes = { "","m"," " }; // Add more suffixes if needed
                index = 0;
                
                while (number >0.001 && index < minisuffixes.Length - 1)
                {
                    number /= 1000;
                    index++;
                }
                number *= 1000000;
                return $"{number:0.###}{minisuffixes[index]}";
            }
            

            
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            SliderMovement(); // definir o slider como 2 inicialmente
            Idioma(Main.idioma);
            CheckAllFilled(); //desativar calculo se nao estiver preenchido
            ResistorScale.SelectedIndex = 1; // definir escala default como OHM
            resistorConf.SelectedIndex = 0; // definir configuração original com série
            res1.MaxLength = 6; //definir limite de 6 caracteres nas caixas
            res2.MaxLength = 6; //definir limite de 6 caracteres nas caixas
            res3.MaxLength = 6; //definir limite de 6 caracteres nas caixas
            res4.MaxLength = 6; //definir limite de 6 caracteres nas caixas
            
        }

		public void Calcular_Click(object sender, EventArgs e)
		{

           
		
		}
        public void calcular()
        {
            float.TryParse(res1.Text, out float valor1);
            float.TryParse(res2.Text, out float valor2);
            float.TryParse(res3.Text, out float valor3);
            float.TryParse(res4.Text, out float valor4);



            double result = 0.00;

            //float resultado = (valor1 * valor2) / (valor1 + valor2);
            if (resistorConf.SelectedIndex == 1)  // resistencias em paralelo
            {
                if (ResistorsNumber.Value == 2)
                {
                    result = (valor1 * valor2) / (valor1 + valor2);
                }
                if (ResistorsNumber.Value == 3)
                {
                    result = 1 / ((1 / valor1) + (1 / valor2) + (1 / valor3));
                }
                if (ResistorsNumber.Value == 4)
                {
                    result = 1 / ((1 / valor1) + (1 / valor2) + (1 / valor3) + (1 / valor4));
                }


            }
            if (resistorConf.SelectedIndex == 0)   // resistencias em serie
            {
                if (ResistorsNumber.Value == 2)
                {
                    result = valor1 + valor2;
                }
                if (ResistorsNumber.Value == 3)
                {
                    result = valor1 + valor2 + valor3;
                }
                if (ResistorsNumber.Value == 4)
                {
                    result = valor1 + valor2 + valor3 + valor4;
                }
            }

            int expoente = ResistorScale.SelectedIndex - 1;

            if (ResistorScale.SelectedIndex >= 0) { result = result * Math.Pow(10, expoente * 3); }
            else { result = result * Math.Pow(10, expoente); }

            Requivalente.Text = outinfo[Main.idioma] + FormatNumber(result) + "Ω";

        }
        public void Idioma(int language)
        {
         
        
            
          
            label1.Text = labelres1[language];
         
            label2.Text = labelres2[language];
           
            label3.Text = labelres3[language];
          
            label4.Text = labelres4[language];
           
            slider.Text = slidertext[language];
           
            if (language == 0) { resistorConf.Items.AddRange(new object[] { "Serial", "Paralell" }); }
            if (language == 1) { resistorConf.Items.AddRange(new object[] { "Série", "Paralelo" }); }
        }
        private void SliderMovement()
        {
            if (ResistorsNumber.Value == 2)
            {
                res1.Enabled = true;
                res2.Enabled = true;
                res3.Enabled = false;
                res4.Enabled = false;
            }
            if (ResistorsNumber.Value == 3)
            {
                res1.Enabled = true;
                res2.Enabled = true;
                res3.Enabled = true;
                res4.Enabled = false;
            }
            if (ResistorsNumber.Value == 4)
            {
                res1.Enabled = true;
                res2.Enabled = true;
                res3.Enabled = true;
                res4.Enabled = true;
            }

        }

        private void CheckAllFilled()
        {
            // Check if all textboxes are filled

            bool allTextboxesFilled = false;

            if (ResistorsNumber.Value == 2)
            {
                allTextboxesFilled = !string.IsNullOrEmpty(res1.Text) && !string.IsNullOrEmpty(res2.Text);

            }
            if (ResistorsNumber.Value == 3)
            {
                allTextboxesFilled = !string.IsNullOrEmpty(res1.Text) &&
                                     !string.IsNullOrEmpty(res2.Text) &&
                                     !string.IsNullOrEmpty(res3.Text);

            }
            if (ResistorsNumber.Value == 4)
            {
                allTextboxesFilled = !string.IsNullOrEmpty(res1.Text) &&
                                      !string.IsNullOrEmpty(res2.Text) &&
                                      !string.IsNullOrEmpty(res3.Text) &&
                                      !string.IsNullOrEmpty(res4.Text);
            }

            //calculate  if all filled
           
            if (allTextboxesFilled) { calcular();}
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckAllFilled();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void TextboxOff()
        {


        }

        private void KeyNumberFilter(object sender, KeyPressEventArgs e)  // filtro de numeros e virgulas
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {

                if (e.KeyChar == '.')
                {

                    e.KeyChar = ',';
                }
                e.Handled = true;

            }

        }


        private void res1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumberFilter(sender, e); // filtro de numeros e virgulas
        }
        private void res2_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumberFilter(sender, e); // filtro de numeros e virgulas
        }

        private void res3_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumberFilter(sender, e); // filtro de numeros e virgulas
        }

        private void res4_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumberFilter(sender, e); // filtro de numeros e virgulas
        }

        private void res2_TextChanged(object sender, EventArgs e)
        {
            CheckAllFilled();
        }

        private void res2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void res3_TextChanged(object sender, EventArgs e)
        {
            CheckAllFilled();
        }

        private void res3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void NumRes_Scroll(object sender, EventArgs e)
        {
            int NumResistencias = this.ResistorsNumber.Value;
            slider.Text = "Res: " + NumResistencias.ToString();

            SliderMovement();

        }

        private void Requivalente_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAllFilled();
        }

        private void resistorConf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main windowC = new Main();
            windowC.Show();
        }
    }
}
