namespace LoquatMegaStore.Structures
{
    using System;
    public struct ShippingAddress
    {
        public string Country { get; private set; }
        public string City { get; private set; }
        public string StreetAddress { get; private set; }
        public string ContactName { get; private set; }
    }
}
