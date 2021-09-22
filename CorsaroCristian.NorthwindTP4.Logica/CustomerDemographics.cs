using CorsaroCristian.NorthwindTP4.Datos;
using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.Logica
{
    public class CustomerDemographicsLogic : BaseLogic
    {

        public List<CustomerDemographics> GetAll()
        {
            return contexto.CustomerDemographics.ToList();
        }

        public void Add(CustomerDemographics customerDemographics)
        {
            contexto.CustomerDemographics.Add(customerDemographics);
            contexto.SaveChanges();
        }

        public void Delete(string idType)
        {
            //var customerDemographicsAEliminar = contexto.CustomerDemographics.First(c => c.CustomerTypeID == idType);
            var customerDemographicsAEliminar = contexto.CustomerDemographics.Find(idType);
            contexto.CustomerDemographics.Remove(customerDemographicsAEliminar);
            contexto.SaveChanges();
        }
    }
}
