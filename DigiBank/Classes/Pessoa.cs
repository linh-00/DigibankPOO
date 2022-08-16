using DigiBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public string Senha { get; private set; }
        public  IConta Conta { get; set; }
        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetCPF(string cpF)
        {
            this.CPF = cpF;

        }

        public void SetSenha(string senha)
        {
            this.Senha = senha;
        }
    }
}
