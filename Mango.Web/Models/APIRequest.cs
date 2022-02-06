using static Mango.Web.SD;

namespace Mango.Web.Models
{
    public class APIRequest
    {
        public APIType ApiType { get; set; } = APIType.GET;

        public string URL { get; set; }

        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
