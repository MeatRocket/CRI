using CRI.wwwroot.Data;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace CRI.Pages
{
    public partial class Index
    {
        public static string RepositoryName { get; set; } = "";
   
      

        public async Task TestAsync()
        {
            var s = RepositoryName.Split("/");
            NavigationManager.NavigateTo("/"+ s[0]+"/"+s[1]);

        }


        

    }
}
