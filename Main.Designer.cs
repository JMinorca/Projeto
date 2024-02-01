
namespace FIRST
{
    partial class Main
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
            languagecombobox = new ComboBox();
            resistor_calc = new Button();
            resistor_smd = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // languagecombobox
            // 
            languagecombobox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            languagecombobox.FormattingEnabled = true;
            languagecombobox.Items.AddRange(new object[] { "English", "Português" });
            languagecombobox.Location = new Point(12, 184);
            languagecombobox.MaxDropDownItems = 2;
            languagecombobox.Name = "languagecombobox";
            languagecombobox.Size = new Size(214, 23);
            languagecombobox.TabIndex = 14;
            languagecombobox.Text = "Language/Idioma";
            languagecombobox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // resistor_calc
            // 
            resistor_calc.BackgroundImage = Properties.Resources.resistor_electrical_resistance_and_conductance_electricity_electronic_symbol_electric_potential_difference_international_electrotechnical_commission_62e74f3648a308dc17ffed8243c58d55;
            resistor_calc.BackgroundImageLayout = ImageLayout.Stretch;
            resistor_calc.Location = new Point(12, 12);
            resistor_calc.Name = "resistor_calc";
            resistor_calc.Size = new Size(67, 56);
            resistor_calc.TabIndex = 15;
            resistor_calc.UseVisualStyleBackColor = true;
            resistor_calc.Click += button1_Click_2;
            // 
            // resistor_smd
            // 
            resistor_smd.BackgroundImage = Properties.Resources.resistor_electrical_resistance_and_conductance_electricity_electronic_symbol_electric_potential_difference_international_electrotechnical_commission_62e74f3648a308dc17ffed8243c58d55;
            resistor_smd.BackgroundImageLayout = ImageLayout.Stretch;
            resistor_smd.FlatStyle = FlatStyle.System;
            resistor_smd.Location = new Point(85, 12);
            resistor_smd.Name = "resistor_smd";
            resistor_smd.Size = new Size(67, 56);
            resistor_smd.TabIndex = 16;
            resistor_smd.Text = "SMD";
            resistor_smd.TextImageRelation = TextImageRelation.ImageAboveText;
            resistor_smd.UseVisualStyleBackColor = true;
            resistor_smd.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.resistor_electrical_resistance_and_conductance_electricity_electronic_symbol_electric_potential_difference_international_electrotechnical_commission_62e74f3648a308dc17ffed8243c58d55;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(158, 12);
            button3.Name = "button3";
            button3.Size = new Size(67, 56);
            button3.TabIndex = 16;
            button3.Text = "COIL";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.resistor_electrical_resistance_and_conductance_electricity_electronic_symbol_electric_potential_difference_international_electrotechnical_commission_62e74f3648a308dc17ffed8243c58d55;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(86, 81);
            button1.Name = "button1";
            button1.Size = new Size(67, 56);
            button1.TabIndex = 17;
            button1.Text = "COLOUR";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(238, 219);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(resistor_smd);
            Controls.Add(resistor_calc);
            Controls.Add(languagecombobox);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Better Than Oscilloscope.";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion
        private ComboBox languagecombobox;
        private Button resistor_calc;
        private Button resistor_smd;
        private Button button3;
        private Button button1;
    }
}
