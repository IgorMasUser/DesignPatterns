using SingletonPattern;

Singleton singleton1 = Singleton.getInstance();
Singleton singleton2 = Singleton.getInstance();
Console.WriteLine($"{ReferenceEquals(singleton1, singleton2)}");