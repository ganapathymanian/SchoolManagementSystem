using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagementSystem
{
    class StaffExpenses
    {
        #region Properties
        public int StaffID { get; set; }
        public decimal Balance { get; private set; }

        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void Expense(decimal amount)
        {
            Balance += amount;
        }

        public decimal Advance(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
    }
}
