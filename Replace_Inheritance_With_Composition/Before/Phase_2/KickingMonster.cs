namespace Replace_Inheritance_With_Composition.Before.Phase_2
{
    public class KickingMonster : Monster
    {
        public int KickDamage { get; set; }

        public KickingMonster(int hitPoints, int kickDamage) : base(hitPoints)
        {
            KickDamage = kickDamage;
        }
    }
}
