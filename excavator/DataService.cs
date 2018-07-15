﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MPH_Poll
{
  class DataService
  {
    public static async Task<dynamic> getDataFromService(string queryString)
    {
      HttpClient client = new HttpClient();
      var response = await client.GetAsync(queryString);
      dynamic data = null;

      if (response != null)
      {
        string json = response.Content.ReadAsStringAsync().Result;
        data = JsonConvert.DeserializeObject(json);
      }
      return data;
    }
    static DataService()
    {
    }
  }
}