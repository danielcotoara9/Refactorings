using System;

namespace Replace_Constructors_With_Creation_Methods.After
{
    public class Loan
    {
        #region Properties

        private readonly double Commitment;
        private readonly double Outstanding;
        private readonly int RiskRating;
        private readonly DateTime? Maturity;
        private readonly DateTime? Expiry;
        private readonly CapitalStrategy CapitalStrategy;

        #endregion

        public Loan(double commitment, int riskRating, DateTime? maturity) 
            : this(commitment, 0.00, riskRating, maturity, null)
        {

        }

        public Loan(double commitment, int riskRating, DateTime? maturity, DateTime expiry)
            : this(commitment, 0.00, riskRating, maturity, expiry)
        {
            
        }

        public Loan(double commitment, double outstanding, int customerRating, DateTime? maturity, DateTime? expiry) 
            : this(null, commitment, outstanding, customerRating, maturity, expiry)
        {
        }

        public Loan(CapitalStrategy capitalStrategy, double commitment, int riskRating, DateTime? maturity, DateTime? expiry)
            : this(capitalStrategy, commitment, 0.00, riskRating, maturity, expiry)
        {
        }

        public Loan(CapitalStrategy capitalStrategy, double commitment, double outstanding, int riskRating, DateTime? maturity, DateTime? expiry)
        {
            this.Commitment = commitment;
            this.Outstanding = outstanding;
            this.RiskRating = riskRating;
            this.Maturity = maturity;
            this.Expiry = expiry;
            this.CapitalStrategy = capitalStrategy;

            if (capitalStrategy == null)
            {
                if (expiry == null)
                    this.CapitalStrategy = new CapitalStrategyTermLoan();
                else if (maturity == null)
                    this.CapitalStrategy = new CapitalStrategyRevolver();
                else
                    this.CapitalStrategy = new CapitalStrategyRCTL();
            }
        }
    }
}
