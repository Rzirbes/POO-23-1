
using ExercicioHeranca.domain;

// Exercício 1
Dog dog = new Dog("Pug");
Cat cat = new Cat("Bichano");

Console.WriteLine($"O {dog.Name} falou:");
dog.Speak();
Console.WriteLine($"O {cat.Name} falou:");
cat.Speak();

// Exercicio 2
MotorBike moto = new MotorBike("Shneray", 200);
Car car = new Car("Gol bolinha", 199);

car.speedUp();
car.breakVehicle();
moto.speedUp();
moto.breakVehicle();

// Exercicio 3
Hero ironMan = new Hero("Homem de Ferro", 50, 100, new string[]{"voo", "raio repulsor"});
SuperHero spiderMan = new SuperHero("Homem Aranha", 60, 90, new string[]{"Teia de Aranha", "Sentido Aranha",}, "Teia de Aranha Gigante", 30);
Villain thanos = new Villain("Thano", 110, 50, new string[]{"Manopla do infinito", "Teleportação"});
SuperVillain greenGoblin = new SuperVillain("Duende Verde", 60, 70, new string[]{"Bombas", "Planador"}, "Bomba de destruição em massa", 40);

ironMan.toFight(thanos);
Console.WriteLine();
spiderMan.UseSuperPower();
greenGoblin.UseSuperPower();
spiderMan.toFight(greenGoblin);





