using System;

namespace Homework2
{
    struct GoodPortion
    {
        public Good Good { get; }

        public int Amount { get; private set; }

        public GoodPortion(Good good, int amount)
        {
            if(amount <= 0)
                throw new ArgumentException("Amount should present natural number.");

            Good = good;
            Amount = amount;
        }

        public GoodPortion Merge(GoodPortion portion)
        {
            if (portion.Good.Name != Good.Name)
                throw new ArgumentException("Cannot merge different goods.");
          
            return new GoodPortion(Good, Amount + portion.Amount); 
        }

        public override string ToString()
        {
            var result = $"Name: {Good.Name} Count: {Amount}";
            return result;
        }

    }

}
