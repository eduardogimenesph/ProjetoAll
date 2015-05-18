using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAll_Infrastructure_ADO.Contracts
{
    public interface IConnection
    {
        void InsertUpdateDelete();
        void Select();
    }
}
