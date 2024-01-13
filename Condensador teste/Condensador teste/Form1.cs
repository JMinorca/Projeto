using Condensador_teste.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CalculadoraCondensador
{
    public partial class FormCalculadoraCondensador : Form
    {
        private Dictionary<string, double> fatoresConversao;

        public FormCalculadoraCondensador()
        {
            InitializeComponent();

            // Inicializa os controles e fatores de conversão
            InicializarControles();
            InicializarFatoresConversao();
        }

        private void InicializarControles()
        {
            // Adiciona as opções de idioma ao ComboBox
            cmbIdioma.Items.AddRange(new string[] { "Português", "English" });

            // Define o idioma inicial
            DefinirIdioma("Português");
        }

        private void DefinirIdioma(string idioma)
        {
            // Carrega os recursos conforme o idioma escolhido
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);

            // Define o idioma para os controles adicionados manualmente
            lblCarga.Text = Resources.lblCarga_Text;
            lblUnidadeCarga.Text = Resources.lblUnidadeCarga_Text;
            lblVoltagem.Text = Resources.lblVoltagem_Text;
            lblUnidadeResultado.Text = Resources.lblUnidadeResultado_Text;
            btnCalcular.Text = Resources.btnCalcular_Text;
        }

        private void InicializarFatoresConversao()
        {
            // Define os fatores de conversão para microfarads, nanofarads e picofarads
            fatoresConversao = new Dictionary<string, double>
            {
                { "microfarads", 1.0 },
                { "nanofarads", 1e-3 },
                { "picofarads", 1e-6 }
            };
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValorCarga.Text, out double valorCarga))
            {
                string unidadeCarga = cmbUnidadeCarga.Text;
                double carga = CalcularCarga(valorCarga, unidadeCarga);
                double voltagem = double.TryParse(txtVoltagem.Text, out double valorVoltagem) ? valorVoltagem : 0;

                double capacitanciaMicrofarads = CalcularCapacitancia(carga, voltagem);

                // Converte a capacitância para a unidade escolhida pelo usuário
                string unidadeResultado = cmbUnidadeResultado.Text;
                double capacitanciaResultado = capacitanciaMicrofarads / fatoresConversao[unidadeResultado];

                lblResultado.Text = $"Resultado: {capacitanciaResultado} {unidadeResultado}";
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para a carga.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularCarga(double valor, string unidade)
        {
            // Retorna a carga em microfarads
            return valor * fatoresConversao[unidade];
        }

        private double CalcularCapacitancia(double carga, double voltagem)
        {
            // Retorna a capacitância em microfarads
            return carga / voltagem;
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Altera o idioma conforme a escolha do usuário
            string idiomaSelecionado = cmbIdioma.Text == "Português" ? "pt-BR" : "en-US";
            DefinirIdioma(idiomaSelecionado);
        }
    }
}