using System;

namespace Homework2
{
    class Shop
    {
        private readonly Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
        }

        public Cart Cart()
        {
            return new Cart(this);
        }
        
        public void Reserve(GoodPortion portion)
        {
            if (_warehouse.HasGood(portion))
                _warehouse.PickupGood(portion);
            else
                throw new InvalidOperationException($"Good [{portion.Good.Name}] not presented in the required amount [{portion.Amount}].");
        }
    }

}
