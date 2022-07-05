namespace CarRent.Car.Domain
{
    public interface ICarRepository
    {
        Car GetById(Guid Id);

        Car GetByCarNumber(string CarNumber);

        // ..

        void Add(Car car);

        void Update(Car car);

        void Remove(Car car);
    }
}
