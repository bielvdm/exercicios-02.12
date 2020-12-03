using System;

namespace exercicios_02._12
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno aluno1 = new aluno ();
            System.Console.Write("Digite o nome do aluno: ");
            aluno1.nome=Console.ReadLine();
            
            Console.Write("Digite o curso do aluno: ");
            aluno1.curso=Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            aluno1.idade=int.Parse(Console.ReadLine());

            Console.Write("Digite o RG do aluno: ");
            aluno1.RG=int.Parse(Console.ReadLine());

            System.Console.Write("Qual é a média do aluno?");
            aluno1.mediaFinal=double.Parse(Console.ReadLine());

            System.Console.WriteLine("Qual é o valor da mensalidade?");
            aluno1.valorDaMensalidade=double.Parse(Console.ReadLine());

            Console.Write("O aluno possui bolsa? s/n ");
            string bolsa=Console.ReadLine().ToLower();

            if(bolsa=="s"){
                aluno1.bolsista=true;
            }else{
                aluno1.bolsista=false;
            }
            
            Console.WriteLine($"Aluno: {aluno1.nome}");
            Console.WriteLine($"Curso: {aluno1.curso}");
            Console.WriteLine($"Idade: {aluno1.idade}");
            Console.WriteLine($"RG: {aluno1.RG}");
            Console.WriteLine($"Média do aluno: {aluno1.mediaFinal}");
            System.Console.WriteLine(aluno1.bolsista);
            Console.WriteLine($"Mensalidade total: {mensalidadeBolsa}");
            


            
            


            
        }
    }
}
