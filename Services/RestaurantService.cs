using AutoMapper;
using Microsoft.EntityFrameworkCore;
using restaurantapi.Entities;
using restaurantapi.Models;

namespace restaurantapi.Services;

public class RestaurantService 
{
    private readonly RestaurantDbContext _dbContext;
    private readonly IMapper _mapper;

    public RestaurantService(RestaurantDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
    public RestaurantDto GetById(int id)
    {
        var restaurant = _dbContext
            .Restaurants
            .Include(r => r.Address)
            .Include(r => r.Dishes)
            .FirstOrDefault(r => r.Id == id);

        if(restaurant is null) return null;
        
        var result =
    }
}