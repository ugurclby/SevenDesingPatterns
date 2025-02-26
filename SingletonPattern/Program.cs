// Singleton pattern : Bir sınıfın yalnızca bir örneğine sahip olmasını sağlar ve bu örneğe global erişim noktası sağlar. 

using SingletonPattern;

var cities1 = CityProvider.Instance.GetCities();
 
foreach (var item in cities1)
{
    Console.WriteLine(item.CityName);
}

var cities2 = CityProvider.Instance.GetCities(); 
foreach (var item in cities2)
{
    Console.WriteLine(item.CityName);
}