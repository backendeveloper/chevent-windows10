using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using chevent_windows10.Data.Domain.Business;
using chevent_windows10.Data.Domain.Entities;
using chevent_windows10.Infrastructure.Core.Extensions;

namespace chevent_windows10.Business.Services.Services
{
    public class EventBusinessLogic : BaseClient<List<EventEntity>>
    {
        protected const string baseURL = "http://apifn.com/api/v1/events";
        protected HttpClient client;

        public EventBusinessLogic()
        {
            this.client = new HttpClient();
        }

        public async Task<ServiceResult<List<EventEntity>>> GetAllEvent()
        {
            var response = ServiceResult<List<EventEntity>>.Instance.ErrorResult(ResponseCode.GenericError.ToInt());
            response.ResultValue = await GetAsync();

            if (response.ResultValue != null)
            {
                response.SuccessResult(response.ResultValue);
            }
            return response;
        }


        //EDIT
        public ServiceResult<EventEntity> GetByEventId(int eventId)
        {
            throw new NotImplementedException();
        }


    }
}
