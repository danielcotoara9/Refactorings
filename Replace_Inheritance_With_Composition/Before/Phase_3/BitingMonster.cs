﻿namespace Replace_Inheritance_With_Composition.Before.Phase_3
{
    public class BitingMonster : Monster
    {
        public int BiteDamage { get; set; }

        public BitingMonster(int hitPoints, int biteDamage) : base(hitPoints)
        {
            BiteDamage = biteDamage;
        }
    }
}
