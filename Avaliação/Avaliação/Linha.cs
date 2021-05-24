using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação
{
    class Linha
    {
        private int _id;
        private int _idcliente;
        private int _idplano;
        private int _numero;
        private DateTime _datacompra;
        private string _ativo;

        public int ID
        {
            get => _id;
            set => _id = value;
        }
        public int IDCliente
        {
            get => _idcliente;
            set => _idcliente = value;
        }
        public int IDPlano
        {
            get => _idplano;
            set => _idplano = value;
        }
        public int Número 
        {
            get => _numero;
            set => _numero = value;

        }
        
        public DateTime DataCompra
        {
            get => _datacompra;
            set => _datacompra = value;
        }
        public string Ativo
        {
            get => _ativo;
            set => _ativo = value;
        }
    }
}
