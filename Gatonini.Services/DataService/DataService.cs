using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Services
{
    public class DataService<T, D> : BaseVM.BaseViewModel, IDataService<T, D> where T : class
    {

        public virtual async Task<T> AddAsync(T value, string token, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsons = JsonConvert.SerializeObject(value);

                HttpContent httpContent = new StringContent(jsons);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var type = value.GetType().ToString();
                var a = type.Split('.');
                foreach (var item in a)
                {
                    type = item;
                }
                var response = new HttpResponseMessage();
                if (url == null)
                    response = await Client.PostAsync("api/" + type + "s", httpContent);
                else response = await Client.PostAsync("api/" + type + "s/" + url, httpContent);
                if (response.IsSuccessStatusCode)
                    return value;
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    var mes = response.ReasonPhrase.ToString();
                    return null;
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }

        public virtual async Task<IEnumerable<T>> AddListAsync(List<T> values, string token, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsons = JsonConvert.SerializeObject(values);

                HttpContent httpContent = new StringContent(jsons);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await Client.PostAsync(baseurl + values.FirstOrDefault().GetType().ToString() + "s" + url, httpContent);
                if (response.IsSuccessStatusCode)
                    return values;
                else
                    return null;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }

        public virtual async Task<IEnumerable<D>> EditAsync(List<D> values, string token, Guid id, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Add("id", id.ToString());
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsons = JsonConvert.SerializeObject(values);

                HttpContent httpContent = new StringContent(jsons);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await Client.PatchAsync("api/" + url, httpContent);
                if (response.IsSuccessStatusCode)
                    return values;
                else
                    return null;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }

        public virtual async Task<T> DeleteAsync(string token, T value = null, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await Client.DeleteAsync("api/" + url);
                if (response.IsSuccessStatusCode)
                    return value;
                else
                    return null;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }

        public virtual async Task<IEnumerable<T>> GetItemsAsync(string token, string url = null)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", token);
            Client.DefaultRequestHeaders.Authorization = authHeader;
            var json = await Client.GetStringAsync("api/" + url);
            var all = Convert<T>.FromJson(json);
            return all;
        }

        public virtual async Task<List<T[]>> GetItemsGroupedAsync(string token, string url = null)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", token);
            Client.DefaultRequestHeaders.Authorization = authHeader;
            var json = await Client.GetStringAsync("api/" + url);
            var all = ConvertGrouped<T>.FromJson(json);
            return all;
        }
        public virtual async Task<T> GetItemAsync(string token, string url = null)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", token);
            Client.DefaultRequestHeaders.Authorization = authHeader;
            var json = await Client.GetStringAsync("api/" + url);
            var all = ConvertSingle<T>.FromJson(json);
            return all;
        }

        public virtual async Task<T> UpdateAsync(T value, string token, string url = null)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", token);
            Client.DefaultRequestHeaders.Authorization = authHeader;
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string jsons = JsonConvert.SerializeObject(value);

            HttpContent httpContent = new StringContent(jsons);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await Client.PutAsync(value.GetType().ToString() + "s" + url, httpContent);
            if (response.IsSuccessStatusCode)
                return value;
            else
                return null;
        }

        public virtual async Task<IEnumerable<T>> UpdateListAsync(List<T> values, string token, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsons = JsonConvert.SerializeObject(values);

                HttpContent httpContent = new StringContent(jsons);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await Client.PatchAsync("api/" + values.FirstOrDefault().GetType().ToString() + "s" + url, httpContent);
                if (response.IsSuccessStatusCode)
                    return values;
                else
                    return null;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }
    }

    public class DataService<T> : BaseVM.BaseViewModel, IDataService<T> where T : class
    {

        public virtual async Task<T> AddAsync(T value, string token, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsons = JsonConvert.SerializeObject(value);

                HttpContent httpContent = new StringContent(jsons);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var type = value.GetType().ToString();
                var a = type.Split('.');
                foreach (var item in a)
                {
                    type = item;
                }
                var response = new HttpResponseMessage();
                if (url == null)
                    response = await Client.PostAsync("api/" + type + "s", httpContent);
                else response = await Client.PostAsync("api/" + type + "s/" + url, httpContent);
                if (response.IsSuccessStatusCode)
                    return value;
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    var mes = response.ReasonPhrase.ToString();
                    return null;
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }

        public virtual async Task<IEnumerable<T>> AddListAsync(List<T> values, string token, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsons = JsonConvert.SerializeObject(values);

                HttpContent httpContent = new StringContent(jsons);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await Client.PostAsync("api/" + values.FirstOrDefault().GetType().ToString() + "s" + url, httpContent);
                if (response.IsSuccessStatusCode)
                    return values;
                else
                    return null;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }



        public virtual async Task<T> DeleteAsync(string token, T value = null, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await Client.DeleteAsync("api/" + url);
                if (response.IsSuccessStatusCode)
                    return value;
                else
                    return null;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }

        public virtual async Task<IEnumerable<T>> GetItemsAsync(string token, string url = null)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", token);
            Client.DefaultRequestHeaders.Authorization = authHeader;
            var json = await Client.GetStringAsync("api/" + url);
            var all = Convert<T>.FromJson(json);
            return all;
        }

        public virtual async Task<List<T[]>> GetItemsGroupedAsync(string token, string url = null)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", token);
            Client.DefaultRequestHeaders.Authorization = authHeader;
            var json = await Client.GetStringAsync("api/" + url);
            var all = ConvertGrouped<T>.FromJson(json);
            return all;
        }

        public virtual async Task<T> GetItemAsync(string token, string url = null)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", token);
            Client.DefaultRequestHeaders.Authorization = authHeader;
            var json = await Client.GetStringAsync("api/" + url);
            var all = ConvertSingle<T>.FromJson(json);
            return all;
        }

        public virtual async Task<T> UpdateAsync(T value, string token, string url = null)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", token);
            Client.DefaultRequestHeaders.Authorization = authHeader;
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string jsons = JsonConvert.SerializeObject(value);

            HttpContent httpContent = new StringContent(jsons);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await Client.PutAsync(value.GetType().ToString() + "s" + url, httpContent);
            if (response.IsSuccessStatusCode)
                return value;
            else
                return null;
        }

        public virtual async Task<IEnumerable<T>> UpdateListAsync(List<T> values, string token, string url = null)
        {
            try
            {
                var authHeader = new AuthenticationHeaderValue("bearer", token);
                Client.DefaultRequestHeaders.Authorization = authHeader;
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsons = JsonConvert.SerializeObject(values);

                HttpContent httpContent = new StringContent(jsons);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await Client.PatchAsync("api/" + values.FirstOrDefault().GetType().ToString() + "s" + url, httpContent);
                if (response.IsSuccessStatusCode)
                    return values;
                else
                    return null;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var phrase = ex.InnerException;
                return null;
            }
        }
    }
}
