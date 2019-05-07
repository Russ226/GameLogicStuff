using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Provinces.Interfaces
{
    // this will contain logic that has side effects else where
    interface IProvinceOperations
    {
        List<Models.Province> ReadProvinceJsonFiles();
        List<Models.Resource> ReadeResourceJsonFiles();
    }
}
