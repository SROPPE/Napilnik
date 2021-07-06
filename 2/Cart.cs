using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class Cart
    {
        private readonly Shop _shop;

        private List<GoodPortion> _reservedGoods = new List<GoodPortion>();

        public Cart(Shop shop)
        {
            _shop = shop ?? throw new ArgumentNullException(nameof(shop));
        }

        public void Add(Good good, int count)
        {
            var goodPortion = new GoodPortion(good, count);

            try
            {
                _shop.Reserve(goodPortion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            var index = _reservedGoods.FindIndex((request) => request.Good.Name == good.Name);

            if (index == -1)
                _reservedGoods.Add(goodPortion);
            else
                _reservedGoods[index] = _reservedGoods[index].Merge(goodPortion);
        }

        public Order Order()
        {
            return new Order(this);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            _reservedGoods.ForEach(reserved => stringBuilder.AppendLine(reserved.ToString()));

            return stringBuilder.ToString();
        }
    }

}
