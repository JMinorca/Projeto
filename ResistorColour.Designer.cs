
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
            list1 = new Button();
            list2 = new Button();
            list3 = new Button();
            tolerance = new Button();
            label1 = new Label();
            list4 = new Button();
            ((System.ComponentModel.ISupportInitialize)resistor).BeginInit();
            SuspendLayout();
            // 
            // Requivalente
            // 
            Requivalente.Location = new Point(0, 0);
            Requivalente.Name = "Requivalente";
            Requivalente.Size = new Size(100, 23);
            Requivalente.TabIndex = 23;
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
            bandas.CheckedChanged += bandas_CheckedChanged;
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
            // list1
            // 
            list1.BackColor = SystemColors.ControlLight;
            list1.FlatAppearance.BorderSize = 0;
            list1.FlatStyle = FlatStyle.Popup;
            list1.Location = new Point(77, 13);
            list1.Name = "list1";
            list1.Size = new Size(10, 69);
            list1.TabIndex = 19;
            list1.Text = "button2";
            list1.UseVisualStyleBackColor = false;
            list1.Click += list1_Click;
            // 
            // list2
            // 
            list2.FlatStyle = FlatStyle.Popup;
            list2.Location = new Point(93, 18);
            list2.Name = "list2";
            list2.Size = new Size(14, 61);
            list2.TabIndex = 20;
            list2.Text = "button3";
            list2.UseVisualStyleBackColor = false;
            list2.Click += list2_Click;
            // 
            // list3
            // 
            list3.FlatStyle = FlatStyle.Popup;
            list3.Location = new Point(113, 19);
            list3.Name = "list3";
            list3.Size = new Size(11, 60);
            list3.TabIndex = 21;
            list3.Text = "button4";
            list3.UseVisualStyleBackColor = true;
            list3.Click += button4_Click;
            // 
            // tolerance
            // 
            tolerance.FlatStyle = FlatStyle.Popup;
            tolerance.Location = new Point(145, 12);
            tolerance.Name = "tolerance";
            tolerance.Size = new Size(14, 73);
            tolerance.TabIndex = 22;
            tolerance.Text = "button5";
            tolerance.UseVisualStyleBackColor = true;
            tolerance.Click += tolerance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 135);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 24;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // list4
            // 
            list4.FlatStyle = FlatStyle.Popup;
            list4.Location = new Point(129, 18);
            list4.Name = "list4";
            list4.Size = new Size(10, 61);
            list4.TabIndex = 25;
            list4.Text = "button4";
            list4.UseVisualStyleBackColor = true;
            list4.Click += list4_Click;
            // 
            // ResistorColour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(233, 253);
            Controls.Add(list4);
            Controls.Add(label1);
            Controls.Add(tolerance);
            Controls.Add(list3);
            Controls.Add(list2);
            Controls.Add(list1);
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
        private Button list1;
        private Button list2;
        private Button list3;
        private Button tolerance;
        private Label label1;
        private Button list4;
    }
}
