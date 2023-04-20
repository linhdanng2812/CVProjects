using System;
using System.Collections.Generic;
using System.Drawing;

namespace CustomChess
{
    public class PieceImage
    {
        private string _directory;
        public Dictionary<Player,Dictionary<Piece, Image>> Pieces { get; private set; }
        public Dictionary<Player, Image> TurnIndicator { get; private set; }

        public PieceImage(string path)
        {
            _directory = path;

            LoadGraphics();   
        }
        private void LoadGraphics()
        {
            TurnIndicator = new Dictionary<Player, Image>();
            TurnIndicator[Player.WHITE] = Bitmap.FromFile(_directory + "turn_w.png");
            TurnIndicator[Player.BLACK] = Bitmap.FromFile(_directory + "turn_b.png");

            Pieces = new Dictionary<Player, Dictionary<Piece, Image>>();
            foreach (Player pl in Enum.GetValues(typeof(Player)))
            {
                Pieces[pl] = new Dictionary<Piece, Image>();

                foreach (Piece p in Enum.GetValues(typeof(Piece)))
                {
                    string file = _directory;

                    switch (p)
                    {
                        case Piece.PAWN:
                            file += "pawn";
                            break;
                        case Piece.ROOK:
                            file += "rook";
                            break;
                        case Piece.KNIGHT:
                            file += "knight";
                            break;
                        case Piece.BISHOP:
                            file += "bishop";
                            break;
                        case Piece.QUEEN:
                            file += "queen";
                            break;
                        case Piece.KING:
                            file += "king";
                            break;
                        case Piece.NONE:
                            continue;
                    }
                    file += "_";

                    switch (pl)
                    {
                        case Player.BLACK:
                            file += "b";
                            break;
                        case Player.WHITE:
                            file += "w";
                            break;
                    }
                    file += ".png";
                    Pieces[pl][p] = Bitmap.FromFile(file);
                }
            }
        }
    }
}
