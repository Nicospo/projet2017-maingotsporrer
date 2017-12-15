using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface INormalAccountRepository
    {
        IList<NormalAccount> GetAll();
        NormalAccount Get(int id);
        void Delete(NormalAccount Compte);
        void Edit(NormalAccount Compte);
        void Save(NormalAccount Compte);


    }
}
