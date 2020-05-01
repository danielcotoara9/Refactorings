using NUnit.Framework;
using Replace_Inheritance_With_Composition.After.Factory;
using Replace_Inheritance_With_Composition.Common;

namespace Refactoring.Tests.Replace_Inheritance_With_Composition.After
{
    public class MonsterFactoryTests
    {
        [Test]
        public void Crocodile_IsBitingMonster()
        {
            var crocodile = MonsterFactoty.CreateMonster(MonsterType.Crocodile);
            Assert.IsTrue(crocodile.CanBite);
            Assert.IsFalse(crocodile.CanKick);
            Assert.IsFalse(crocodile.CanPunch);
        }

        [Test]
        public void Horse_IsBitingKickingMonster()
        {
            var horse = MonsterFactoty.CreateMonster(MonsterType.Horse);

            Assert.IsTrue(horse.CanBite);
            Assert.IsTrue(horse.CanKick);
            Assert.IsFalse(horse.CanPunch);
        }
    }
}
