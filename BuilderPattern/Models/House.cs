namespace BuilderPattern.Models
{
    public class House
    {
        public int Room { get; set; }
        public bool IsBalcony { get; set; } 
        public bool IsGarden { get; set; }
        public int Floor { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Room: {Room}, IsBalcony: {IsBalcony}, IsGarden: {IsGarden}, Floor :{Floor}, Country: {Country}, City: {City}, Address: {Address}";
        }

    }
}
