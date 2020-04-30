using Replace_Conditional_With_Polymorphism.After.Abstract;
using System;

namespace Replace_Conditional_With_Polymorphism.After.Concrete
{
    public class BMWCar : Car
    {
        private double MotorPower { get; }

        public BMWCar(double motorPower)
        {
            MotorPower = motorPower;
        }

        public override double GetSpeed()
        {
            if (MotorPower < 1.8)
                return GetBaseSmallSpeed();

            if (MotorPower < 1.9)
                return GetBaseSpeed() + GetSmallBoost();

            if (MotorPower >= 2.0 && MotorPower < 2.5)
                return GetBaseSpeed() + GetBigBoost();

            return GetBaseHighSpeed() + GetBaseBoost() + GetSmallBoost();
        }

        #region Helpers

        private double GetSmallBoost()
        {
            return 25;
        }
        private double GetBigBoost()
        {
            return 100;
        }

        #endregion
    }
}
