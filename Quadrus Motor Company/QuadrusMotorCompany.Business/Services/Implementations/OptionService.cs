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
    public class OptionService : IOptionService
    {
        private readonly IOptionRepository _optionRepository;

        public OptionService(IOptionRepository optionRepository)
        {
            this._optionRepository = optionRepository;
        }

        public ServiceResponse<OptionResponse> FindOption(FindOptionRequest request)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<OptionResponse> CreateOption(CreateOptionRequest request)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<RequestSuccessfulResponse> UpdateOption(UpdateOptionRequest request)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<RequestSuccessfulResponse> DeleteOption(DeleteOptionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
