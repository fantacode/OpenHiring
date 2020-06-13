using CollectionViewChallenge.Views;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoList.Droid.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

        }
        private async void OnBtn_Clicked1(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://fctodo.azurewebsites.net/todo");
            HttpResponseMessage response;
            JObject jsonData = new JObject();
            //string jsonData = @"{""name"" : ""todo task 2 ""}";

            if (String.IsNullOrEmpty(sub.Text))
            {
                await DisplayAlert("Error", "Please input Todo Text", "OK");
            }
            else
            {

                jsonData.Add("name", sub.Text); //json object
                var content = new StringContent(jsonData.ToString(), Encoding.UTF8, "application/json"); //post body
                response = await client.PostAsync(" https://fctodo.azurewebsites.net/todo", content);

                await DisplayAlert("Success", "Successfully Added Todo Item", "OK");
                await Navigation.PushAsync(new CollectionViewChallengePage());

            }
        }


    }
}