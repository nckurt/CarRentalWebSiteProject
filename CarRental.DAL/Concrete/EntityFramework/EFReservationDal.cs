﻿using CarRental.Core.DataAccess.BaseClasses.EntityFramework;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Concrete.EntityFramework {
    public class EFReservationDal : EFRepositoryBase<Reservation, CarRentalDBContext>, IReservationDal {
    }
}
