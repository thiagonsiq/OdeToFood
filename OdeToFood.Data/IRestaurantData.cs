using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
  public interface IRestaurantData
  {
    IEnumerable<Restaurant> GetAll();
  }

  public class InMemoryRestaurantData : IRestaurantData
  {
    List<Restaurant> restaurants;

    public InMemoryRestaurantData()
    {
      restaurants = new List<Restaurant>()
      {
        new Restaurant { Id = 1, Name = "Thiago's Pizza", Location = "Maryland", Cuisine = CuisineType.Italian },
        new Restaurant { Id = 2, Name = "Monica's Tacos", Location = "New Jersey", Cuisine = CuisineType.Mexican },
        new Restaurant { Id = 3, Name = "Joey's Marsala", Location = "Carolina", Cuisine = CuisineType.Indian }
      };
    }

    public IEnumerable<Restaurant> GetAll()
    {
      return from r in restaurants
             orderby r.Name
             select r;
    }
  }
}
