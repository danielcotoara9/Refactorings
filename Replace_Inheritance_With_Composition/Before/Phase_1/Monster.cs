namespace Replace_Inheritance_With_Composition.Before.Phase_1
{
    public class Monster
    {
        public int HitPoints { get; set; }
        public int AttackDamage { get; set; }

        public Monster(int hitPoints, int attackDamage)
        {
            HitPoints = hitPoints;
            AttackDamage = attackDamage;
        }
    }

}
