
namespace FIRST
{
    partial class Resistor
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
            label1 = new Label();
            res1 = new TextBox();
            label2 = new Label();
            res2 = new TextBox();
            res3 = new TextBox();
            label3 = new Label();
            ResistorsNumber = new TrackBar();
            Requivalente = new Label();
            slider = new Label();
            res4 = new TextBox();
            resistorConf = new ComboBox();
            label4 = new Label();
            ResistorScale = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ResistorsNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 99);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Resistencia 1";
            label1.Click += label1_Click;
            // 
            // res1
            // 
            res1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            res1.ForeColor = SystemColors.WindowText;
            res1.Location = new Point(91, 96);
            res1.Name = "res1";
            res1.Size = new Size(361, 23);
            res1.TabIndex = 2;
            res1.TextChanged += textBox1_TextChanged;
            res1.KeyPress += res1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 129);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Resistencia 2";
            label2.Click += label2_Click;
            // 
            // res2
            // 
            res2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            res2.Location = new Point(91, 126);
            res2.Name = "res2";
            res2.Size = new Size(361, 23);
            res2.TabIndex = 4;
            res2.TextChanged += res2_TextChanged;
            res2.KeyPress += res2_KeyPress;
            // 
            // res3
            // 
            res3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            res3.Location = new Point(91, 155);
            res3.Name = "res3";
            res3.Size = new Size(361, 23);
            res3.TabIndex = 6;
            res3.TextChanged += res3_TextChanged;
            res3.KeyPress += res3_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 158);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "Resistencia 3";
            label3.Click += label3_Click;
            // 
            // ResistorsNumber
            // 
            ResistorsNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ResistorsNumber.BackColor = SystemColors.ButtonHighlight;
            ResistorsNumber.LargeChange = 1;
            ResistorsNumber.Location = new Point(91, 45);
            ResistorsNumber.Maximum = 4;
            ResistorsNumber.Minimum = 2;
            ResistorsNumber.Name = "ResistorsNumber";
            ResistorsNumber.Size = new Size(176, 45);
            ResistorsNumber.TabIndex = 7;
            ResistorsNumber.TickStyle = TickStyle.Both;
            ResistorsNumber.Value = 2;
            ResistorsNumber.Scroll += NumRes_Scroll;
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
            // slider
            // 
            slider.AutoSize = true;
            slider.Location = new Point(11, 60);
            slider.Name = "slider";
            slider.Size = new Size(85, 15);
            slider.TabIndex = 10;
            slider.Text = "Resistencias: 2 ";
            slider.Click += label4_Click;
            // 
            // res4
            // 
            res4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            res4.Location = new Point(91, 184);
            res4.Name = "res4";
            res4.Size = new Size(361, 23);
            res4.TabIndex = 12;
            res4.TextChanged += textBox1_TextChanged_1;
            res4.KeyPress += res4_KeyPress;
            // 
            // resistorConf
            // 
            resistorConf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resistorConf.FormattingEnabled = true;
            resistorConf.Location = new Point(91, 12);
            resistorConf.MaxDropDownItems = 2;
            resistorConf.Name = "resistorConf";
            resistorConf.Size = new Size(361, 23);
            resistorConf.TabIndex = 13;
            resistorConf.SelectedIndexChanged += resistorConf_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 187);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 14;
            label4.Text = "Resistencia 4";
            // 
            // ResistorScale
            // 
            ResistorScale.FormattingEnabled = true;
            ResistorScale.ItemHeight = 15;
            ResistorScale.Items.AddRange(new object[] { "mΩ", "Ω", "KΩ", "MΩ", "GΩ", "TΩ" });
            ResistorScale.Location = new Point(273, 41);
            ResistorScale.Name = "ResistorScale";
            ResistorScale.Size = new Size(179, 49);
            ResistorScale.TabIndex = 15;
            ResistorScale.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.vecteezy_left_arrow_icon_png_clipart_free_23790858;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 249);
            button1.Name = "button1";
            button1.Size = new Size(49, 45);
            button1.TabIndex = 16;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Resistor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(464, 300);
            Controls.Add(button1);
            Controls.Add(ResistorScale);
            Controls.Add(label4);
            Controls.Add(resistorConf);
            Controls.Add(res4);
            Controls.Add(slider);
            Controls.Add(Requivalente);
            Controls.Add(ResistorsNumber);
            Controls.Add(res3);
            Controls.Add(label3);
            Controls.Add(res2);
            Controls.Add(label2);
            Controls.Add(res1);
            Controls.Add(label1);
            Name = "Resistor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resistor Calculator For Noobs";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ResistorsNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private Button Calcular;
        private Label label1;
        private TextBox res1;
        private Label label2;
        private TextBox res2;
        private TextBox res3;
        private TextBox res4;
        private Label label3;
        private TrackBar ResistorsNumber;
        private Label Requivalente;
        private Label slider;
        private ComboBox resistorConf;
        private Label label4;
        private ListBox listBox1;
        private ListBox ResistorScale;
        private Button button1;
    }
}
