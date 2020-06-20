using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GetAndPostApplication.Models;
using GetAndPostApplication.Services;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace GetAndPostApplication
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
           await Get("https://fctodo.azurewebsites.net/todo");
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
                    studentModel = JsonConvert.DeserializeObject<ObservableCollection<StudentModel>>(responseJson.Result);
                    collectionList.ItemsSource = studentModel;
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

        private void Add_Clicked(object sender, EventArgs args)
        {
            App.Current.MainPage.Navigation.PushAsync(new AddTodoPage());
        }

    }
}
