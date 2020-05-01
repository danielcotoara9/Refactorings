namespace Replace_Inheritance_With_Composition.Before.Phase_3
{
    public class BitingPunchingMonster : BitingMonster
    {
        public int PunchingDamange;

        public BitingPunchingMonster(int hitPoints, int biteDamage, int punchingDamange) 
            : base(hitPoints, biteDamage)
        {
            PunchingDamange = punchingDamange;
        }
    }
}
