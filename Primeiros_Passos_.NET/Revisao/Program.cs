using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Criando Array de alunos
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                case "1":
                    //Crianco uma instãncia de aluno
                    var aluno = new Aluno();
                    System.Console.WriteLine("Informe o nome do aluno:");
                    aluno.Nome = Console.ReadLine();

                    System.Console.WriteLine("Informe a nota do aluno:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                        aluno.Nota = nota;
                    }
                    else
                    {
                    throw new ArgumentException("A nota informada deve ser decimal");
                    } 

                    //Gravando o objeto aluno no array
                    alunos[indiceAluno] = aluno;
                    indiceAluno++;
                break;
                
                case "2":
                    foreach (var a in alunos)
                    {
                        if (!string.IsNullOrEmpty(a.Nome))
                        {
                            System.Console.WriteLine();
                            System.Console.WriteLine($"Aluno: {a.Nome}, nota: {a.Nota}"); 
                        }
                    }
                break;
                
                case "3":
                    decimal notaTotal = 0;
                    var nrAlunos = 0;
                   
                    for (int i = 0; i < alunos.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(alunos[i].Nome))
                        {
                            notaTotal = notaTotal + alunos[i].Nota;
                            nrAlunos++;
                        }
                    }
                    var mediaGeral = notaTotal/nrAlunos;
                    
                   Conceito conceitoGeral;

                    if (mediaGeral < 3)
                    {
                        conceitoGeral = Conceito.E;
                    }
                    else if (mediaGeral < 5)
                    {
                        conceitoGeral = Conceito.D;
                    }
                    else if (mediaGeral < 6 )
                    {
                        conceitoGeral = Conceito.C;
                    }                    
                    else if (mediaGeral < 8)
                    {
                        conceitoGeral = Conceito.B;
                    }
                    else
                    {
                        conceitoGeral = Conceito.A;
                    }
                    System.Console.WriteLine($"Média  Geral: {mediaGeral} - Conceito Geral: {conceitoGeral}");
               
                break; 

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Informe a opção desejada:");
            System.Console.WriteLine("1- Inserir novo alulno");
            System.Console.WriteLine("2- Listar alulnos");
            System.Console.WriteLine("3- Calcular média geral");
            System.Console.WriteLine("X- Para sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
