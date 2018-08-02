using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract2
{
    public class FunWithMaths
    {
        public int MultiplyNumbers(INumberProvider np) {
            var numbers = np.GetNumbers();
            var product = 1;
            foreach (var number in numbers)
                product *= number;

            return product;
        }
  
    }
}
