using System;

namespace Replace_Constructors_With_Creation_Methods.Before
{
    public class Loan
    {
        #region Properties

        private readonly double Commitment;
        private readonly double Outstanding;
        private readonly int RiskRating;
        private readonly DateTime? Maturity;
        private readonly DateTime? Expiry;
        private readonly int CustomerRating;
        private readonly CapitalStrategy CapitalStrategy;

        #endregion

        public Loan(double commitment, int riskRating, DateTime maturity)
        {
            this.Commitment = commitment;
            this.RiskRating = riskRating;
            this.Maturity = maturity;
        }

        public Loan(double commitment, int riskRating, DateTime maturity, DateTime expiry)
        {
            this.Commitment = commitment;
            this.RiskRating = riskRating;
            this.Maturity = maturity;
            this.Expiry = expiry;
        }


        public Loan(double commitment, double outstanding, int customerRating, DateTime maturity, DateTime expiry)
        {
            this.Commitment = commitment;
            this.Outstanding = outstanding;
            this.CustomerRating = customerRating;
            this.Maturity = maturity;
            this.Expiry = expiry;
        }

        public Loan(CapitalStrategy capitalStrategy, double commitment, int riskRating, DateTime maturity, DateTime expiry)
        {
            this.CapitalStrategy = capitalStrategy;
            this.Commitment = commitment;
            this.RiskRating = riskRating;
            this.Maturity = maturity;
            this.Expiry = expiry;
        }

        public Loan(CapitalStrategy capitalStrategy, double commitment, double outstanding, int riskRating, DateTime maturity, DateTime expiry)
        {
            this.CapitalStrategy = capitalStrategy;
            this.Commitment = commitment;
            this.Outstanding = outstanding;
            this.RiskRating = riskRating;
            this.Maturity = maturity;
            this.Expiry = expiry;
            this.CapitalStrategy = capitalStrategy;
        }
    }
}
