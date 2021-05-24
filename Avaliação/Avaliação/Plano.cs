using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação
{
    class Plano
    {
        private string _nomeplano;
        private string _franquiagb;
        private string _conteudosilimitados;
        private string _caracteristicas;
        private float _mensalidade;

        public string NomePlano
        {
            get => _nomeplano;
            private set => _nomeplano = value;
        }
        public string FranquiaGB
        {
            get => _franquiagb;
            set => _franquiagb = value;
        }
        public string ConteudosIlimitados
        {
            get => _conteudosilimitados;
            set => _conteudosilimitados = value;
        }
        public string Caracteristicas
        {
            get => _caracteristicas;
            set => _caracteristicas = value;
        }
        public float Mensalidade 
        {
            get => _mensalidade;
            set => _mensalidade = value;
        }
       
    }
}
