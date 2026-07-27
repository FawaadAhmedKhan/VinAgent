using VinAgentAPI.Repositories;

namespace VinAgentAPI.Services
{
    public class VinService
    {
        private readonly IVinRepository _repository;

        public VinService(IVinRepository repository)
        {
            _repository = repository;
        }


        public string GetVehicle(string vin)
        {
            return _repository.GetVehicleByVin(vin);
        }
    }
}
