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

        public NormalAccount Get(int id)
        {
            string requete = "select l from Account l where l.Id = "+id;
            return (NormalAccount)Session.CreateQuery(requete);
        }
        public void Delete(NormalAccount Compte)
        { }
        public void Edit(NormalAccount Compte)
        { }
        public void Save(NormalAccount Compte)
        {
            Session.SaveOrUpdate(Compte);
            Session.Flush();
        }
    }
}
