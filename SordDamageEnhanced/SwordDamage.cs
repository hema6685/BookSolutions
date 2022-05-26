using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SwordDamageEnhanced
{
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        

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
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }


        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic)
                magicMultiplier = 1.75M;
            
            Damage = BASE_DAMAGE;            
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming)
                Damage += FLAME_DAMAGE;
            

            Debug.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }
        
        /*public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
            Debug.WriteLine($"SetMagic finished: {Damage} (roll: {Roll})");
        }*/
        /*public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
            Debug.WriteLine($"SetFlaming finished: {Damage} (roll: {Roll})");
        }*/
    }
}
