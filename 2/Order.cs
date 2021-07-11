namespace Homework2
{
    struct Order
    {
        public string Paylink { get; }

        public Order(Cart cart)
        {
            Paylink = cart.GetHashCode().ToString();
        }
    }

}
