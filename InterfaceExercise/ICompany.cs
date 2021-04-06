using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface ICompany
    {
        public string CompanyName { set; get; }

        public string CompanyType { get; set; }

        public void CompanyInit(string name, string type);

    }
}
