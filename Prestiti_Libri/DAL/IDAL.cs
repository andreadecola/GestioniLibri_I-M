using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestiti_Libri.DAL
{
    internal interface Idal<T>
    {
        bool insert(T t);
        List<T> GetAll(T t);
       
        bool delete(T t);
        bool update(T t);
    }
}
