using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePoo
{
    class FuncionarioTerceiro : Funcionario
    {
        public string EmpresaOrigem { get; set; }

        public double Taxa { get; set; }

        public FuncionarioTerceiro()
        {
        }

        public FuncionarioTerceiro(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxa)
            : base(nome, cargaHoraria, valorHora)
        {
            EmpresaOrigem = empresaOrigem;
            Taxa = taxa;
        }

        public  override double CalculaSalario()
        {
         return CargaHoraria* ValorHora *(1+Taxa);
        }

        public override string ImprimeDados()
        {

            string texto = "Nome: " + Nome +
                "\nSalario: R$" + CalculaSalario() +
                "\nNome Empresa: " + EmpresaOrigem;
            return texto;
        }
    }
}
