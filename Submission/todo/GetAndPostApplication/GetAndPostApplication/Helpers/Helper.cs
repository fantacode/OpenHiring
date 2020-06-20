using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace GetAndPostApplication.Helpers
{
    public static class Helper
    {
        public static async Task ShowLoader(string title = "Loading")
        {
           
            Device.BeginInvokeOnMainThread(() =>
            {
               UserDialogs.Instance.ShowLoading(title,MaskType.None);
            });
        }

        public static async Task HideLoader()
        {
           
           

            Device.BeginInvokeOnMainThread(()=>
            {
                UserDialogs.Instance.HideLoading();
            });
        }
    }
}
