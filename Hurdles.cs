using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInterface
{
    class Hurdles:Movement
    {
        bool tube { get; set; }
        bool abyss { get; set; }
        /// <summary>
        /// на пути - труба
        /// </summary>
        protected void Tubes()
        {
            if (!tube)
            {
                Bounce();
            }
            else
            {
                MoveForward();
            }       
        }
        /// <summary>
        /// на пути - бездна
        /// </summary>
        protected void Abyss()
        {
            if (!tube)
            {
                Bounce();
            }
            else
            {
                MoveForward();
            }
        }

    }
}
