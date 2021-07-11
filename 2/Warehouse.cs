using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework2
{
    class Warehouse
    {
        private List<GoodPortion> _goods = new List<GoodPortion>();

        public IReadOnlyList<GoodPortion> Goods => _goods;

        public void Delive(GoodPortion portion)
        {
            var index = _goods.FindIndex((goodPortion) => goodPortion.ContainsSameGood(portion));

            if (index == -1)
                _goods.Add(portion);
            else
            {
                var containedPortion = _goods[index];
                _goods[index] = containedPortion.Merge(portion);
            }
        }

        public bool HasGood(GoodPortion portion) =>
            _goods.Any(goodPortion => goodPortion.ContainsSameGood(portion) && goodPortion.HasAmount(portion.Amount));

        public void PickupGood(GoodPortion portion)
        {
            var index = _goods.FindIndex((goodPortion) => goodPortion.ContainsSameGood(portion));

            if (index == -1)
                throw new ArgumentException("No such good contained.");

            var containedPortion = _goods[index];

            try
            {         
                _goods[index] = containedPortion.Reduce(portion);
            }
            catch 
            {
                _goods.RemoveAt(index);
            }
        }
    } 
}
