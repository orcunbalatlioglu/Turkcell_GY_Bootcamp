namespace KidegaClone.Domain.DTOs.Response
{
    public class DisplayAuthorResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Biography { get; set; }
        public string? Picture { get; set; }
    }
}
