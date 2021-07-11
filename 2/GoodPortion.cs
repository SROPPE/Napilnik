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
            if (!ContainsSameGood(portion))
                throw new ArgumentException("Cannot merge different goods.");
          
            return new GoodPortion(Good, Amount + portion.Amount); 
        }

        public GoodPortion Reduce(GoodPortion portion)
        {
            if (!ContainsSameGood(portion))
                throw new ArgumentException("Cannot reduce different goods.");

            return new GoodPortion(Good, Amount - portion.Amount);
        }

        public bool HasAmount(int amount) =>
            Amount >= amount;

        public bool ContainsSameGood(GoodPortion other) => 
            other.Good.Name == Good.Name;
    }
}
