using System;
using System.Text;

namespace isEvenNumber
{

    class EvenNumber
    {

        public bool isEvenNumber(int number)
        {
            bool result = false;
            
            if(number % 2 == 0)
            {
                result = true;
            };

            return result;
        }

    }
}

