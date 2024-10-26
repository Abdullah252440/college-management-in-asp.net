using coolege_management.dto;

namespace coolege_management.Helper
{
    public class ValidationLogic
    {
        public bool validatelogic(int obj,int o)
        {
           if (obj >= 20 & o>=20)
            {
                return true;
            }
           return false;
        }
    }
}
