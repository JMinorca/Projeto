using System.Runtime;
using System.Windows.Forms;
using static FIRST.Main;
using static System.Windows.Forms.DataFormats;

namespace FIRST
{
    public partial class ResistorColour : Form
    {
        string[] calculatebtn = { "Calculate", "Calcular" };

        string[] labelres1 = { "Resistor 1", "Resistência 1" };

        string[] labelres2 = { "Resistor 2", "Resistência 2" };

        string[] labelres3 = { "Resistor 3", "Resistência 3" };

        string[] labelres4 = { "Resistor 4", "Resistência 4" };

        string[] slidertext = { "Res: 2", "Res: 2" };

        string[] outinfo = { "Equivalent Resistor: ", "Resistência Equivalente: " };

        public ResistorColour()
        {
            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {

            SliderMovement(); // definir o slider como 2 inicialmente
            Idioma(Main.idioma);
            EnableDisableCalculateButton(); //desativar calculo se nao estiver preenchido
            
            
        }

		public void Calcular_Click(object sender, EventArgs e)
		{
		
		
			float.TryParse(res1.Text, out float valor1);
			float.TryParse(res2.Text, out float valor2);
			float.TryParse(res3.Text, out float valor3);
			float.TryParse(res4.Text, out float valor4);
           
		
		
			double result = 0.00;
		
			//float resultado = (valor1 * valor2) / (valor1 + valor2);
			if (bandas.Checked)  // 4 bandas
			{
				
					result = (valor1 * valor2) / (valor1 + valor2);
				
				
				
		
		
			}
			if (!bandas.Checked)  // 5 bandas
			{
			
				
			}
		
			string[] ohmscales = { "mO", "O", "KO", "MO", "GO", "TO" };
		
			
		
			if (result <1000)
			{
		
				Requivalente.Text = outinfo[Main.idioma] + result.ToString("0.00") + " " + ohmscales[ResistorScale.SelectedIndex];
		
			}
		
			if (result > 999 && result < 9999999)
			{
				
				result = result / 1000;
				Requivalente.Text = outinfo[Main.idioma] + result.ToString("0.00") + " " + ohmscales[ResistorScale.SelectedIndex+1] ;
				
			}
			if (result > 999999)
			{
				
				result = result / 1000000;
				Requivalente.Text = outinfo[Main.idioma] + result.ToString("0.00") + " " + ohmscales[ResistorScale.SelectedIndex+2];
			}
		
			
		}
        public void Idioma(int language)
        {
         
        
            Calculate.Text = calculatebtn[language];
          
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

        private void EnableDisableCalculateButton()
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

            // Enable or disable the Calculate button based on the condition
            Calculate.Enabled = allTextboxesFilled;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EnableDisableCalculateButton();
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
            EnableDisableCalculateButton();
        }

        private void res2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void res3_TextChanged(object sender, EventArgs e)
        {
            EnableDisableCalculateButton();
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
            EnableDisableCalculateButton();
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
