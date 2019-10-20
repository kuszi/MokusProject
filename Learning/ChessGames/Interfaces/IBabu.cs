using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGames
{
    interface IBabu
    {
        string BabuNev { get; set; }
        bool BabuSzine { get; set; }  //ha true: fehét, false:fekete
        void BabuMozgas();
        string BabuPozicio { get; set; }
        void BabuUtes();
    }
}
