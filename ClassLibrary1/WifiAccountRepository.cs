using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    class WifiAccountRepository : Repository, IWifiAccountRepository

    {
        public IList<WifiAccount> GetAll()
        {
            return Session.Query<WifiAccount>().ToList();
        }
        public IList<WifiAccount> GetCompteFaible() /* A MODIFIER !!!*/
        {
            return Session.Query<WifiAccount>().ToList();
        }
        public IList<WifiAccount> GetCompteAncien()/* A MODIFIER !!!*/
        {
            return Session.Query<WifiAccount>().ToList();
        }
        public WifiAccount Get(int id)
        {
            string requete = "select l from Account l where l.Id = " + id;
            return (WifiAccount)Session.CreateQuery(requete);
        }
        public void Delete(WifiAccount Compte)
        { }
        public void Edit(WifiAccount Compte)
        { }
        public void Save(WifiAccount Compte)
        {
            Session.SaveOrUpdate(Compte);
            Session.Flush();
        }
    }
}
