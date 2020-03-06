using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
  public class ListModel : PageModel
  {
    private readonly IConfiguration config;
    private readonly IRestaurantData restaurantData;

    public string Message { get; set; }
    public IEnumerable<Restaurant> Restaurants;

    public ListModel(IConfiguration config, IRestaurantData restaurantData)
    {
      this.config = config;
      this.restaurantData = restaurantData;
    }

    public void OnGet()
    {
      Message = config["Message"];
      Restaurants = restaurantData.GetAll();
    }
  }
}

