using System;

namespace Homework2
{
    class GoodContainer
    {
        public Good Good { get; }

        public int Amount { get; private set; }

        public GoodContainer(Good good, int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be less than zero.");

            Good = good;
            Amount = amount;
        }

        public void Add(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be less than zero.");

            Amount += amount;
        }

        public void Reduce(int amount)
        {
            if (Amount - amount < 0)
                throw new InvalidOperationException("Not enough goods");

            Amount -= amount;
        }

        public override string ToString()
        {
            var result = $"Name: {Good.Name} Count: {Amount}";
            return result;
        }
    }

}
