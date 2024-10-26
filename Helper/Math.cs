using coolege_management.dto;

namespace coolege_management.Helper
{
    public class MathOperation
    {

        public int Add(ValueData obj)
        {
           ValidationLogic vl = new ValidationLogic();
           bool a = vl.validatelogic(obj.FirstValue,obj.SecondValue);
            if (a == true)
            {
                return obj.FirstValue + obj.SecondValue;
            }
            else
            {
                return 0;
            }
          
        }

    }
}
