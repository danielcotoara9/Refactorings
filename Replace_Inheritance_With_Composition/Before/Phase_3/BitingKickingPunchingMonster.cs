namespace Replace_Inheritance_With_Composition.Before.Phase_3
{
    public class BitingKickingPunchingMonster : BitingMonster
    {
        public int KickDamage { get; set; }
        public int PunchDamage { get; set; }
        public BitingKickingPunchingMonster(int hitPoints, int biteDamage, int kickDamage, int punchDamage)
            :base(hitPoints, biteDamage)
        {
            KickDamage = kickDamage;
            PunchDamage = punchDamage;
        }
    }
}
