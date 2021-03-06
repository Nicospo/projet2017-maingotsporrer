﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IUserRepository
    {
        IList<User> GetAll();
        User Get(int id);
        void Delete(User Utilisateur);
        void Edit(User Utilisateur);
        void Save(User Utilisateur);
    }
}
