using Replace_Inheritance_With_Composition.Before.Phase_3;
using Replace_Inheritance_With_Composition.Common;
using System;

namespace Replace_Inheritance_With_Composition.Before.Factory
{       
    public class MonsterFactory
    {
        public static Monster CreateMonster(MonsterType monsterType)
        {
            switch (monsterType)
            {
                case MonsterType.Horse:
                    return new BitingKickingMonster(10, 6, 6);
                case MonsterType.Orc:
                    return new BitingKickingPunchingMonster(10, 5, 5, 5);
                case MonsterType.Crocodile:
                    return new BitingMonster(10, 8);
                case MonsterType.Cow:
                    return new KickingMonster(7, 7);
                case MonsterType.MikeTyson:
                    return new BitingPunchingMonster(11, 5, 9);
                case MonsterType.Kangaroo:
                    return new KickingPunchingMonster(10, 7, 4);
                case MonsterType.MantisShrimp:
                    return new PunchingMonster(15, 15);
                default:
                    throw new ArgumentException();
            }

        }
    }
}
