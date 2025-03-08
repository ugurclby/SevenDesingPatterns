using BuilderPattern.Models;

namespace BuilderPattern.Example1
{
    public class VillaBuilder : IHouseBuilder
    {
        private House _house = new House();
        public void BuildRoom(int room)
        {
            _house.Room = room;
        }
        public void BuildBalcony(bool isBalcony)
        {
            _house.IsBalcony = isBalcony;
        }
        public void BuildGarden(bool isGarden)
        {
            _house.IsGarden = true;
        }
        public void BuildFloor(int floor)
        {
            _house.Floor = floor;
        }
        public void BuildCountry(string country)
        {
            _house.Country = country;
        }
        public void BuildCity(string city)
        {
            _house.City = city; 
        }
        public void BuildAddress(string address)
        {
            _house.Address = address;
        }
        public House BuildHouse()
        {
            return _house;
        }

        
    } 
}
