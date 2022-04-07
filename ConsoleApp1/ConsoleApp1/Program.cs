using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
            var responseJsonStr = response.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(responseJsonStr);


            List<Users>user= JsonConvert.DeserializeObject<List<Users>>(responseJsonStr);
            foreach (var item in user)
            {
                Console.WriteLine(item.email);
            }

        }
      }
  }
   

