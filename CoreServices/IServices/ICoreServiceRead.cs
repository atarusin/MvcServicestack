using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreServices.IModels;

namespace CoreServices.IServices
{
    public interface ICoreServiceRead<T,TF, TId>
    {
        IEnumerable<T> Get(TF filter);
        T Get(TId id);
    }
}
