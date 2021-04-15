using RestaurantSoftwareMVC14_4_2021.Data.Repositories.Interface_Repositories;
using RestaurantSoftwareMVC14_4_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSoftwareMVC14_4_2021.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly RestaurantDbContext restaurantDbContext;

        public OrderRepository(RestaurantDbContext restaurantDbContext)
        {
            this.restaurantDbContext = restaurantDbContext;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            order.OrderDetails = new List<OrderDetail>();

            //hier moet echt nog kei veel shoppingcart shit

            restaurantDbContext.Orders.Add(order);

            restaurantDbContext.SaveChanges();
        }
    }
}
