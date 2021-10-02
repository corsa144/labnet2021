using CorsaroCristian.NorthwindTP4.Datos;
using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.Logica
{
    public class ShippersLogic :BaseLogic, IABMLogic<Shippers>
    {

        public List<Shippers> GetAll()
        {
            return contexto.Shippers.ToList();
        }
        public void Add(Shippers shipper)
        {
            try
            {
                contexto.Shippers.Add(shipper);
                contexto.SaveChanges();
            }catch(NotSupportedException ex)
            {
                throw new CustomException(ex.Message);
            }catch(Exception ex)
            {
                throw new CustomException(ex.Message);
            }

        }

        public void Delete(int id)
        {
            try
            {
                //var customerDemographicsAEliminar = contexto.CustomerDemographics.First(c => c.CustomerTypeID == idType);
                var shipperAEliminar = contexto.Shippers.Find(id);
                contexto.Shippers.Remove(shipperAEliminar);
                contexto.SaveChanges();
            }catch(ArgumentOutOfRangeException ex)
            {
                throw new CustomException(ex.Message);
            }catch(Exception ex)
            {
                throw new CustomException(ex.Message);
            }

        }
        /// <summary>
        /// Los suguientes campos pueden modificarse: Phone, CompanyName y Orders.
        /// </summary>
        /// <param name="shipper"></param>
        public void Update(Shippers shipper)
        {
            try
            {
                var shipperUpdate = contexto.Shippers.Find(shipper.ShipperID);
                shipperUpdate.Phone = shipper.Phone;
                shipperUpdate.CompanyName = shipper.CompanyName;

                contexto.SaveChanges();
            }catch(InvalidOperationException ex)
            {
                throw new CustomException(ex.Message);
            }catch(Exception ex)
            {
                throw new CustomException(ex.Message);
            }

        }
    }
}
