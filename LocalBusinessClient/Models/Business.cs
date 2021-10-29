using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LocalBusinessClient.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string BusinessType { get; set; }
    public string Phone { get; set; }

    public static List<Business> GetBusinesses()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResonse = JsonConvert.DeserializeObject<JArray>(result);
      List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResonse.ToString());

      return businessList;
    }
  }
}