using PhoenixCharts.Shared.Models;
using PhoenixCharts.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PhoenixCharts.Server.Data

{
    public class PracticeDataAccessLayer
    {
        PracticeContext _context = new PracticeContext();



        //GET all consumers   
        public IEnumerable<Consumer> GetAllConsumers()
        {
            try
            {
                return _context.Consumer.ToList();
            }
            catch
            {
                throw;
            }
        }
        //ADD new consumer record     
        public int AddConsumer(Consumer consumer)
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
        }
        //UPDATE a consumer record    
        public void UpdateConsumer(Consumer consumer)
        {
            try
            {
                _context.Entry(consumer).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular employee    
        public Consumer GetConsumerData(int id)
        {
            try
            {
                Consumer consumer= _context.Consumer.Find(id);
                return consumer;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular employee    
        public void DeleteConsumer(int id)
        {
            try
            {
                Consumer csr = _context.Consumer.Find(id);
                _context.Consumer.Remove(csr);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}