using System;
using AutoMapper;
using DPTO.ApplicationService.UseCases;
using DPTO.Domain;
using DPTO.Dto;

namespace DPTO.ApplicationService
{
    public class CreateCarUseCase
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CreateCarUseCase(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public void Handle(CarParams car)
        {
            var carEntity = _mapper.Map<Car>(car);
            carEntity.AddedOn = DateTime.Now;

            _carRepository.Add(carEntity);
        }
    }
}