using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace Perser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;
        public HtmlLoader(IParserSettings parserSettings)
        {
            client = new HttpClient();
            url = $"{parserSettings.BaseUrl}/{parserSettings.Prefix}/";
        }
        public async Task<string> GetSourceByPageId(int id)
        {
            var currenturl = url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currenturl);
            string source = null;
            if(response !=null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
