using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    class UserRepository : Repository, IUserRepository
    {
        public IList<User> GetAll()
        {
            return Session.Query<User>().ToList();
        }

        public User Get(int id)
        {
            string requete = "select l from Account l where l.Id = " + id;
            return (User)Session.CreateQuery(requete);
        }
        public void Delete(User Utilisateur)
        { }
        public void Edit(User Utilisateur)
        { }
        public void Save(User Utilisateur)
        {
            Session.SaveOrUpdate(Utilisateur);
            Session.Flush();
        }
    }
}
