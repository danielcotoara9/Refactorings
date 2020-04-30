namespace Replace_Conditional_With_Polymorphism.After.Abstract
{
    public abstract class Car
    {
        public abstract double GetSpeed();

        protected double GetBaseSmallSpeed()
        {
            return 150;
        }

        protected double GetBaseSpeed()
        {
            return 200;
        }

        protected double GetBaseBoost()
        {
            return 50;
        }

        protected double GetBaseHighSpeed()
        {
            return 300;
        }
    }
}
