using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInterface
{
    
    class Trophy:Movement
    {
        private int point { get; set; }
        
        /// <summary>
        /// обычный гриб - увеличитель роста
        /// </summary>
        void Mushroom()
        {
            point = 200;
            
        }
        /// <summary>
        /// зонтичный гриб - спососбность стрелять
        /// </summary>
        void MushroomUmbrella()
        {
            point = 400;
        }
        /// <summary>
        /// монетки
        /// </summary>
        void MoneyPenny()
        {
            point = 100;
        }
    }
}
