
using Exercicio02Heranca.domain;

// Exercicio 2
MotorBike moto = new MotorBike("Shineray", 200);
Car car = new Car("Gol bolinha", 199);

car.speedUp(car.MaxSpeed);
car.breakVehicle();
moto.speedUp(moto.MaxSpeed);
moto.breakVehicle();