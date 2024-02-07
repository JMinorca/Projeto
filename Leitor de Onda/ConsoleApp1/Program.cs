using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        Process gnuplotProcess = new Process();
        gnuplotProcess.StartInfo.FileName = "gnuplot";
        gnuplotProcess.StartInfo.UseShellExecute = false;
        gnuplotProcess.StartInfo.RedirectStandardInput = true;

        try
        {
            gnuplotProcess.Start(); // Inicia o processo do Gnuplot

            StreamWriter gnuplotStreamWriter = gnuplotProcess.StandardInput;

            if (gnuplotStreamWriter != null)
            {
                double amplitude, frequencia, intervalo;
                char tipoOnda;

                // Solicitar informações ao usuário
                Console.Write("Digite a amplitude da onda: ");
                amplitude = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a frequência da onda em Hz: ");
                frequencia = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o intervalo de tempo em segundos: ");
                intervalo = Convert.ToDouble(Console.ReadLine());

                // Solicitar o tipo de onda ao usuário
                Console.Write("Escolha o tipo de onda (s para senoidal, t para triangular, q para quadrada): ");
                tipoOnda = Convert.ToChar(Console.ReadLine());

                gnuplotStreamWriter.WriteLine("set term wxt"); // Abre a janela de gráficos do Gnuplot

                // Comando Gnuplot para plotar a onda escolhida
                gnuplotStreamWriter.WriteLine("plot '-' with lines title 'Onda'");

                // Gera pontos para a onda e envia para o Gnuplot com base no tipo escolhido
                for (double tempo = 0; tempo <= intervalo; tempo += 0.01)
                {
                    double y;

                    switch (tipoOnda)
                    {
                        case 's': // Senoidal
                            y = amplitude * Math.Sin(2 * Math.PI * frequencia * tempo);
                            break;
                        case 't': // Triangular
                            y = amplitude * (2.0 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * frequencia * tempo));
                            break;
                        case 'q': // Quadrada
                            y = amplitude * Math.Sign(Math.Sin(2 * Math.PI * frequencia * tempo));
                            break;
                        default:
                            Console.WriteLine("Tipo de onda não reconhecido.");
                            gnuplotProcess.StandardInput.Close();
                            gnuplotProcess.WaitForExit();
                            return;
                    }

                    gnuplotStreamWriter.WriteLine($"{tempo.ToString(System.Globalization.CultureInfo.InvariantCulture)} {y.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
                }

                gnuplotStreamWriter.WriteLine("e"); // Indica o final dos dados para o Gnuplot

                // Adiciona um comando para pausar a execução e manter a janela aberta
                gnuplotStreamWriter.WriteLine("pause mouse key");
                gnuplotStreamWriter.Flush();

                // Aguarda pressionar Enter antes de fechar a janela
                Console.WriteLine("Pressione Enter para sair...");
                Console.ReadLine();

                gnuplotProcess.StandardInput.Close();
                gnuplotProcess.WaitForExit(); // Aguarda o processo Gnuplot ser concluído
            }
            else
            {
                Console.WriteLine("Erro ao obter o fluxo de entrada para o Gnuplot.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        finally
        {
            gnuplotProcess.Close();
        }
    }
}
