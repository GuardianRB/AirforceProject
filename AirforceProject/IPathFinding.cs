using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirforceProject
{
    interface IPathFinding
    {
        void findPath(int weight, int speed, int fuel, int bombs);
    }
}
