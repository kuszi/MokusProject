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
        bool BabuSzine { get; set; }
        void BabuMozgas();
        string BabuPozicio { get; set; }
        void BabuUtes();
    }
}
