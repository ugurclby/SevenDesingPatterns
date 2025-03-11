// Facade Pattern : Karmaþýk ve birbirine baðlý alt sistemleri basit bir arayüzle kullanmamýzý saðlar.
// Bu sayede alt sistemlerin birbirleriyle olan baðýmlýlýklarýný azaltýr ve daha esnek bir yapý saðlar.
// Dýþ sisteme karþý tek bir noktadan hizmet verir ve alt sistemlerin birbirleriyle olan iletiþimini saðlar.


public class Program
{
    static void Main(string[] args)
    { 
        RestaurantFacade restaurantFacade = new RestaurantFacade();
        restaurantFacade.ServeFood();
        // Dýþ sistem sadece restaurantFacade nesnesiyle iletiþim kurar.
        // restaurantFacade nesnesi alt sistemlerle iletiþimi saðlar.
    }
}

public class Kitchen{
    public void GetFood(){
        Console.WriteLine("Yemek hazýrlanýyor...");
    }
}

public class Waiter{
    public void ServeFood(){
        Console.WriteLine("Yemek servis ediliyor...");
    }
}

public class Cashier{
    public void GetPayment(){
        Console.WriteLine("Ödeme alýnýyor...");
    }
}

public class RestaurantFacade{
    private Kitchen _kitchen;
    private Waiter _waiter;
    private Cashier _cashier;

    public RestaurantFacade(){
        _kitchen = new Kitchen();
        _waiter = new Waiter();
        _cashier = new Cashier();
    }

    public void ServeFood(){
        _kitchen.GetFood();
        _waiter.ServeFood();
        _cashier.GetPayment();
    }
}