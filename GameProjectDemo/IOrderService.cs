using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IOrderService
    {
        void Order(Gamer gamer,Game game,Campaign campaign);
        
    }
}
