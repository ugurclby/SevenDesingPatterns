using BuilderPattern.Models;

namespace BuilderPattern.Example2
{
    public class ApiRequestBuilder
    {
        private readonly ApiRequest _apiRequest = new ();

        public ApiRequestBuilder WithUrl(string url)
        {
            _apiRequest.Url = url;
            return this;
        }
        public ApiRequestBuilder WithMetod(HttpMethod metod)
        {
            _apiRequest.Metod = metod;
            return this;
        } 
        public ApiRequestBuilder WithHeader(string key , string value)
        {
            _apiRequest.Header[key] = value;
            return this;
        }
        public ApiRequestBuilder WithBody(string body)
        {
            _apiRequest.Body = body;
            return this;
        } 
        public ApiRequest Build()
        {
            return _apiRequest;
        }
    }
}
