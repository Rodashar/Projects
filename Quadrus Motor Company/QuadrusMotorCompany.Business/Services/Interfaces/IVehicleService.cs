using QuadrusMotorCompany.Business.Messages.Generics;
using QuadrusMotorCompany.Business.Messages.Requests;
using QuadrusMotorCompany.Business.Messages.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Services.Interfaces
{
    public interface IVehicleService
    {
        ServiceResponse<VehicleResponse> FindVehicle(FindVehicleRequest request);
        ServiceResponse<VehiclesResponse> GetAllVehicles(GetAllVehiclesRequest request);
        ServiceResponse<VehicleResponse> CreateVehicle(CreateVehicleRequest request);
        ServiceResponse<RequestSuccessfulResponse> UpdateVehicle(UpdateVehicleRequest request);
    }
}
