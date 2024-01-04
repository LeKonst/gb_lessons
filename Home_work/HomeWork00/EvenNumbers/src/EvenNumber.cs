using System;
using System.Text;

namespace isEvenNumber
{

    class EvenNumber
    {

        public List<int> listEvenNumber(int number)
        {
            List<int> result = new List<int>();

            for(int i = 1; i <= number; i++){
                if(i % 2 == 0){
                    result.Add(i);
                }
            };

            return result;
        }

    }
}

