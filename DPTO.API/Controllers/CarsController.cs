using System.Collections.Generic;
using DPTO.ApplicationService;
using DPTO.ApplicationService.UseCases;
using DPTO.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DPTO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CreateCarUseCase _createCar;
        private readonly GetCarsUseCase _getCars;
        private readonly GetCarByIdUseCase _getCarById;

        public CarsController(CreateCarUseCase createCar, GetCarsUseCase getCars, GetCarByIdUseCase getCarById)
        {
            _createCar = createCar;
            _getCars = getCars;
            _getCarById = getCarById;
        }

        [HttpGet]
        public List<CarDto> Get()
        {
            return _getCars.Handle();
        }

        [HttpGet("{id}")]
        public CarDto Get(int id)
        {
            return _getCarById.Handle(id);
        }

        [HttpPost]
        public void Post([FromBody] CarParams car)
        {
            _createCar.Handle(car);
        }
    }
}