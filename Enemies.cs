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
                Console.WriteLine("Duck is die");
                point = 200;
            }
            else if (move==5)
            {
                Console.WriteLine("Duck is die");
                point = 200;
            }
            else
            {
                Console.WriteLine("Game Over!");
            }
            
        }
        /// <summary>
        /// утки с крыльями
        /// </summary>
        void DuckWithWings()
        {
            if (move == 8)
            {
                Console.WriteLine("Duck with wings is die");
                point = 400;
            }
            else if (move == 5)
            {
                Console.WriteLine("Duck with wings is die");
                point = 200;
            }
            else
            {
                Console.WriteLine("Game Over!");
            }
        }
        /// <summary>
        /// круглый враг
        /// </summary>
        void RoundEnemy()
        {
            if (move == 8)
            {
                Console.WriteLine("Duck with wings is die");
                point = 100;
            }
            else if (move == 5)
            {
                Console.WriteLine("Duck with wings is die");
                point = 100;
            }
            else
            {
                Console.WriteLine("Game Over!");
            }
        }
        /// <summary>
        /// основной босс
        /// </summary>
        void HeadBoss()
        {
            point = 100;
            for (int i = 0; i <=10; i++)
            {
                Bounce();
                point++;
            }                  
            Console.WriteLine("You`re winner!");
        }
    }
}
