using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class UserRepository : Repository, IUserRepository
    {
        public IList<User> GetAll()
        {
            return Session.Query<User>().ToList();
        }

        public User Get(int id)
        {
            string requete = "select l from User l where l.Id = ?";
            return Session.CreateQuery(requete).SetInt32(0, id).List<User>()[0];
        }
        public void Delete(User Utilisateur)
        {
            Session.Delete(Utilisateur);
            Session.Flush();
        }
        public void Edit(User Utilisateur)
        { }
        public void Save(User Utilisateur)
        {
            Session.SaveOrUpdate(Utilisateur);
            Session.Flush();
        }

       
    }
}
