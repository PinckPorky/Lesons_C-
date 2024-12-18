using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesons_C_
{
    public class Trade
    {
        #region Filds


        /// <summary>
        /// Цена
        /// </summary>

        public decimal Price = 0;


        public string SecCode = "";

        public string Classcode = "";

        public DateTime dateTime = DateTime.MinValue;

        public string Portfolio = "";



        #endregion

        #region Pro

        public decimal Volume
        {
            get
            {
                return _volume;
            }
            set
            {

            }
        }
        decimal _volume = 0;

        #endregion

    }
}
