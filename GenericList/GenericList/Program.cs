using GenericList;

List<Car> cars = new List<Car>
{
    new Car("Toyota", "Corolla", 6.5, 400),
                new Car("BMW", "X5", 9.0, 400),
                new Car("Mercedes", "C200", 8.2, 400)
};


foreach(var car in cars)
{
    car.Listele();
}