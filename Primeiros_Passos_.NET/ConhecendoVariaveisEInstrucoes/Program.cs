using System;

namespace ConhecendoVariaveisEInstrucoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int item;

            System.Console.WriteLine("Lista de instruções:");
            Console.WriteLine();

        string[] list = new string[] {"00 - Declaração de Variaveis","01 - Instrução IF", "02 - Instrução Switch","03 - Instrução while",
        "04 - Instrução For", "05 - Instrução DO","06 - Instrução Foreach", "07 - Instrução Break","08 - Instrução Continue",
        "09 - Instrução Return","10 - Instrução Try Cath Finally Throw","11 - Intrução Using"};
            {
            
                foreach(string titulo in list)
                {
                Console.WriteLine(titulo);
                }

                System.Console.WriteLine();
                Console.WriteLine("Digite o número da opção que você quer utilizar: ");
                item = int.Parse(Console.ReadLine());
               
                int switch_case = item;
                
                switch (switch_case )
                {
                    case 0:
                        System.Console.WriteLine("\n");
                        System.Console.WriteLine($"Opção digitada: {item} -  {list[item]}.\n");
                        DeclaracaoDeVariaveis();
                    break;

                    case 1:
                        System.Console.WriteLine("\n");
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.\n");
                        InstrucaoIF();
                    break;

                     case 2:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.\n");
                        InstrucaoSwitch();
                    break;

                     case 3:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.\n");
                        InstrucaoWhile();
                    break;

                     case 4:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.\n");
                        InstrucaoFor();
                    break;

                    case 5:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.\n");
                        InstrucaoDo();                    
                    break;

                    case 6:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.'\n");
                        InstrucaoForeach();
                    break;

                    case 7:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.\n");
                        InstrucaoBreak();
                    break;
                    
                    case 8:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.\n");
                        InstrucaoContinue();
                    break;
                    
                    case 9:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.\n");
                        InstrucaoReturn();
                    break;

                    case 10:
                        System.Console.WriteLine($"Opção digitada: {item} - {list[item]}. \n");
                        InstrucaoTryCatchFinallyThrown();
                    break;

                    // case 11:
                    //     System.Console.WriteLine($"Opção digitada: {item} - {list[item]}.  \n");
                    //     InstrucaoUsing();
                    // break;
                }
            }
        }

        static void DeclaracaoDeVariaveis(){
            int a;
            int b = 2, c = 3;
            const int d = 4;

            a = 1;
            System.Console.WriteLine($"{a}(a)+{b}(b)+{c}(c)+{d}(d) = {a+b+c+d}");

        }

        static void InstrucaoIF(){
            System.Console.WriteLine("Entre com dois valores e eu direi qual é o maior.");

            System.Console.WriteLine("Entre com o primeiro valor:");
            int x = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre co o segundo valor:");
            int y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                System.Console.WriteLine($"O número {x} é o maior");
            }
            else if (y == x)
            {
                System.Console.WriteLine($"Os valore são iguais: {x} e {y}");
            }
            else
            {
                System.Console.WriteLine($"O valor {y} é o maior.");
            }
        }

        static void InstrucaoSwitch(){
        System.Console.WriteLine("Sobre qual sistema operacional de Smartphone você gostaria de obter informações, ANDROID ou IOS?");       
        string switch_on = Console.ReadLine();

        if (switch_on == "ANDROID" || switch_on == "IOS")
        {
            switch (switch_on)
            {
                case "ANDROID":
                    System.Console.WriteLine("ANDROID - O Android permite que o usuário altere praticamente todos os pontos de uso do sistema. Com isso, é possível definir aplicativos padrões que sejam diferentes daqueles que a fabricante ou o Google oferecem. Na tela inicial, por exemplo, você pode escolher diferentes launchers — softwares que habilitam a customização no sistema — e deixar o seu smartphone mais personalizado.");
                break;

                case "IOS":
                    System.Console.WriteLine("IOS  - O iOS é fabricado para ser um sistema simples. Dessa forma, não é necessário perder tempo personalizando o aparelho, pois o seu visual é mais limpo e fácil de mexer do que o Android. Essa é uma grande vantagem para quem gosta de simplesmente ligar o celular e começar a usar.");
                break;
            }
        }
        else
        {
            System.Console.WriteLine("Você escolheu um sistema inválido, digite 'ANDRIOD' ou 'IOS'");
        }
        
        }

        static void InstrucaoWhile()
        {
        System.Console.WriteLine("Escolha o número que você gostaria de saber a tabuada (de 1 a 10).");
        int d = int.Parse(Console.ReadLine());
        System.Console.WriteLine();    
        
            if (d > 0 && d < 11)
            {
                    int i = 1;
                    while (i < 11)
                {
                    System.Console.WriteLine($"{d} x {i} = {d * i}");
                    i++;
                }    
            }
        }

        static void InstrucaoFor()
        {
            System.Console.WriteLine("Entre com o valor aplicado:");
            double principal = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com a quantidade de meses que o valor será aplicado:");
            int meses = int.Parse(Console.ReadLine());

            for (int i = 0; i < meses; i++)
            {
                int parc = i + 1;

                //calculo de juros
                double juros = (0.0033 * principal);

                //somar juros + principal
                principal = juros + principal;

                System.Console.WriteLine($"Mês: {parc} - R$: {Math.Round(principal,2)}");
            }
        }

        static void InstrucaoDo()
        {
            System.Console.WriteLine("Qual a quantidade de lixo inserido?");
            int qtde_lixo = int.Parse(Console.ReadLine());
            
            do
            {   System.Console.WriteLine();
                System.Console.WriteLine("Executando insineração!");
                
                qtde_lixo--;
                
                System.Console.WriteLine($"Quantidade de lixo restante: {qtde_lixo}");
            } while (qtde_lixo > 0);
            System.Console.WriteLine();
            System.Console.WriteLine("Insineração finalizada, volte sempre.");
        }

        static void InstrucaoForeach(){

           string[] paises = new string[] {"Brasil", "Alemanha", "México","Chile", "Holanda", "Colômbia","Argentina", "Uruguai"}; 

           System.Console.WriteLine("Informe a primeira letra do País que deseja pesquisar:");
            string letra = Console.ReadLine();

           foreach (var i_letra in paises)
           {
               if (i_letra.ToUpper().StartsWith(letra))
               {
                System.Console.WriteLine(i_letra);   
               }
           }

        }

        static void InstrucaoBreak()
        {
            System.Console.WriteLine("Parcelas");
            int parc = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            for (int i = 0; i < parc; i++)
            {
                if (parc > 24)
                {
                    System.Console.WriteLine("Permitido até 24 parcelas.");  
                    break;
                }
                 int parcc = i+1;
                 System.Console.WriteLine(parcc);
            }
        }

        static void InstrucaoContinue()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i < 10 || i > 90)
                {
                    continue;
                }
                Console.WriteLine(i);
            }   
         }

         static void InstrucaoReturn()
         {
             System.Console.WriteLine("Deseja chamar o método soma? (SIM/ NÂO)");
             string chama_metodo = Console.ReadLine();
               
                if (chama_metodo == "SIM")
                {
                    System.Console.WriteLine("Digite o primeiro número.");
                    int a = int.Parse(Console.ReadLine());

                     System.Console.WriteLine("Digite o segundo número.");
                    int b = int.Parse(Console.ReadLine());
                    
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Resultado: {Soma(a, b)}");
                }
                System.Console.WriteLine("Saindo do programa.");

                static int Soma(int a, int b)
                    {
                        return a + b;
                    }
         }

         static void InstrucaoTryCatchFinallyThrown()
             {
                 try
                 {
                double a, b;
                a = 3;
                b = 1;

                double result = a / b;

                 if (b == 0)
                 {
                    throw new DivideByZeroException("Não é possível dividir por 0.");
                 }

                 if (a == 3)
                 {
                     throw new InvalidOperationException("Operação inválida.");
                 }

                 System.Console.WriteLine(result);
                     
                 }
                 catch (DivideByZeroException e)
                 {
                    System.Console.WriteLine(e.Message);                     
                 }
                 
                  catch (InvalidOperationException e)
                 {
                    System.Console.WriteLine(e.Message);                     
                 }
            }

        static void InstrucaoUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("Teste.txt"))
        {
            w.WriteLine("Linha 1");
            w.WriteLine("Linha 2");
            w.WriteLine("Linha 3");
        }
        }
    }
}