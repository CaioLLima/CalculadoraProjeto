namespace CalculadoraProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simples.");
            string[] histOperacoes = new string[20];
            int contHistorico = 0;

            while (true)
            {
                Console.WriteLine("\nQual operação deseja realizar?\n 1 - Adição\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n 5 - Tabuada\n 6 - Histórico de operações\n S - Sair");
                string operacaoSelecionada = Console.ReadLine().ToUpper();

                if (operacaoSelecionada == "S")
                    break;
                else if (operacaoSelecionada == "5")
                {
                    Console.WriteLine("\nInsira o número que deseja ver a tabuada: \n");
                    int numeroTabuada = Convert.ToInt16(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
                    }
                    Console.ReadLine();
                    return;
                }
                else if (operacaoSelecionada == "6")
                {
                    Console.WriteLine("\nOperações salvas no histórico: ");
                    for (int i = 0; i < histOperacoes.Length; i++)
                    {
                        if (histOperacoes[i] != null) { 
                        Console.WriteLine($"{histOperacoes[i]}");
                    }
                    }
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("\nInsira o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nInsira o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                double resultOperacao = 0;

                switch (operacaoSelecionada)
                {
                    case "1":
                        resultOperacao = numero1 + numero2;
                        histOperacoes[contHistorico] = $"\n{numero1} + {numero2} = {resultOperacao}";
                        break;
                    case "2":
                        resultOperacao = numero1 - numero2;
                        histOperacoes[contHistorico] = $"\n{numero1} - {numero2} = {resultOperacao}";
                        break;
                    case "3":
                        resultOperacao = numero1 * numero2;
                        histOperacoes[contHistorico] = $"\n{numero1} x {numero2} = {resultOperacao}";
                        break;
                    case "4":
                        if (numero2 == 0)
                        {
                            Console.WriteLine("O número 0 é inválido. Digite outro número.");
                            numero2 = Convert.ToDouble(Console.ReadLine());
                        }
                        resultOperacao = numero1 / numero2;
                        histOperacoes[contHistorico] = $"\n{numero1} / {numero2} = {resultOperacao}";
                        break;
                    case "5":
                        Console.WriteLine("O número 0 é inválido. Digite outro número.");
                        break;
                }

                Console.WriteLine("\nResultado: " + resultOperacao);

                Console.WriteLine("\nDeseja realizar outra operação? (s/n)");
                string continua = Console.ReadLine();

                Console.Clear();

                if (continua == "n")
                    break;
                if (continua == "s")
                    contHistorico++;
                continue;

            }
        }
    }
}
