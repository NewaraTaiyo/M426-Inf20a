using System;
using Payroll.ThirdParty;

namespace Payroll
{
    internal class AccountHolderAdapter : IAccountHolder
    {
        private readonly IEmployable employable;

        public AccountHolderAdapter(IEmployable employable)
        {
            this.employable = employable;
        }

        public string GetAccountDetails()
        {
            return this.employable.GetNote("AccountDetails");
        }

    }
}