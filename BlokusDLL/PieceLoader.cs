using Newtonsoft.Json;
using System;
using System.Linq;

namespace BlokusDLL
{
    class PieceLoader
    {
        public static void LoadPieces()
        {
            var test = @" {'coords': [[0,0],[1,0],[2,0],[3,0],[3,1]], 'liberty':[[0,0,12],[3,0,1],[3,1,6]]}";
            Piece p = JsonConvert.DeserializeObject<Piece>(test);
            int i = 0;
        }

        public static int Main(string[] argv)
        {
            LoadPieces();
            return 0;
        }
    }
}
