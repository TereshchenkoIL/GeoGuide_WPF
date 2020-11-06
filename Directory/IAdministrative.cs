using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    interface IAdministrative
    {
           string Capital { get; set; }
       
           string Form { get; set; }

           void Set_Form(string form);

           void Set_Cap(string city);
        

    }
}
