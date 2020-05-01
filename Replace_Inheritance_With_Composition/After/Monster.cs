using System;
using System.Collections.Generic;

namespace Replace_Inheritance_With_Composition.After
{
    public enum AttackType
    {
        Biting,
        Kicking,
        Punching
    }

    public class Monster
    {

        public int HitPoints { get; set; }
        // Dictionary 
        // Key - AttackType = attack type
        // value - int = amount of the damage
        // This example of composition is did with this Dictionary. This is not a must ! 
        public Dictionary<AttackType, int> AttackTypes { get; set; }

        public Monster(int hitPoints)
        {
            HitPoints = hitPoints;
            AttackTypes = new Dictionary<AttackType, int>();
        }

        // These replace the functionality of checking an object type
        // IS-A KickingMonster, PunchingMonster, ....
        public bool CanBite => AttackTypes.ContainsKey(AttackType.Biting);
        public bool CanKick => AttackTypes.ContainsKey(AttackType.Kicking);
        public bool CanPunch => AttackTypes.ContainsKey(AttackType.Punching);


        public int BiteDamage
        {
            get 
            {
                if (CanBite) {
                    // return the amount of damage
                    return AttackTypes[AttackType.Biting];
                }
                  
                throw new NotSupportedException("This monster cannot bite");
            }
        }

        public int KickDamage
        {
            get
            {
                if (CanKick) {
                    // return the amount of damage
                    return AttackTypes[AttackType.Kicking];
                }

                throw new NotSupportedException("This monster cannot kick");
            }
        }

        public int PunchDamage
        {
            get
            {
                if (CanPunch) {
                    // return the amount of damage
                    return AttackTypes[AttackType.Punching];
                }
                throw new NotSupportedException("This monster cannot punch");
            }
        }

        public void AddAtackType(AttackType attackType, int amountOfDamage)
        {
            AttackTypes[attackType] = amountOfDamage;
        }

    }
}
