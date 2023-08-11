using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecuperacaoBack.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? CNPJ { get; set; }

        public void Inserir(PessoaJuridica pj) {
            using (StreamWriter sw = new StreamWriter($"{pj.Nome}.txt")) 
            {
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.CNPJ}");
            }
        }

        public PessoaJuridica Ler(string nome) {
            PessoaJuridica pj = new PessoaJuridica();

            using (StreamReader sr = new StreamReader($"{nome}.txt")) {
                string[] atributos = sr.ReadLine()!.Split(',');

                pj.Nome = atributos[0];
                pj.Rendimento = float.Parse(atributos[1]);
                pj.CNPJ = atributos[2];
            }

            return pj;
        }
    }
}