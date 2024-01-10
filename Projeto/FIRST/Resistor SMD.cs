using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static FIRST.Main;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;



namespace FIRST
{
    public partial class ResistorSMD : Form
    {
        private string key; //handler de tecla

        char[] palavra = new char[5] { ' ', ' ', ' ', ' ', ' ' };

        public ResistorSMD()
        {
            InitializeComponent();
        }
        public void Idioma()
        {

            //int language = SharedData.SharedLanguage;

        }

        private void Reset()
        {
            btnRcolumn3.Enabled = true;
            btnRcolumn2.Enabled = true;

            btn0column4.Enabled = true;
            btn1column4.Enabled = true;
            btn2column4.Enabled = true;
            btn3column4.Enabled = true;
            btn4column4.Enabled = true;
            btn5column4.Enabled = true;
            btn6column4.Enabled = true;
            btn7column4.Enabled = true;
            btn8column4.Enabled = true;
            btn9column4.Enabled = true;

            btn0column3.Enabled = true;
            btn1column3.Enabled = true;
            btn2column3.Enabled = true;
            btn3column3.Enabled = true;
            btn4column3.Enabled = true;
            btn5column3.Enabled = true;
            btn6column3.Enabled = true;
            btn7column3.Enabled = true;
            btn8column3.Enabled = true;
            btn9column3.Enabled = true;

            btnAcolumn5.Enabled = true;
            btnBcolumn5.Enabled = true;
            btnCcolumn5.Enabled = true;
            btnDcolumn5.Enabled = true;
            btnEcolumn5.Enabled = true;
            btnFcolumn5.Enabled = true;
            btnHcolumn5.Enabled = true;
            btnRcolumn5.Enabled = true;
            btnScolumn5.Enabled = true;
            btnXcolumn5.Enabled = true;
            btnYcolumn5.Enabled = true;
            btnZcolumn5.Enabled = true;

        }

        private void ButtonUnlock()
        {
            foreach (Control control in Controls)
            {


                if (control is Button button)
                {

                    button.Enabled = true; // activar botoes

                }
            }

        }

        private void SetColorsAfterclean()
        {
            foreach (Control control in Controls)
            {


                if (control is Button button)
                {

                    if (button.Enabled == true)
                    {
                        button.BackColor = SystemColors.Control;
                    }

                }
            }
        }

        private void KeysLock()
        {


            if (SMDProtocol.SelectedIndex == 0)
            {
                btnRcolumn3.Enabled = false;


                btn0column4.Enabled = false;
                btn1column4.Enabled = false;
                btn2column4.Enabled = false;
                btn3column4.Enabled = false;
                btn4column4.Enabled = false;
                btn5column4.Enabled = false;
                btn6column4.Enabled = false;
                btn7column4.Enabled = false;
                btn8column4.Enabled = false;
                btn9column4.Enabled = false;

                btnAcolumn5.Enabled = false;
                btnBcolumn5.Enabled = false;
                btnCcolumn5.Enabled = false;
                btnDcolumn5.Enabled = false;
                btnEcolumn5.Enabled = false;
                btnFcolumn5.Enabled = false;
                btnHcolumn5.Enabled = false;
                btnRcolumn5.Enabled = false;
                btnScolumn5.Enabled = false;
                btnXcolumn5.Enabled = false;
                btnYcolumn5.Enabled = false;
                btnZcolumn5.Enabled = false;

            }

            if (SMDProtocol.SelectedIndex == 1)
            {

                btnAcolumn5.Enabled = false;
                btnBcolumn5.Enabled = false;
                btnCcolumn5.Enabled = false;
                btnDcolumn5.Enabled = false;
                btnEcolumn5.Enabled = false;
                btnFcolumn5.Enabled = false;
                btnHcolumn5.Enabled = false;
                btnRcolumn5.Enabled = false;
                btnScolumn5.Enabled = false;
                btnXcolumn5.Enabled = false;
                btnYcolumn5.Enabled = false;
                btnZcolumn5.Enabled = false;
            }

            if (SMDProtocol.SelectedIndex == 2)
            {
                btnRcolumn2.Enabled = false;

                btn0column3.Enabled = false;
                btn1column3.Enabled = false;
                btn2column3.Enabled = false;
                btn3column3.Enabled = false;
                btn4column3.Enabled = false;
                btn5column3.Enabled = false;
                btn6column3.Enabled = false;
                btn7column3.Enabled = false;
                btn8column3.Enabled = false;
                btn9column3.Enabled = false;
                btnRcolumn3.Enabled = false;

                btn0column4.Enabled = false;
                btn1column4.Enabled = false;
                btn2column4.Enabled = false;
                btn3column4.Enabled = false;
                btn4column4.Enabled = false;
                btn5column4.Enabled = false;
                btn6column4.Enabled = false;
                btn7column4.Enabled = false;
                btn8column4.Enabled = false;
                btn9column4.Enabled = false;


            }
        }

