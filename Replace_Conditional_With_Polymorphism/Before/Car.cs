using System;

namespace Replace_Conditional_With_Polymorphism.Before
{
    /// <summary>
    /// Get the speed for a specific car
    /// </summary>
    public class Car
    {
        private string Type { get; }
        private double MotorPower { get; }
        public Car(string type, double motorPower)
        {
            Type = type;
            MotorPower = motorPower;
        }

        public double GetSpeed()
        {
            if (MotorPower >= 1.8)
            {
                // Multiple if checks
                // Signs that OCP (Open Closed Principle from SOLID) is not respected here :)
                // switch = if else 
                switch (Type)
                {
                    case "VW":
                        if (MotorPower < 2.0)
                            return GetBaseSpeed();

                        if (MotorPower >= 2.0 && MotorPower < 2.5)
                            return GetBaseSpeed() + GetBaseBoost();

                        // maybe more ifs here 

                        return GetHighSpeed();

                    case "BMW":
                        if (MotorPower < 1.9)
                            return GetBaseSpeed() + GetSmallBoost();

                        if (MotorPower >= 2.0 && MotorPower < 2.5)
                            return GetBaseSpeed() + GetBigBoost();

                        // maybe more ifs here

                        return GetHighSpeed() + GetBaseBoost() + GetSmallBoost();

                    default:
                        throw new Exception("Car type not known");
                }
            }

            // maybe more ifs here

            return GetSmallSpeed();
        }

        #region Helpers

        private double GetBaseSpeed()
        {
            return 200;
        }

        private double GetSmallSpeed()
        {
            return 150;
        }

        private double GetHighSpeed()
        {
            return 300;
        }

        private double GetBigBoost()
        {
            return 100;
        }

        private double GetBaseBoost()
        {
            return 50;
        }

        private double GetSmallBoost()
        {
            return 25;
        }

        #endregion

    }
}
