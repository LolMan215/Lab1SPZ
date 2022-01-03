using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1SPZ.Interfaces
{
    public interface IProcessService
    {
        void StartProcessing(Process process);

        void UpdateWorkingSet(Process process);
    }
}
