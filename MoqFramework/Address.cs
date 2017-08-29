namespace MoqFramework
{
    public class Address : IAddress
    {
        public int PersonId { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }

        public bool Verify(IAddress address)
        {
            return !string.IsNullOrWhiteSpace(address.Street) && !string.IsNullOrWhiteSpace(address.PostCode);
        }

        public virtual string GetPostCode()
        {
            return PostCode;
        }
    }
}
