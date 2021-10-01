﻿using CorsaroCristian.NorthwindTP4.Datos;
using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.Logica
{
    public class CustomersLogic :BaseLogic, IABMLogic<Customers>
    {

        public List<Customers> GetAll()
        {
            return contexto.Customers.ToList();
        }


        public void Add(Customers customer)
        {
            try
            {
                contexto.Customers.Add(customer);
                contexto.SaveChanges();
            }
            catch(ArgumentNullException ex)
            {
                throw new CustomException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }

        }

        public void Delete(int id)
        {
            //var customerDemographicsAEliminar = contexto.CustomerDemographics.First(c => c.CustomerTypeID == idType);
            try
            {
                var customerAEliminar = contexto.Customers.Find(id);
                contexto.Customers.Remove(customerAEliminar);
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
        /// Se modifican los siguientes campos: Adress, Fax, Phone, y PostalCode.
        /// </summary>
        /// <param name="customer"></param>
        public void Update(Customers customer)
        {
            try
            {
                var customerUpdate = contexto.Customers.Find(customer.CustomerID);
                customerUpdate.Address = customer.Address;
                customerUpdate.Fax = customer.Fax;
                customerUpdate.Phone = customer.Phone;
                customerUpdate.PostalCode = customer.PostalCode;
                customerUpdate.City = customer.City;
                customerUpdate.CompanyName = customer.CompanyName;
                customerUpdate.ContactName = customer.ContactName;
                customerUpdate.ContactTitle = customer.ContactTitle;
                customerUpdate.Country = customer.Country;
                customerUpdate.Region = customer.Region;

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
