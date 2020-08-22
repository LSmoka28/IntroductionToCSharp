using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    class ArmoredZombie : Zombie
    {
        
        public float defensePoints = 10.0f;

        public override void TakeDamage(float damagePoints)
        {
            float actualDmg = damagePoints - defensePoints;
            zombieHP -= actualDmg;
        }

    }
}
