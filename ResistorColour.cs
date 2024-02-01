using System.Runtime;
using System.Windows.Forms;
using System.Drawing;
using static FIRST.Main;
using static System.Windows.Forms.DataFormats;
using System;

namespace FIRST
{
    public partial class ResistorColour : Form
    {
        private Color selectedColor;

        string[] calculatebtn = { "Calculate", "Calcular" };

        string[] labelres1 = { "Resistor 1", "Resistência 1" };

        string[] labelres2 = { "Resistor 2", "Resistência 2" };

        string[] labelres3 = { "Resistor 3", "Resistência 3" };

        string[] labelres4 = { "Resistor 4", "Resistência 4" };

        string[] slidertext = { "Res: 2", "Res: 2" };

        string[] outinfo = { "Equivalent Resistor: ", "Resistência Equivalente: " };
        bool precision = false;

        private int colorIndex = 0;
        private int index1 = 0;
        private int index2 = 0;
        private int index3 = 0;
        private int index4 = 0;
        private int indextol = 0;
        private int colorIndexBandstolerance = 0;
        private Color[] ColorsBands = { Color.Black, Color.Chocolate, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple, Color.LightGray, Color.White };
        private Color[] ColorsTolerance = { Color.Chocolate, Color.Red, Color.Green, Color.Blue, Color.Purple, Color.LightGray, Color.Gold, Color.Silver };
        string[] toleranceText = new string[] { "1%", "2%", "0.5%", "0.25%", "0.10%", "0.05%", "5%", "10%" };
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        //int[] numberssecondposition = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // int[] numbersthirdposition = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int digito1;
        int digito2;
        int digito3;
        int digito4;


        public ResistorColour()
        {
            InitializeComponent();
        }

        static string FormatNumber(double number)
        {
            string[] suffixes = { " ","K", "M", "G", "T" }; // Add more suffixes if needed

            int index = 0;
            while (number >= 1000 && index < suffixes.Length - 1)
            {
                number /= 1000;
                index++;
            }

            return $"{number:0.##}{suffixes[index]}";
        }

        private void ResetVariable()
        {
            index1 = 0; index2 = 0; index3 = 0; index4 = 0; indextol = 0;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ResetVariable();
            precision_or_not();
            label1.Text = " ";
        }

        public void precision_or_not()
        {
            if (bandas.Checked)   ///verify its precision or not
            {
                list4.Enabled = true;
                precision = true;
            }
            else
            {
                list4.Enabled = false;
                precision = false;
            }

        }

        private void Colourpicker(object sender, EventArgs e)
        {
            // Get the button that triggered the event
            Button button = (Button)sender;

            // Get the next color from the predefined array

            precision_or_not();


            if (button.Name == "list1")
            {
                Color nextColorBands = ColorsBands[index1];
                digito1 = numbers[index1];
                index1 = (index1 + 1) % ColorsBands.Length;
                nextColorBands = ColorsBands[index1];
                button.BackColor = nextColorBands;

            }
            if (button.Name == "list2")
            {
                Color nextColorBands = ColorsBands[index2];
                digito2 = numbers[index2];
                index2 = (index2 + 1) % ColorsBands.Length;
                nextColorBands = ColorsBands[index2];
                button.BackColor = nextColorBands;
            }
            if (button.Name == "list3")
            {
                Color nextColorBands = ColorsBands[index3];
                digito3 = numbers[index3];
                index3 = (index3 + 1) % ColorsBands.Length;
                nextColorBands = ColorsBands[index3];
                button.BackColor = nextColorBands;
            }

            if (button.Name == "list4")
            {
                Color nextColorBands = ColorsBands[index4];
                digito4 = numbers[index4];
                nextColorBands = ColorsBands[index4];
                index4 = (index4 + 1) % ColorsBands.Length;
                button.BackColor = nextColorBands;
            }
            if (button.Name == "tolerance")
            {
                Color nextColor = ColorsTolerance[indextol];
                nextColor = ColorsTolerance[indextol];
                indextol = (indextol + 1) % ColorsTolerance.Length;
                button.BackColor = nextColor;
            }



            // calculation

            if (!precision)
            {
                double result = (digito1 * 10 + digito2) * Math.Pow(10, digito3);
                label1.Text = FormatNumber(result) + "Ω" + toleranceText[indextol].ToString();



            }
            else
            {
                double result = (digito1 * 100 + digito2 * 10 + digito3 * 1) * Math.Pow(10, digito4);
                label1.Text = FormatNumber(result) + "Ω" + toleranceText[indextol].ToString();




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main windowC = new Main();
            windowC.Show();
        }

        private void tolerance_Click(object sender, EventArgs e)
        {
            Colourpicker(sender, e);
        }

        private void list1_Click(object sender, EventArgs e)
        {
            Colourpicker(sender, e);
        }

        private void list2_Click(object sender, EventArgs e)
        {
            Colourpicker(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Colourpicker(sender, e);
        }

        private void list4_Click(object sender, EventArgs e)
        {
            Colourpicker(sender, e);
        }

        private void bandas_CheckedChanged(object sender, EventArgs e)
        {

            ResetVariable();
            precision_or_not();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
