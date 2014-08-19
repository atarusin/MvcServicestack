using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreServices.IModels;

namespace CoreServices.IServices
{
    public interface ICoreServiceDelete<TId>
    {
        void Delete(TId id);
    }
}
