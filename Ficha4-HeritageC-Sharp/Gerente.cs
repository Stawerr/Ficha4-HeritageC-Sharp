using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha4_HeritageC_Sharp
{
    class Gerente:Funcionario
    {

        public string Especialidade { get; set; }
        public int Extensao { get; set; }

        public Gerente():base()
        {

        }

        public Gerente(int id, string nome, DateTime dataNasc,string eMail, double valorHora,  string especialidade, int extensao) : base(id, nome,dataNasc,eMail,valorHora)
        {
            Especialidade = especialidade;
            Extensao = extensao;
        }
        public Gerente(Gerente g):base(g.Id, g.Nome, g.DataNasc, g.EMail, g.ValorHora)
        {
            Especialidade = g.Especialidade;
            Extensao = g.Extensao;
        }
        public override string ToString()
        {
            return base.ToString()+"\t Especialidade: " +Especialidade+"\t Extensão: "+Extensao;
        }
    }
}
