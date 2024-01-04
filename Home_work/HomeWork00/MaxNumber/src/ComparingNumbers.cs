using System;
using System.Text;

namespace MaxNumber
{

    class ComparingNumbers
    {

        public int MaxNumber(int first_number, int second_number)
        {
            int result = first_number;
            
            if(result<second_number)
            {
                result = second_number;
            };

            return result;
        }

    }
}