        public void KeyHandler(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; ButtonColumn_Click(sender, e, clickedButton.Text);
        }

        private void button2_Click(object sender, EventArgs e) // back button
        {

            this.Hide();
            Main windowC = new Main();
            windowC.Show();
        }


        private void KeyPressed()
        {
            // SMDscreen.Text = SMDscreen.Text + key; // escrever no display
            string valor = new string(' ', 5);
            // valor = SMDscreen.Text; // valor concatenado


            string[] ohmscales = { "mΩ", "Ω", "KΩ", "MΩ", "GΩ", "TΩ" };

            if (valor.Length >= 3)
            {
                char firstChar = valor[0];
                char secondChar = valor[1];
                char multiplierChar = valor[2];

                bool smallres = false;

                int firstdigit;
                int seconddigit;
                int multiplier;



                if (secondChar == 'R') // verifica se foi introduzido "R"
                {

                    smallres = true;
                    secondChar = '0';

                }

                firstdigit = int.Parse(firstChar.ToString());      //recolha de digitos inseridos
                seconddigit = int.Parse(secondChar.ToString());    //recolha de digitos inseridos
                multiplier = int.Parse(multiplierChar.ToString()); //recolha de digitos inseridos

                int m;
                double r;

                if (smallres == false) // verifica se foi introduzido "R"
                {
                    m = (int)Math.Pow(10, multiplier);   // recolha de expoente
                    r = (seconddigit + ((firstdigit * 10)) * m);
                    // Output.Text = r.ToString("");

                    // if (divideten==true) {r = r/10;}

                    if (r < 1)
                    {

                        Output.Text = r.ToString("0.00") + " " + ohmscales[0];

                    }

                    if (multiplier < 2 && r > 1)
                    {

                        Output.Text = r.ToString("0.00") + " " + ohmscales[1];

                    }

                    if (multiplier >= 2 && multiplier < 5)
                    {

                        r = r / 1000;
                        Output.Text = r.ToString("0.00") + " " + ohmscales[1 + 1];

                    }
                    if (multiplier >= 5 && multiplier < 9)
                    {

                        r = r / 1000000;
                        Output.Text = r.ToString("0.00") + " " + ohmscales[1 + 2];
                    }

                    if (multiplier > 9 && multiplier < 12)
                    {

                        r = r / 1000000000;
                        Output.Text = r.ToString("0.000") + " " + ohmscales[1 + 3];
                    }


                }

                else
                {

                    r = firstdigit + multiplier * 0.1;
                    Output.Text = r.ToString("0.00") + " " + ohmscales[1];
                }



                // Now you have the integer values stored in firstdigit, seconddigit, and multiplier variables
            }
            else
            {
                // Handle situations where valor doesn't contain enough characters
            }



        }

        private void ClearDisplay()
        {


            SMDscreen.Text = string.Empty; // limpa string
            string valor = string.Empty; // limpa string
            Output.Text = string.Empty;
            palavra = new char[5] { ' ', ' ', ' ', ' ', ' ' };


        }


private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
            KeysLock();
            ClearDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SMDscreen_Click(object sender, EventArgs e)
        {

        }

