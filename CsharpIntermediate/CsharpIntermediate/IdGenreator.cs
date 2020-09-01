using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIntermediate
{
    class IdGenreator
    {
        // use System date to create id for an Account Holder
        static int id = 0;
        string storeID;
        DateTime dt = new DateTime();

        public IdGenreator()
        {

        }
        public string GenerateID()
        {
            string gid = DateTime.Now.ToString("yyyy-MM");
            storeID = gid + ++id;
            return storeID;
        }
    }
}
