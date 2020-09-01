using System;
using System.Collections.Generic;
using System.Text;

namespace WithISP
{
    interface IEmployee
    {
        void PaidLeave();
    }

    interface IContractEmployee
    {
        void Publicholiday();
        void SickLeave();
    }

    class ContractEmployee : IContractEmployee
    {
        public void Publicholiday()
        {
            throw new NotImplementedException();
        }

        public void SickLeave()
        {
            throw new NotImplementedException();
        }
    }

    class PermanentEmployee : IEmployee, IContractEmployee
    {
        public void PaidLeave()
        {
            throw new NotImplementedException();
        }

        public void Publicholiday()
        {
            throw new NotImplementedException();
        }

        public void SickLeave()
        {
            throw new NotImplementedException();
        }
    }

}

