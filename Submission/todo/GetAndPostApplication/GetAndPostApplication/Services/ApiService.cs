using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GetAndPostApplication.Models;
using Newtonsoft.Json;

namespace GetAndPostApplication.Services
{
    public class ApiService
    {
        public ApiService()
        {


        }
        public async Task<ObservableCollection<StudentModel>> Get(string request)
        {
            ObservableCollection<StudentModel> studentModel = null;
            HttpResponseMessage res;
            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(request);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));               

                res = client.GetAsync("").Result;

                if (res.IsSuccessStatusCode)
                {
                    

                    var responseJson = res.Content.ReadAsStringAsync();
                    studentModel  =  JsonConvert.DeserializeObject<ObservableCollection<StudentModel>>(responseJson.Result);
                }
                else
                {
                    studentModel = null;
                }

            }
            catch (Exception ex)
            {

            }
            return studentModel;
        }
        public async Task<StudentModel> Post(string name)
        {
            StudentModel response = null;
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://fctodo.azurewebsites.net/todo");
                client.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue("application/json"));

                var res = client.PostAsync("https://fctodo.azurewebsites.net/todo", new StringContent(name, Encoding.UTF8, "application/json")).Result;

                if (res.IsSuccessStatusCode)
                {
                    response = JsonConvert.DeserializeObject <StudentModel > (res.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    
                    throw new Exception("Error occurred. Please check your internet connection or re-try.");
                }
            }
            catch (Exception)
            {
                throw new Exception("Error occurred. Please check your internet connection or re-try.");
            }
            return response;
        }


    }
}
