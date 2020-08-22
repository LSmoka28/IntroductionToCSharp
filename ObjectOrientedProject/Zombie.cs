using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    class Zombie
    {

        public float zombieHP = 200;

        // Accepts an attack with the given number of damage points
        public virtual void TakeDamage(float damagePoints)
        {
            zombieHP -= damagePoints;
        }

        // Returns the damage points dealt by this attack
        public virtual float Attack()
        {
            if (IsDefeated)
            {
                return 0.0f;
            }
            else
            {
                return 10.0f;
            }
        }

        public bool IsDefeated
        {
            get
            {
                return zombieHP <= 0.0f;
            }

        }
    }
}
