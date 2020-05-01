namespace Replace_Inheritance_With_Composition.Before.Phase_3
{
    public class KickingPunchingMonster : KickingMonster
    {
        public int PunchDamage;

        public KickingPunchingMonster(int hitPoints, int kickDamage, int punchDamage) 
            : base(hitPoints, kickDamage)
        {
            this.PunchDamage = punchDamage;
        }
    }
}
