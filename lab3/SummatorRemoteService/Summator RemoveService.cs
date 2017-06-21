using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SummatorRemoteService
{
    public class SummatorRemoveService : MarshalByRefObject, ISummatorRemoveService
    {
        public int GetSum(int x, int y)
        {
            return x + y;
        }
    }
}
