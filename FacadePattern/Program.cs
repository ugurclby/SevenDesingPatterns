// Facade Pattern : Karma��k ve birbirine ba�l� alt sistemleri basit bir aray�zle kullanmam�z� sa�lar.
// Bu sayede alt sistemlerin birbirleriyle olan ba��ml�l�klar�n� azalt�r ve daha esnek bir yap� sa�lar.
// D�� sisteme kar�� tek bir noktadan hizmet verir ve alt sistemlerin birbirleriyle olan ileti�imini sa�lar.


public class Program
{
    static void Main(string[] args)
    { 
        RestaurantFacade restaurantFacade = new RestaurantFacade();
        restaurantFacade.ServeFood();
        // D�� sistem sadece restaurantFacade nesnesiyle ileti�im kurar.
        // restaurantFacade nesnesi alt sistemlerle ileti�imi sa�lar.
    }
}

public class Kitchen{
    public void GetFood(){
        Console.WriteLine("Yemek haz�rlan�yor...");
    }
}

public class Waiter{
    public void ServeFood(){
        Console.WriteLine("Yemek servis ediliyor...");
    }
}

public class Cashier{
    public void GetPayment(){
        Console.WriteLine("�deme al�n�yor...");
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