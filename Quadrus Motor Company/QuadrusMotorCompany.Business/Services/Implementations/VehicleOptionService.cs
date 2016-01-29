using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Business.Messages.Requests;
using QuadrusMotorCompany.Business.Messages.Responses;
using QuadrusMotorCompany.Business.Services.Interfaces;
using QuadrusMotorCompany.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Services.Implementations
{
    public class VehicleOptionService : IVehicleOptionService
    {
        private readonly IVehicleOptionRepository _vehicleOptionRepository;

        public VehicleOptionService(IVehicleOptionRepository vehicleOptionRepository)
        {
            this._vehicleOptionRepository = vehicleOptionRepository;
        }

        public ServiceResponse<VehicleOptionResponse> FindVehicleOption(FindVehicleOptionRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<VehicleOptionResponse>(new VehicleOptionResponse()
                {
                    VehicleOption = this._vehicleOptionRepository.GetByVehicleIdOptionId(request.VehicleId, request.OptionId)
                });
        }

        public ServiceResponse<VehicleOptionResponse> CreateVehicleOption(CreateVehicleOptionRequest request)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<RequestSuccessfulResponse> UpdateVehicleOption(UpdateVehicleOptionRequest request)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<RequestSuccessfulResponse> DeleteVehicleOption(DeleteVehicleOptionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
