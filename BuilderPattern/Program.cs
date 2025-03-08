using BuilderPattern.Example1;
using BuilderPattern.Example2;
using System.Text.Json;
using System.Text.Json.Nodes;

#region Example1
IHouseBuilder builder = new HouseBuilder();
builder.BuildFloor(1);
builder.BuildRoom(3);
builder.BuildBalcony(true);
builder.BuildGarden(false);
builder.BuildCountry("Turkey");
builder.BuildCity("Istanbul");
builder.BuildAddress("Istanbul, Turkey");
var house = builder.BuildHouse();
Console.WriteLine(house.ToString());

IHouseBuilder villaBuilder = new VillaBuilder();
villaBuilder.BuildFloor(2);
villaBuilder.BuildRoom(5);
villaBuilder.BuildBalcony(true);
villaBuilder.BuildGarden(true);
villaBuilder.BuildCountry("Turkey");
villaBuilder.BuildCity("Istanbul");
villaBuilder.BuildAddress("Istanbul, Turkey");
var villa = villaBuilder.BuildHouse();

Console.WriteLine(villa.ToString());

#endregion

#region Example2

ApiRequestBuilder apiRequestBuilder = new();

var request = apiRequestBuilder.WithUrl("https://reqres.in/api/users?page=2")
                 .WithMetod(HttpMethod.Post).
                 WithBody(JsonSerializer.Serialize(new UserCreate { Job="Software Dev.",Name="Test"})).
                 Build();

using (var httpclient = new HttpClient())
{
    var request2 = new HttpRequestMessage(request.Metod, request.Url);

    request2.Content = new StringContent(request.Body, System.Text.Encoding.UTF8, "application/json");

    var response = httpclient.SendAsync(request2).Result;

    var sonuc = response.Content.ReadAsStringAsync().Result;

    Console.Write(sonuc);
} 


#endregion

