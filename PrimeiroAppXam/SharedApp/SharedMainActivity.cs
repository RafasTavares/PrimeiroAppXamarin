using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedApp
{
    public class SharedMainActivity
    {
        #region Variáveis
        public int valor { get; set; }
        #endregion

        #region Aumentar Valor do Click
        public int AumentarValor()
        {
            return valor = valor + 1;
        }
        #endregion
    }

}
