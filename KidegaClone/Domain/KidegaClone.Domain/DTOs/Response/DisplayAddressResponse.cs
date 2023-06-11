namespace KidegaClone.Domain.DTOs.Response
{
    public class DisplayAddressResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighbourhood { get; set; }
        public string Street { get; set; }
        public string BuildingNo { get; set; }
        public int FlatNo { get; set; }
    }
}
