using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IWifiAccountRepository
    {
        IList<WifiAccount> GetAll();
        WifiAccount Get(int id);
        void Delete(WifiAccount CompteWifi);
        void Edit(WifiAccount CompteWifi);
        void Save(WifiAccount Compte);
    }
}
