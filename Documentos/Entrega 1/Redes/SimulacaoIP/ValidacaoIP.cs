using System;
using System.IO;

namespace ValidacaoIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== VALIDAÇÃO DE IP ===\n");

            // Lista de IPs autorizados
            string[] ipsAutorizados = { "192.168.1.100", "192.168.1.101", "10.0.0.50" };

            // Solicitar IP
            Console.Write("Digite o IP: ");
            string ip = Console.ReadLine();

            // Verificar se está autorizado
            bool autorizado = false;
            foreach (string ipAutorizado in ipsAutorizados)
            {
                if (ip == ipAutorizado)
                {
                    autorizado = true;
                    break;
                }
            }

            // Resultado
            if (autorizado)
            {
                Console.WriteLine("\n>>> ACESSO PERMITIDO <<<");
            }
            else
            {
                Console.WriteLine("\n>>> ACESSO BLOQUEADO <<<");
            }

            // Registrar log
            string status = autorizado ? "PERMITIDO" : "BLOQUEADO";
            string log = $"{DateTime.Now} | IP: {ip} | Status: {status}";
            File.AppendAllText("log.txt", log + Environment.NewLine);

            Console.WriteLine($"\nLog salvo: {log}");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