        public void SMD_Calculation() 
        {

            

            Output.Text = " ";
            int protocol = SMDProtocol.SelectedIndex;
            int lenght = palavra.Length; // determinar tamanho
            string[] ohmscales = { "mΩ", "Ω", "KΩ", "MΩ", "GΩ", "TΩ" };
            int i = 1;
            double resultint = 0;
            int digito1 = palavra[0] - '0';
            int digito2 = palavra[1] - '0';
            int digito4 = palavra[3] - '0';
            int digito3 = palavra[2] - '0';

            switch (protocol)
            {

                case 0: /// resitencia 102
                    { 
                        if (palavra[0]!=' ' && palavra[1] != ' ' && palavra[2] != ' ' && protocol ==0) 
                        {
                          
                            if (palavra[1] != 'R')
                            {
                                resultint = ((digito1 * 10) + (digito2)) * Math.Pow(10, digito3);
                                double resultfinal = 0;
                                if (resultint < 999) { i = 1; resultfinal = resultint;}
                                if (resultint > 999 && resultint < 999999) { i = 2; resultfinal = resultint / Math.Pow(10, 3); }
                                if (resultint > 999999 && resultint < 999999999) { i = 3; resultfinal = resultint / Math.Pow(10, 6); }
                                if (resultint > 999999999 && resultint < 999999999999) { i = 4; resultfinal = resultint / Math.Pow(10, 9); }
                                if (resultint > 999999999999 && resultint < 999999999999999) { i = 5; resultfinal = resultint / Math.Pow(10, 12); }
                                Output.Text = resultfinal.ToString("0.0") + " " + ohmscales[i];
                            }

                            else 
                            {
                                Output.Text = digito1.ToString("0") + "." + digito3.ToString("0") + ohmscales[i];
                            }
                           
                            

                            

                        } 
                    } break;
                case 1: // resistencia 1002
                    {
                        if (palavra[0] != ' ' && palavra[1] != ' ' && palavra[2] != ' ' && palavra[3] != ' ' && protocol == 1)
                        {
                            if (palavra[1]!='R')
                            {

                                resultint = (digito1 * 100 + digito2 * 10 + digito3 * 1) * Math.Pow(10, digito4);
                                double resultfinal = 0;
                                if (resultint < 999) { i = 1; resultfinal = resultint; }
                                if (resultint > 999 && resultint < 999999) { i = 2; resultfinal = resultint / Math.Pow(10, 3); }
                                if (resultint > 999999 && resultint < 999999999) { i = 3; resultfinal = resultint / Math.Pow(10, 6); }
                                if (resultint > 999999999 && resultint < 999999999999) { i = 4; resultfinal = resultint / Math.Pow(10, 9); }
                                if (resultint > 999999999999 && resultint < 999999999999999) { i = 5; resultfinal = resultint / Math.Pow(10, 12); }

                                Output.Text = resultfinal.ToString("0.0") + " " + ohmscales[i];



                            }
                            if (palavra[1]=='R')
                            {
                                Output.Text = digito1.ToString("0") + "." + digito3.ToString("0") + digito4.ToString("0") + ohmscales[i];
                            }
                            if (palavra[2] =='R')
                            {
                                Output.Text = digito1.ToString("0") + digito2.ToString("0") + "." + digito4.ToString("0") + ohmscales[i];
                            }

                            if (palavra[1] == 'R' && palavra[2] == 'R')
                            {
                                Output.Text = "ERROR";
                            }
                        }
                    }
                    break;
                case 2: // resistencia 10C
                    {
                        if (palavra[0] != ' ' && palavra[1] != ' ' && palavra[4] != ' ' && protocol == 2)
                        {
                            
                                    
                                        
                                    
                            


                            Output.Text = resultint.ToString("0") + " " + ohmscales[i];
                        }
                    }
                    break;


                default: { } break;
            }
          



        }
   
        private void ResistorSMD_Load(object sender, EventArgs e)
        {
            Idioma(); // aplicar idioma
            SMDProtocol.SelectedIndex = 0; // definir configuração original como 3EIA
            KeysLock();
           
          
        }


        private void ButtonColumn_Click(object sender, EventArgs e, string keyValue)
        {
            key = keyValue;
           
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                char Column;

                foreach (Control control in Controls)
                {
                    if (control is Button button)
                    {
                        Column = clickedButton.Name[clickedButton.Name.Length-1]; // Extract the column number

                        if (button.Name.EndsWith($"column{Column}")) // Check the column
                        {
                            int columnIndex = int.Parse(Column.ToString()); // Convert char to int for array indexing
                            palavra[columnIndex-1] = clickedButton.Text[0]; // Store the text in the respective column
                      
                        }
                    }
                }
                string word = new string(palavra);

                SMDscreen.Text = word; // valor concatenado

                word = string.Empty;

                SMD_Calculation();  // calculo smd
                

            }
        }


        private void btnreset(object sender, EventArgs e)
        {


            ClearDisplay();
            string filePath = "C:\\Users\\rafgoncalves\\Desktop\\APP\\eia96.csv";
            string ColumnName = "Value";
            ReadCSV(filePath);
        }

        private void Output_Click(object sender, EventArgs e)
        {

        }



        private void ReadCSV(string filePath)
        {
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.FixedWidth;

                // Define the widths of each column (adjust these values as per your file's structure)
                parser.FieldWidths = new int[] {2, 3}; // Example widths: column 1 (20 characters), column 2 (15 characters), column 3 (30 characters)

                int lineCount = 0; // Track line number for debugging

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    lineCount++;

                    // Output fields and line number for debugging
                    Console.Write($"Line {lineCount}: ");
                    foreach (string field in fields)
                    {
                        Console.Write($"{field}\t"); // Outputting fields to the console
                    }
                    Console.WriteLine(); // Move to the next line for the next row
                }
            }
        }



    }

  

}

