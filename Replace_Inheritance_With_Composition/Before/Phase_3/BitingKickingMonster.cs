namespace Replace_Inheritance_With_Composition.Before.Phase_3
{
    public class BitingKickingMonster : BitingMonster
    {
        public int KickDamege { get; set; }
        public BitingKickingMonster(int hitPoints, int biteDamage, int kickDamage)
            :base(hitPoints, biteDamage)
        {
            KickDamege = kickDamage;
        }
    }
}
