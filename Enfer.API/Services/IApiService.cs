using Enfer.Shared.Responses;

namespace Enfer.API.Services
{
    public interface IApiService
    {

        Task<Response> GetListAsync<T>(string servicePrefix, string controller);

    }
}
