using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public interface ISort
    {
        public void SortAsc();
        public void SortDesc();
        public void SortByParam(bool isAsc);
    }
}
