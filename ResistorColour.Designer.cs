
namespace FIRST
{
    partial class ResistorColour
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Requivalente = new Label();
            button1 = new Button();
            bandas = new CheckBox();
            resistor = new PictureBox();
            colorpicker = new ColorDialog();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)resistor).BeginInit();
            SuspendLayout();
            // 
            // Requivalente
            // 
            Requivalente.AutoSize = true;
            Requivalente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Requivalente.Location = new Point(91, 221);
            Requivalente.Name = "Requivalente";
            Requivalente.Size = new Size(0, 17);
            Requivalente.TabIndex = 9;
            Requivalente.Click += Requivalente_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.vecteezy_left_arrow_icon_png_clipart_free_23790858;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(8, 193);
            button1.Name = "button1";
            button1.Size = new Size(49, 45);
            button1.TabIndex = 16;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bandas
            // 
            bandas.AutoSize = true;
            bandas.Location = new Point(12, 91);
            bandas.Name = "bandas";
            bandas.Size = new Size(147, 19);
            bandas.TabIndex = 17;
            bandas.Text = "Resistência de precisão";
            bandas.UseVisualStyleBackColor = true;
            // 
            // resistor
            // 
            resistor.BackgroundImage = Properties.Resources.clipart33646711;
            resistor.BackgroundImageLayout = ImageLayout.Stretch;
            resistor.Location = new Point(12, 12);
            resistor.Name = "resistor";
            resistor.Size = new Size(210, 73);
            resistor.TabIndex = 18;
            resistor.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(78, 0);
            button2.Name = "button2";
            button2.Size = new Size(13, 85);
            button2.TabIndex = 19;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ResistorColour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(233, 253);
            Controls.Add(button2);
            Controls.Add(resistor);
            Controls.Add(bandas);
            Controls.Add(button1);
            Controls.Add(Requivalente);
            Name = "ResistorColour";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resistor Calculator For Noobs";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)resistor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private Button Calcular;
        private Label Requivalente;
        private ListBox listBox1;
        private Button button1;
        private CheckBox bandas;
        private PictureBox resistor;
        private ColorDialog colorpicker;
        private Button button2;
    }
}
