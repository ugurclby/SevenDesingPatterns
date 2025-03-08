using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Example1
{
    public interface IHouseBuilder
    {
        void BuildRoom(int room);
        void BuildBalcony(bool isBalcony);
        void BuildGarden(bool isGarden);
        void BuildFloor(int floor);
        void BuildCountry(string country);
        void BuildCity(string city);
        void BuildAddress(string address);
        House BuildHouse();
    }
}
