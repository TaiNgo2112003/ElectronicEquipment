using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Controller
{
    public interface IController<T>
    {
        bool Save (T entity);
        bool Delete (T entity);
        bool Update (T entity);
        bool isValidate(T entity);
    }
}
