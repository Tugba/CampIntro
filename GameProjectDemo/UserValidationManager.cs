using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1990 && gamer.FirstName=="TUĞBA" && gamer.LastName=="ÜSTÜNDAĞ" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }      
        }

        
    }
}
