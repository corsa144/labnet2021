using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.Logica
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T entidad);
        void Delete(int id);
        void Update(T entidad);

    }
}
