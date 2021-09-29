using System;

namespace AtividadePoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("É terceirizado?");
            string res = Console.ReadLine();

            Funcionario funcionario = new Funcionario("Beto",40,8);
            Funcionario funcionarioTerceiro = new FuncionarioTerceiro("Joao",40,8,"Indra",0.2);

            if (res == "Sim")
            {
                Console.WriteLine(funcionarioTerceiro.ImprimeDados());
            }
            else
            {
                Console.WriteLine(funcionario.ImprimeDados());
            }
               
        }
    }
}
