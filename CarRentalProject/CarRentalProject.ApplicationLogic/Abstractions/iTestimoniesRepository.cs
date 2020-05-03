using CarRentalProject.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Abstractions
{
    public interface iTestimoniesRepository : IRepository<Testimonies>
    {
        Testimonies GetTestimonyDescription(Guid testimoniesId, Testimonies testimony);
        object GetTestimonybyTestimonyId(Guid testimoniesIdGuid);
    }
}





