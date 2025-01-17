﻿using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class AdminDL : IAdminDL
    {
        MyTravelAgent2Context myContext;
        public AdminDL(MyTravelAgent2Context myContext)
        {
            this.myContext = myContext;
        }

        /*(get) looks for a admin that his email and password maches to the variables
        rerurns the object or null*/
        public async Task<Admin> login(string name)
        {
            Admin admin= await myContext.Admins.FirstOrDefaultAsync(a => a.Name == name );
            return admin;
        }

        /*(post) add the new admin to the admin table
        then, save the changes
        and return its id (the id accepted from the datebase after insert)*/
        public async Task<int> addNewAdmin(Admin adminToAdd)
        {
            await myContext.Admins.AddAsync(adminToAdd);
            await myContext.SaveChangesAsync();
            return  adminToAdd.Id;
        }

        /*(put) finds the admin we want to change,
          then replace it with the new admin (the object after changes)
         save the changes*/
        public async Task updateAdmin(int id, Admin adminToUpdate)
        {
            Admin admin = await myContext.Admins.FindAsync(id);
            myContext.Entry(admin).CurrentValues.SetValues(adminToUpdate);
            await myContext.SaveChangesAsync();
            
        }
    }
}
