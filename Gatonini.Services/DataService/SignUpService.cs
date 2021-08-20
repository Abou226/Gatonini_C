using Gatonini.Models;
using Gatonini.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Services
{
    public class SignUpService : BaseVM.BaseViewModel, ISignUpService
    {
        public async Task<Secrets> SignUpAsync(LogInModel user)
        {
            try
            {
                //User u = new User() { Password = user.Password, Username = user.Username };
                string jsons = JsonConvert.SerializeObject(user);


                HttpContent httpContent = new StringContent(jsons);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                Client.BaseAddress = new Uri(baseurl);
                var response = await Client.PostAsync("api/Users", httpContent);

                if (response.IsSuccessStatusCode)
                {
                    var content = new StringContent(jsons);
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(baseurl);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var login = await client.PostAsync("api/Auth/login", content);

                    var all = ConvertSingle<Secrets>.FromJson(await login.Content.ReadAsStringAsync());
                    return all;
                }
                else return new Secrets();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
