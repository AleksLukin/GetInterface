using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInterface
{
    class Movement
    {
        public int move { get; set; }
        /// <summary>
        /// Появление героя
        /// </summary>
        void Appearance()
        {
            Console.WriteLine("Марио появился!");
        }
        /// <summary>
        /// Движение героя вперед - клавиша "6"
        /// </summary>
        void MoveForward()
        {
            move = int.Parse(Console.ReadLine());
            if (move == 6)
            {
                Console.WriteLine("Mario goes forward");
            }
            return;

        }
        /// <summary>
        /// Движение героя назад - клавиша "4"
        /// </summary>
        void MoveBack()
        {
            move = int.Parse(Console.ReadLine());
            if (move == 6)
            {
                Console.WriteLine("Mario goes back");
            }

        }
        /// <summary>
        /// Прыжок героя - клавиша "8"
        /// </summary>
        void Bounce()
        {
            move = int.Parse(Console.ReadLine()); 
            if (move == 8)
            {
                Console.WriteLine("Mario bouncing");
            }
        }
        /// <summary>
        /// Присел герой - клавиша "2"
        /// </summary>
        void SitDown()
        {
            move = int.Parse(Console.ReadLine());
            if (move == 2)
            {
                Console.WriteLine("Mario sit down");
            }
        }
        /// <summary>
        /// Стрельба герояс - клавиша "5"
        /// </summary>
        void Shoot()
        {
            move = int.Parse(Console.ReadLine());
            if (move == 5 )
            {
                Console.WriteLine("Mario is shooting");
            }
        }

    }
}
