using NUnit.Framework;
using Replace_Inheritance_With_Composition.Before.Factory;
using Replace_Inheritance_With_Composition.Before.Phase_3;
using Replace_Inheritance_With_Composition.Common;

namespace Refactoring.Tests.Replace_Inheritance_With_Composition.Before
{
    public class MonsterFactoryTests
    {
        [Test]
        public void Crocodile_IsBitingMonster()
        {
            var crocodile = MonsterFactory.CreateMonster(MonsterType.Crocodile);
            Assert.IsTrue(crocodile is BitingMonster);
        }

        [Test]
        public void Horse_IsBitingKickingMonster()
        {
            var horse = MonsterFactory.CreateMonster(MonsterType.Horse);
            Assert.IsTrue(horse is BitingMonster);
            
            // this will fail, becasue we cannot inherit from multiples base classes in C#
            Assert.IsTrue(horse is KickingMonster);

        }
    }
}
