using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDal
    {

     //   ICrud Crud { get; } 
        IStudent student { get; }
        ITest Test { get; }
        IQuestion question { get; }
    }
}
