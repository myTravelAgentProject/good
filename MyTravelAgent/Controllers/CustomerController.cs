﻿using BL;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTravelAgent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerBL customerBL;
        public CustomerController(ICustomerBL customerBL)
        {
            this.customerBL = customerBL;
        }

        //returns a list of all the customers
        [HttpGet]
        public async Task<List<customerDTO>> Get()
        {
            return await customerBL.getAllCustomers();
        }

        //returns a single customer according to his id
        [HttpGet("{id}")]
        public async Task<customerDTO> Get(int id)
        {
            return await customerBL.getCustomer(id); 
        }
        //[HttpGet("{id}/Orders")]
        //public async Task<Order> getAllCustomerOrders(int id)
        //{
        //    return await customerBL.getAllCustomerOrders(id);
        //}
        //add a new customer
        [HttpPost]
        public async Task<int> Post([FromBody] customerDTO customerToAdd)
        {
            return await customerBL.addNewCustomer(customerToAdd);
        }

        //update a customer
        [HttpPut("{id}")]
        public async Task Put(int id,[FromBody] customerDTO customerToUpdate)
        {
            await customerBL.updateCustomer(customerToUpdate,id);
        }

        //delete a customer
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await customerBL.deleteCustomer(id);
        }
    }
}
