using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.DataAccess2
{
    public class TestimoniesRepository : BaseRepository<Testimonies>, iTestimoniesRepository
    {
        public TestimoniesRepository(CarRentalProjectDbContext dbContext) : base(dbContext)
        {

        }
        public Testimonies GetTestimonialDescription(Guid testimoniesId, Testimonies testimony)
        {
            Testimonies Testimonyinfo = null;
            var selectedTestimony = dbContext.Testimonies
                                       .Where(testimony => testimony.Id == testimoniesId)
                                       .SingleOrDefault();


            return Testimonyinfo;
        }

      //----------------------------------------------------------------------------------------------------------------------------

        public static object GetTestimonyDescription()
        {
            throw new NotImplementedException();
        }

        public object GetTestimonybyTestimonyId(Guid testimoniesIdGuid)
        {
            throw new NotImplementedException();
        }

        public Testimonies GetTestimonyDescription(Guid testimoniesId, Testimonies testimony)
        {
            throw new NotImplementedException();
        }
    }
}
