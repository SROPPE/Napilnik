using System;
using System.Collections.Generic;

namespace Homework2
{
    class Cart
    {
        private readonly Shop _shop;

        private List<GoodPortion> _reservedGoods = new List<GoodPortion>();

        public IReadOnlyList<GoodPortion> ReservedGoods => _reservedGoods;

        public Cart(Shop shop)
        {
            _shop = shop ?? throw new ArgumentNullException(nameof(shop));
        }

        public void Add(Good good, int count)
        {
            var portion = new GoodPortion(good, count);
          
            _shop.Reserve(portion);
            
            var index = _reservedGoods.FindIndex((goodPortion) => goodPortion.ContainsSameGood(goodPortion));

            if (index == -1)
                _reservedGoods.Add(portion);
            else
                _reservedGoods[index] = _reservedGoods[index].Merge(portion);
        }

        public Order Order()
        {
            return new Order(this);
        }
    }
}
