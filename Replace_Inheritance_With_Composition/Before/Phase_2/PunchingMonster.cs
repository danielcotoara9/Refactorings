namespace Replace_Inheritance_With_Composition.Before.Phase_2
{
    public class PunchingMonster : Monster
    {
        public int PunchDamage { get; set; }

        public PunchingMonster(int hitPoints, int punchDamage) : base(hitPoints)
        {
            PunchDamage = punchDamage;
        }
    }
}
