﻿using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusinessLayer.Repositories
{
    public class ReservationRepository : GenericRepository<Reservation>
    {
        public ReservationRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
