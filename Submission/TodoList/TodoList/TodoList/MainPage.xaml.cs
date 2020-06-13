using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TodoList.Droid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace CollectionViewChallenge.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        List<Todo> todo;
        public CollectionViewChallengePage()
        {
            InitializeComponent();


            GetTodoItems();

        }
        private async void Onbtn_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Page1());
        }


        protected async void GetTodoItems()
        {
            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(
                 "https://fctodo.azurewebsites.net/todo"
                );


            Console.WriteLine(response);
            todo = JsonConvert.DeserializeObject<List<Todo>>(response);
            collectionList.ItemsSource = todo;

        }
    }
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


}