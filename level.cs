using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesons_C_
{
    public class level
    {
        #region Filds
        public level(decimal price)
        {
        pricelevel = price;
        }

        /// <summary>
        /// цена уровня
        /// </summary>
        public decimal pricelevel = 0;

        /// <summary>
        /// лот на уровень
        /// </summary>
        public decimal  lotlevel = 0;


        /// <summary>
        /// открытый обьем на уровне
        /// </summary>
        public decimal volume = 0;








        #endregion
    }
}
