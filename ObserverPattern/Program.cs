using ObserverPattern;

Article article = new Article();
Subscriber subscriber1 = new Subscriber("Subscriber 1");
Subscriber subscriber2 = new Subscriber("Subscriber 2");

article.RegisterObserver(subscriber1);
article.RegisterObserver(subscriber2);
article.NotifyObservers("New article published");