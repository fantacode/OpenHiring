using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GetAndPostApplication.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace GetAndPostApplication
{
    public partial class AddTodoPage : ContentPage
    {
        public AddTodoPage()
        {
            InitializeComponent();
        }
        private async void Add_Clicked(object sender, EventArgs args)
        {
            try
            {


                if (!string.IsNullOrEmpty(txtname.Text))
                {
                    await Helpers.Helper.ShowLoader("Please wait");

                    string json = await Task.Run(() => JsonConvert.SerializeObject(new TodoPostModel { name = txtname.Text.Trim() }));



                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("https://fctodo.azurewebsites.net/todo");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var res = client.PostAsync("https://fctodo.azurewebsites.net/todo", new StringContent(json, Encoding.UTF8, "application/json")).Result;

                    if (res.IsSuccessStatusCode)
                    {
                        var response = JsonConvert.DeserializeObject<StudentModel>(res.Content.ReadAsStringAsync().Result);
                        if (response != null)
                        {
                            await Application.Current.MainPage.DisplayAlert("Success!!!!!!!!!!!!", "Successfully Added Todo Item", "OK");
                            await Application.Current.MainPage.Navigation.PopAsync();
                        }
                    }
                    else
                    {

                        throw new Exception("Error occurred. Please check your internet connection or re-try.");
                    }




                }
                else

                    await App.Current.MainPage.DisplayAlert("Error", "Please input Todo Text", "OK");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                await Helpers.Helper.HideLoader();
            }
        }

    }
}
