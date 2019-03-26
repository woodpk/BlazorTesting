using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoenixCharts.Server.Data;
using PhoenixCharts.Shared.Models;

namespace PhoenixCharts.Server.Controllers
{
    //[Route("api/consumer/index")]
    [ApiController]
    public class ConsumersController : ControllerBase
    {

        //PracticeDataAccessLayer _dataLayer = new PracticeDataAccessLayer();
        PracticeContext _context = new PracticeContext();

        // GET ALL Consumers
        [HttpGet]
        [Route("api/consumer/Index")]
        public IEnumerable<Consumer> Index()
        {
            try
            {
                return _context.Consumer.ToList();
            }
            catch
            {
                throw;
            }


            //return _dataLayer.GetAllConsumers();
        }


        //GET single consumer
        [HttpGet]
        [Route("api/consumer/getdetails/{id}")]
        public Consumer GetConsumerDetails(int id)
        {

            try
            {
                Consumer consumer = _context.Consumer.Find(id);
                return consumer;
            }
            catch
            {
                throw;
            }




            //return _dataLayer.GetConsumerData(id);
        }




        // POST: api/consumers/add
        [HttpPost]
        [Route("api/consumer/add")]
        public int AddConsumer([FromBody] Consumer consumer)
        {

            try
            {
                _context.Consumer.Add(consumer);
                int numberEntriesSaved = _context.SaveChanges();
                return numberEntriesSaved;
            }
            catch
            {
                throw;
            }

            //if (ModelState.IsValid)
            //    _dataLayer.AddConsumer(consumer);
        }




        // UPDATE a single consumer record
        [HttpPut]
        [Route("api/consumer/update")]
        public int UpdateConsumer(int id, [FromBody] Consumer consumer)
        {
            //var saved = false;
            //while (!saved)
            //{
            //    try
            //    {
            //        // Attempt to save changes to the database
            //        //_context.Entry(consumer).State = EntityState.Modified;
            //        int numberEntriesSaved = _context.SaveChanges();
            //        return numberEntriesSaved;
            //    }
            //    catch (DbUpdateConcurrencyException ex)
            //    {
            //        foreach (var entry in ex.Entries)
            //        {
            //            if (entry.Entity is Consumer)
            //            {
            //                var proposedValues = entry.CurrentValues;
            //                var databaseValues = entry.GetDatabaseValues();

            //                foreach (var property in proposedValues.Properties)
            //                {
            //                    var proposedValue = proposedValues[property];
            //                    var databaseValue = databaseValues[property];

            //                    // TODO: decide which value should be written to database
            //                    // proposedValues[property] = <value to be saved>;
            //                }

            //                // Refresh original values to bypass next concurrency check
            //                entry.OriginalValues.SetValues(databaseValues);
            //                return 0;
            //            }
            //            else
            //            {
            //                return 0;

            //                throw new NotSupportedException(
            //                    "Don't know how to handle concurrency conflicts for "
            //                    + entry.Metadata.Name);
            //            }
            //        }
            //    }
            //}
            //return 0;



            try
            {
                _context.Entry(consumer).State = EntityState.Modified;
                int numberEntriesSaved = _context.SaveChanges();
                return numberEntriesSaved;
            }
            catch
            {
                throw;
            }





        }





        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //[Route("api/consumer/delete")]
        //public void Delete(int id)
        //{
        //}







    }
}
