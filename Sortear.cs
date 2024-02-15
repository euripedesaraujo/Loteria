using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    public class Sortear
    {

        public string Sorteio(Jogos _jogos) 
        {
            var _numerosSorteados = new List<int>();

            var _random = new Random();

            while (_numerosSorteados.Count < _jogos.NumerosMarcados) 
            {
                int _numeroSoteado = _random.Next(_jogos.NumeroInicial, _jogos.NumeroFinal + 1);

                if (!_numerosSorteados.Contains(_numeroSoteado))
                    _numerosSorteados.Add(_numeroSoteado);

            }

            return string.Join(" - ", _numerosSorteados.OrderBy(x=>x));
        }
    }
}
