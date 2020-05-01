using Replace_Inheritance_With_Composition.Common;
using System;

namespace Replace_Inheritance_With_Composition.After.Factory
{
    public class MonsterFactoty
    {
        public static Monster CreateMonster (MonsterType monsterType)
        {
            Monster monster;
            switch (monsterType)
            {
                case MonsterType.Horse:
                    monster = new Monster(10);
                    // compose how the monster will behave !!!
                    monster.AddAtackType(AttackType.Biting, 6);
                    monster.AddAtackType(AttackType.Kicking, 6);
                    break;
                case MonsterType.Orc:
                    monster = new Monster(10);
                    monster.AddAtackType(AttackType.Biting, 5);
                    monster.AddAtackType(AttackType.Kicking, 5);
                    monster.AddAtackType(AttackType.Punching, 5);
                    break;
                case MonsterType.Crocodile:
                    monster = new Monster(10);
                    monster.AddAtackType(AttackType.Biting, 8);
                    break;
                case MonsterType.Cow:
                    monster = new Monster(7);
                    monster.AddAtackType(AttackType.Kicking, 7);
                    break;
                case MonsterType.MikeTyson:
                    monster = new Monster(11);
                    monster.AddAtackType(AttackType.Biting, 5);
                    monster.AddAtackType(AttackType.Punching, 9);
                    break;
                case MonsterType.Kangaroo:
                    monster = new Monster(10);
                    monster.AddAtackType(AttackType.Kicking, 5);
                    monster.AddAtackType(AttackType.Punching, 4);
                    break;
                case MonsterType.MantisShrimp:
                    monster = new Monster(15);
                    monster.AddAtackType(AttackType.Punching, 15);
                    break;

                default:
                    throw new ArgumentException();
            }
            return monster;

        }
    }
}
