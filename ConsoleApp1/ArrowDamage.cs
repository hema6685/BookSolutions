using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WeaponDamage
{
    class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;


        private int roll;
        public int Roll
        {
            set
            {
                roll = value;
                CalculateDamage();
            }
            get
            { return roll; }
        }

        public int Damage { get; private set; }

        private bool flaming;
        public bool Flaming
        {
            set
            {
                flaming = value;
                CalculateDamage();
            }
            get { return flaming; }
        }
        private bool magic;
        public bool Magic
        {
            set
            {
                magic = value;
                CalculateDamage();
            }
            get { return magic; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startingRoll">Starting 3d6 roll</param>
        public ArrowDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }


        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);

            Debug.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }

    }
}

