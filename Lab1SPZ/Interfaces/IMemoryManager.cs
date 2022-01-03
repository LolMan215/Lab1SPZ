using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1SPZ.Interfaces
{
    public interface IMemoryManager
    {
        void ResetUsageBit();
        void Read(VirtualPage virtualPage);
        void Write(VirtualPage virtualPage);
        int GetPhysicalPage(VirtualPage virtualPage);
    }
}
