using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    public class LotoFacil : Jogos
    {
        public LotoFacil(int _numerosMarcados)
        {
            NumeroInicial = 1;

            NumeroFinal = 25;

            ApostaMinima = 15;

            ApostaMaxima = 20;

            NumerosMarcados = _numerosMarcados >= ApostaMinima && _numerosMarcados <= ApostaMaxima
                ? _numerosMarcados : throw new Exception("Quantidade de números marcados inválida");

        }
    }

}
