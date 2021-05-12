using System;

namespace C__12._05_projeto_passagens_aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string[] nomePassageiros = new string[5];
            string[] origemVoos = new string[5];
            string[] destinos = new string[5];
            string[] dataVoos = new string[5];
            string[] idPassagens = new string[5];
            int cadastroSenha = 123456;
            int error = 0;
            int intencao = 1;
            var t = 0;
            // string vazio = "";


            Console.WriteLine("Bem Vindo ao Registrador de Passagens Aéreas...");


            // Validação de senha
            Console.WriteLine("Qual é a senha para inciar o cadastro");
            int senhaDigitada = int.Parse(Console.ReadLine());

            if (senhaDigitada != cadastroSenha)
            {
                error = 1;
            }

            while (error == 1)
            {
                Console.Clear();
                Console.WriteLine($"A senha digitada não é a mesma que está no banco de dados do Sistema!\nDigite a senha de cadastro novamente:");
                senhaDigitada = int.Parse(Console.ReadLine());

                if (senhaDigitada == cadastroSenha)
                {
                    error = 0;
                }
            }




            while (intencao == 1)
            {
                // Intenção
                Console.WriteLine(" O que você deseja utilizar de nosso sistema de passagens aéreas?");
                Console.WriteLine($"Cadastrar passagem (1)\nListar passagem (2)\nSair do programa(0)");
                int vontadeUsuario = int.Parse(Console.ReadLine());

                if (vontadeUsuario == 1)
                {
                    for (t = 0; t < nomePassageiros.Length; t++)
                    {
                        // Nome Passageiros
                        Console.WriteLine("\nDigite o nome do Passageiro");
                        nomePassageiros[t] = Console.ReadLine();

                        // Origens passageiro
                        Console.WriteLine("\nDe onde o passageiro está partindo?");
                        origemVoos[t] = Console.ReadLine();

                        // Destino PAssageiros
                        Console.WriteLine("\nPara aonde o passageiro deseja viajar?");
                        destinos[t] = Console.ReadLine();

                        // Data dos voos
                        Console.WriteLine("\nQual a data de partida do voo?");
                        dataVoos[t] = Console.ReadLine();

                        Console.WriteLine($"\nPassagem registrada no ID: {t}");

                        Console.WriteLine("Você deseja cadastrar mais nomes? (s/n)");
                        string continuar = Console.ReadLine().ToLower().Substring(0, 1);

                        if (continuar == "s")
                        {
                        }
                        if (continuar == "n")
                        {
                            break;
                        }

                    }
                }

                idPassagens[t] = $"\n Nome: {(nomePassageiros[t])}\n Cidade de Origem: {(origemVoos[t])}\n Cidade de Destino: {(destinos[t])}\n Data de viagem: {(dataVoos[t])}\n";

                if (vontadeUsuario == 2)
                {
                    Console.WriteLine("\nDigite qual ID de cadastro Você deseja Listar em formato x?");
                    int idPassagemLeitura = int.Parse(Console.ReadLine());
                    Console.WriteLine(idPassagens[idPassagemLeitura]);
                }
                if (vontadeUsuario == 0)
                {
                    break;
                }
            }
        }
    }
}

