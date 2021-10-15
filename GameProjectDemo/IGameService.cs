using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void UPdate(Game game);
    }
}
