using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class NormalAccountRepository : Repository, INormalAccountRepository
    {
        public IList<NormalAccount> GetAll()
        {
            return Session.Query<NormalAccount>().ToList();
        }
        public IList<NormalAccount> GetCompteAncien() 
        {
            DateTime sixMonthsAgo = DateTime.Today.AddDays(-183);
            String request = "select w from NormalAccount w where w.Update < :date";
            return Session.CreateQuery(request).SetDateTime("date", sixMonthsAgo).List<NormalAccount>();
        }
        public IList<NormalAccount> GetCompteFaible()/* A MODIFIER !!!*/
        {
            return Session.Query<NormalAccount>().ToList();
        }
        public NormalAccount Get(int id)
        {
            string requete = "select l from NormalAccount l where l.Id = "+id;
            return (NormalAccount)Session.CreateQuery(requete);
        }
        public void Delete(NormalAccount Compte)
        {
            Session.Delete(Compte);
            Session.Flush();
        }
        public void Edit(NormalAccount Compte)
        { }
        public void Save(NormalAccount Compte)
        {
            Session.SaveOrUpdate(Compte);
            Session.Flush();
        }
    }
}
