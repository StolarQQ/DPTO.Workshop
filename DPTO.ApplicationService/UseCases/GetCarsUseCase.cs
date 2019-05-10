using System.Collections.Generic;
using AutoMapper;
using DPTO.Dto;

namespace DPTO.ApplicationService.UseCases
{
    public class GetCarsUseCase
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarsUseCase(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public List<CarDto> Handle()
        {
            return _mapper.Map<List<CarDto>>(_carRepository.GetCars());
        }
    }
}