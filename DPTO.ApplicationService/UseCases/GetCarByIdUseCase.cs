using AutoMapper;
using DPTO.Dto;

namespace DPTO.ApplicationService.UseCases
{
    public class GetCarByIdUseCase
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarByIdUseCase(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public CarDto Handle(int id)
        {
            var car = _carRepository.GetCarById(id);
            return _mapper.Map<CarDto>(car);
        }
    }
}