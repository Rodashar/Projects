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
    public interface IOptionService
    {
        ServiceResponse<OptionResponse> FindOption(FindOptionRequest request);
        ServiceResponse<OptionResponse> CreateOption(CreateOptionRequest request);
        ServiceResponse<RequestSuccessfulResponse> UpdateOption(UpdateOptionRequest request);
        ServiceResponse<RequestSuccessfulResponse> DeleteOption(DeleteOptionRequest request);
    }
}
