using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Book
    {
        string _bookName;
        //float _price;

        public string Print()
        {
            return _bookName;
        }

        public void Input (string bkName)
        {
            _bookName = bkName;
        }

       
           
        
    }
}
