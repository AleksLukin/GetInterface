using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInterface
{
    class Enemies:Movement
    {
        private int point { get; set; }
        /// <summary>
        /// утки
        /// </summary>
        void Duck()
        {
            if (move==8)
            {
                Console.WriteLine("Enemy is die");
            }
            point = 200;
        }
        /// <summary>
        /// утки с крыльями
        /// </summary>
        void DuckWithWings()
        {
            point = 400;
        }
        /// <summary>
        /// круглый враг
        /// </summary>
        void RoundEnemy()
        {
            point = 100;
        }
        /// <summary>
        /// основной босс
        /// </summary>
        void HeadBoss()
        {
            point = 1000;
        }
    }
}
