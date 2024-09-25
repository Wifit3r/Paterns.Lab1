using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeployment
{
    public interface IClonable
    {
        Action ActCopy(Action toCopy);
    }
}
