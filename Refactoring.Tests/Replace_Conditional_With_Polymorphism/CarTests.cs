using NUnit.Framework;
using System;
using Before = Replace_Conditional_With_Polymorphism.Before;
using After = Replace_Conditional_With_Polymorphism.After.Concrete;

namespace Refactoring.Tests.Replace_Conditional_With_Polymorphism
{
    public class CarTests
    {
        #region Before_Tests

        [TestCase("VW", 1.7, 150)]
        [TestCase("VW", 1.8, 200)]
        [TestCase("VW", 2.0, 250)]
        [TestCase("VW", 2.5, 300)]
        public void VerifyVWSpeed(string carType, double motorPower, int speed)
        {
            var car = new Before.Car(carType, motorPower);

            var carSpeed = car.GetSpeed();

            Assert.AreEqual(carSpeed, speed);
        }

        [TestCase("BMW", 1.7, 150)]
        [TestCase("BMW", 1.8, 225)]
        [TestCase("BMW", 2.0, 300)]
        [TestCase("BMW", 2.5, 375)]
        public void VerifyBMWSpeed(string carType, double motorPower, int speed)
        {
            var car = new Before.Car(carType, motorPower);

            var carSpeed = car.GetSpeed();

            Assert.AreEqual(carSpeed, speed);
        }

        [TestCase("DACIA", 1.8, 225)]
        [TestCase("MAZDA", 2.0, 300)]
        [TestCase("RENAULT", 2.5, 375)]
        public void VerifyThrowError(string carType, double motorPower, int speed)
        {
            var bmwCar = new Before.Car(carType, motorPower);

            var ex = Assert.Throws<Exception>(() => bmwCar.GetSpeed());

            Assert.That(ex.Message, Is.EqualTo("Car type not known"));
        }

        #endregion

        #region After_Tests

        [TestCase(1.7, 150)]
        [TestCase(1.8, 200)]
        [TestCase(2.0, 250)]
        [TestCase(2.5, 300)]
        public void VerifyVWSpeed_Refactor(double motorPower, int speed)
        {
            var car = new After.VWCar(motorPower);

            var carSpeed = car.GetSpeed();

            Assert.AreEqual(carSpeed, speed);
        }

        [TestCase(1.7, 150)]
        [TestCase(1.8, 225)]
        [TestCase(2.0, 300)]
        [TestCase(2.5, 375)]
        public void VerifyBMWSpeed_Refactor(double motorPower, int speed)
        {
            var car = new After.BMWCar(motorPower);

            var carSpeed = car.GetSpeed();

            Assert.AreEqual(carSpeed, speed);
        }

        #endregion
    }
}
