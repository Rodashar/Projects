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
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            this._vehicleRepository = vehicleRepository;
        }

        public ServiceResponse<VehicleResponse> FindVehicle(FindVehicleRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<VehicleResponse>(new VehicleResponse()
                {
                    Vehicle = this._vehicleRepository.GetById(request.VehicleId)
                });
        }

        public ServiceResponse<VehiclesResponse> GetAllVehicles(GetAllVehiclesRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<VehiclesResponse>(new VehiclesResponse()
                {
                    Vehicles = this._vehicleRepository.GetVehicles()
                });
        }

        public ServiceResponse<VehicleResponse> CreateVehicle(CreateVehicleRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<VehicleResponse>(new VehicleResponse()
            {
                Vehicle = this._vehicleRepository.CreateVehicle(request.VehicleToCreate)
            });
        }

        public ServiceResponse<RequestSuccessfulResponse> UpdateVehicle(UpdateVehicleRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            this._vehicleRepository.UpdateVehicle(request.VehicleToUpdate);

            return new ServiceResponse<RequestSuccessfulResponse>(new RequestSuccessfulResponse() { });
        }

        public ServiceResponse<RequestSuccessfulResponse> DeleteVehicle(DeleteVehicleRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
