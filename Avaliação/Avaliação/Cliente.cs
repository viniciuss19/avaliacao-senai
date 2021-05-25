using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação
{
    class Cliente
    {
        private string _nome;
        private int _CPF;
        private string _telefone;
        private int _CEP;
        private string _estado;
        private string _cidade;
        private string _rua;
        private string _número;
        private string _complemento;

        private int _id;
        public int ID
        {
            get => _id;
            set => _id = value;
        }
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public int CPF
        {
            get => _CPF;
            set => _CPF = value;
        }
        public string Telefone
        {
            get => _telefone;
            set => _telefone = value;
        }

        public int CEP
        {
            get => _CEP;
            set => _CEP = value;
        }
        public string Estado
        {
            get => _estado;
            set => _estado = value;
        }
        public string Cidade
        {
            get => _cidade;
            set => _cidade = value;
        }
        public string Rua
        {
            get => _rua;
            set => _rua = value;
        }
        public string Número
        {
            get => _número;
            set => _número = value;
        }
        public string Complemento
        {
            get => _complemento;
            set => _complemento = value;
        }


        public Cliente(string nome, int cpf, string telefone, int cep, string estado, string cidade, string rua, string número, string complemento)
        {
      
            Nome = nome;
            CPF = cpf;
          Telefone = telefone;
            CEP = cep;
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Número = número;
            Complemento = complemento;
        }
    }
}
