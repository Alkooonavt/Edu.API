using System.Net;
using Domain.DataAccess.DTO;

namespace Edu.Api.Responses
{
    public class ApplicationResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public ApplicationDTO ApplicationDTO { get; set; }
        public string ErrorMessage { get; set; }
    }
}