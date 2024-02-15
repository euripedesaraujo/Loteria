using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loteria
{
    public class MegaSena : Jogos
    {

        public MegaSena(int _numerosMarcados)
        {
            NumeroInicial = 1;

            NumeroFinal = 60;

            ApostaMinima = 6;

            ApostaMaxima = 20;

            NumerosMarcados = _numerosMarcados >= ApostaMinima && _numerosMarcados <= ApostaMaxima 
                ? _numerosMarcados : throw new Exception("Quantidade de números marcados inválida");

        }
    }
}
