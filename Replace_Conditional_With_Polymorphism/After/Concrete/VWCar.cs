using Replace_Conditional_With_Polymorphism.After.Abstract;

namespace Replace_Conditional_With_Polymorphism.After.Concrete
{
    public class VWCar : Car
    {
        private double MotorPower { get; }

        public VWCar(double motorPower)
        {
            MotorPower = motorPower;
        }

        public override double GetSpeed()
        {
            // Multiple if checks
            // Signs that OCP (Open Closed Principle from SOLID) is not respected here :)
            if (MotorPower < 1.8)
                return GetBaseSmallSpeed();

            if (MotorPower < 2.0)
                return GetBaseSpeed();

            if (MotorPower >= 2.0 && MotorPower < 2.5)
                return GetBaseSpeed() + GetBaseBoost();

            return GetBaseHighSpeed();
        }
    }
}
