using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Moq
{
    public interface IPlayerDataMapper
    {
        bool PlayerNameExistsInDatabase(int id,string phone, string companyName);
        void InsertNewPlayerIntoDatabase(int id,string phone, string companyName);
        //void PlayerNameExistsInDatabase(int v);
    }
}
