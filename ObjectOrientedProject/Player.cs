using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    class Player
    {
        public float playerHP = 100.0f;
        
        // accepts an attack with given damage points
        public void TakeDamage(float damagePoints)
        {
             playerHP -= damagePoints;
        }
        public float Attack()
        {
            if (IsDefeated)
            {
                return 0.0f;
            }
            else
            {
                return 25.0f;
            }
        }


        public void Eat(Zombie brain)
        {
            brain.TakeDamage(25.0f);
            playerHP += 25.0f;
        }
        public bool IsDefeated
        {
            get
            {
                return playerHP <= 0.0f;
            }
        }




    }
}
