using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Services
{
    public class TestimoniesService
    {
       
        private iTestimoniesRepository testimoniesRepository;
        public TestimoniesService(iTestimoniesRepository testimoniesRepository)
        {
            this.testimoniesRepository = testimoniesRepository;
        }
        public Testimonies GetTestimonybyTestimonyId(string testimoniesId)
        {
            Guid testimoniesIdGuid = Guid.Empty;
            if (!Guid.TryParse(testimoniesId, out testimoniesIdGuid))
            {
                throw new Exception("Invalid Guid format.");
            }

            var testimony = testimoniesRepository.GetTestimonybyTestimonyId(testimoniesIdGuid);
            if ( testimony == null)
            {
                throw new EntityNotFoundException(testimoniesIdGuid);
            }

            return (Testimonies)testimony;
        }


        public Testimonies CreateTestimony(string testimoniesId, string testimonydescription)
        {
            var testimony = new Testimonies
            {
                Id = Guid.Parse(testimoniesId),
                TestimonyDescription = testimonydescription

             

            };
            testimoniesRepository.Add(testimony);
            return testimony;
        }
    }
}
