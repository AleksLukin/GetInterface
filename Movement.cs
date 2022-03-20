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
        protected void Appearance()
        {
            Console.WriteLine("Mario has appeared!");
        }
        /// <summary>
        /// Движение героя вперед - клавиша "6"
        /// </summary>
        protected void MoveForward()
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
        protected void MoveBack()
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
        protected void Bounce()
        {
            move = int.Parse(Console.ReadLine()); 
            if (move == 8)
            {
                Console.WriteLine("Mario is bouncing");
            }
        }
        /// <summary>
        /// Присел герой - клавиша "2"
        /// </summary>
        protected void SitDown()
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
        protected void Shoot()
        {
            move = int.Parse(Console.ReadLine());
            if (move == 5 )
            {
                Console.WriteLine("Mario is shooting");
            }
        }

    }
}
