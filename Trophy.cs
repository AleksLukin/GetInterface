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
            Bounce();
            point = 200;
            
        }
        /// <summary>
        /// зонтичный гриб - спососбность стрелять
        /// </summary>
        void MushroomUmbrella()
        {
            Bounce();
            point = 400;
        }
        /// <summary>
        /// монетки
        /// </summary>
        void MoneyPenny()
        {
            Bounce();
            point = 100;
        }
    }
}
