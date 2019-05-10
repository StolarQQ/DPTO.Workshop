using System.Collections.Generic;
using DPTO.Domain;

namespace DPTO.ApplicationService.UseCases
{
    public interface ICarRepository
    {
        List<Car> GetCars();

        Car GetCarById(int id);

        void Add(Car car);
    }
}