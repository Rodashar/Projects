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
    public interface IVehicleOptionService
    {
        ServiceResponse<VehicleOptionResponse> FindVehicleOption(FindVehicleOptionRequest request);
        ServiceResponse<VehicleOptionsResponse> FindVehicleOptions(FindVehicleOptionsByVehicleIdRequest request);
        ServiceResponse<VehicleOptionsResponse> FindVehicleOptions(FindVehicleOptionsByOptionIdRequest request);
        ServiceResponse<VehicleOptionResponse> CreateVehicleOption(CreateVehicleOptionRequest request);
        ServiceResponse<RequestSuccessfulResponse> UpdateVehicleOption(UpdateVehicleOptionRequest request);
        ServiceResponse<RequestSuccessfulResponse> DeleteVehicleOption(DeleteVehicleOptionRequest request);
    }
}
