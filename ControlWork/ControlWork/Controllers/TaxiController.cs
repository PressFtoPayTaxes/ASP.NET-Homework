using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlWork.DataAccess;
using ControlWork.DTOs;
using ControlWork.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControlWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiController : ControllerBase
    {

        public TaxiController()
        {
        }

        public async Task<IActionResult> Get()
        {
            List<Order> orders;
            using (var context = new TaxiContext())
            {
                orders = await context.Orders.ToListAsync();
            }

            

            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> Post(OrderDTO orderDTO)
        {

            using (var context = new TaxiContext())
            {
                var order = new Order
                {
                    Client = await context.FindAsync<Client>(orderDTO.ClientId),
                    ClientLongitude = orderDTO.ClientLongitude, 
                    ClientLatitude = orderDTO.ClientLatitude,
                    Comment = orderDTO.Comment,
                    Demands = orderDTO.Demands,
                    DestinationLongitude = orderDTO.DestinationLongitude, 
                    DestinationLatitude = orderDTO.DestinationLatitude,
                    Tariff = orderDTO.Tariff,
                    Time = orderDTO.Time
                };
                context.Orders.Add(order);
                await context.SaveChangesAsync();
            }

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(OrderDTO order)
        {
            using (var context = new TaxiContext())
            {
                var queriedOrder = await context.FindAsync<Order>(order.Id);
                queriedOrder.Driver = await context.FindAsync<Driver>(order.DriverId);
                queriedOrder.State = order.State;

                await context.SaveChangesAsync();
            }

            return Ok();
        }

       
    }
}