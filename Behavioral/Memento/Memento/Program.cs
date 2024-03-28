using Memento;

Man man = new Man();
Robot robot = new Robot();

string clothe = "Shirt,Boots";
man.Clothes = clothe;

robot.Backpack = man.UnDress();
Console.WriteLine($"Current state: {man.Clothes}");
man.Clothes = "Naked";
Console.WriteLine($"Current state: {man.Clothes}");
man.Dress(robot.Backpack);
Console.WriteLine($"Current state: {man.Clothes}");

