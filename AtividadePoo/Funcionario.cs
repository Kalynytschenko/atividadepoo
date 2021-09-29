using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePoo
{
    class Funcionario
    {
        private string _nome;

        private int _cargaHoraria;

        private double _valorHora;

        public Funcionario()
        {
        }

        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            _nome = nome;
            _cargaHoraria = cargaHoraria;
            _valorHora = valorHora;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome invalido");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public int CargaHoraria
        {
            get { return _cargaHoraria; }
            set { _cargaHoraria = value; }
        }

        public double ValorHora
        {
            get { return _valorHora; }

            set { _valorHora = value; }
        }


        public virtual double CalculaSalario()
        {
            return _cargaHoraria * _valorHora;
        }

        public virtual string ImprimeDados()
        {

            string texto="Nome: "+Nome +
                "\nSalario: R$" + CalculaSalario()+
                "\n";
            return texto;
        }
    }
}
