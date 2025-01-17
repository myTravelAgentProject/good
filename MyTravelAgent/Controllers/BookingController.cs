﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Entity;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTravelAgent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class BookingController : ControllerBase
    {
        IBookingBL BookingBL;
        public BookingController(IBookingBL BookingBL)
        {
            this.BookingBL = BookingBL;
        }

        /*checks the orders within two months (and the importents orders) if their prices in booking had change
         then updates the orders with the change*/
        [HttpGet]
        public  async Task updateOrders()
        {
             await  BookingBL.updateOrders();
        }

        //public IActionResult updateOrdersA()
        //{
        //    return Ok( BookingBL.updateOrders());
        //}
    }
}
