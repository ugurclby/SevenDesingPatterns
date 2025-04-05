// See https://aka.ms/new-console-template for more information
using AdapterPattern.Models;
 
Priz priz = new Priz();
priz.ElektrikVer(new Utu());
priz.ElektrikVer(new Buzdolabı());  
//priz.ElektrikVer(new Telefon()); // Telefon'u çalıştıramayız çünkü IElektrikliEvAletleri'ni implement etmiyor. Bu yüzden bir adaptör kullanmamız gerekiyor.

TelefonAdapter telefonAdapter = new TelefonAdapter(new Telefon());
priz.ElektrikVer(telefonAdapter); // Telefon'u çalıştırabilmek için adaptör kullanıyoruz.
 var denem = 1 ;