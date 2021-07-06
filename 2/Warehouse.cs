using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework2
{
    class Warehouse
    {
        private List<GoodContainer> _goods = new List<GoodContainer>();

        public void Delive(GoodPortion portion)
        {
            var good = portion.Good;
            var amount = portion.Amount;

            var containedGood = _goods.Find(item => item.Good.Name == good.Name);

            if (containedGood == null)
                _goods.Add(new GoodContainer(good, amount));
            else
                containedGood.Add(amount);
        }

        public bool HasGood(GoodPortion portion)
        {
            var good = portion.Good;
            var amount = portion.Amount;

            return _goods.Any(contained => contained.Good.Name == good.Name && contained.Amount >= amount);
        }

        public void PickupGood(GoodPortion portion)
        {
            var good = portion.Good;
            var amount = portion.Amount;

            var containedGood = _goods.Find(item => item.Good.Name == good.Name);

            if (containedGood == null)
                throw new ArgumentException("No such good contained.");

            containedGood.Reduce(amount);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

             _goods.ForEach(good => stringBuilder.AppendLine(good.ToString()));

            return stringBuilder.ToString();
        }
    } 

}
