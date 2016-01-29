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
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<OptionResponse>(new OptionResponse()
                {
                    Option = this._optionRepository.GetById(request.OptionId)
                });
        }

        public ServiceResponse<OptionResponse> CreateOption(CreateOptionRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            return new ServiceResponse<OptionResponse>(new OptionResponse()
            {
                Option = this._optionRepository.CreateOption(request.OptionToCreate)
            });
        }

        public ServiceResponse<RequestSuccessfulResponse> UpdateOption(UpdateOptionRequest request)
        {
            if (!request.CanProcessRequest())
                throw new InvalidOperationException();

            this._optionRepository.UpdateOption(request.OptionToUpdate);

            return new ServiceResponse<RequestSuccessfulResponse>(new RequestSuccessfulResponse() { });
        }

        public ServiceResponse<RequestSuccessfulResponse> DeleteOption(DeleteOptionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
