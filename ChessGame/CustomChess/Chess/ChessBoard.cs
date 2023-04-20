using System.Collections.Generic;

namespace CustomChess
{
    public class ChessBoard
    {
        //special piece
        public Dictionary<Player, board_pos> Kings
        { 
            get;
            private set;
        }
        public Dictionary<Player, List<board_pos>> Pieces 
        { 
            get;
            private set; 
        }
        public Dictionary<Player, board_pos> LastMove 
        { 
            get;
            private set;
        }
        private static int[] points = { 1, 3, 4, 5, 7, 20 };
        public piece_position[][] Grid 
        { 
            get; 
            private set;
        }
        public ChessBoard()
        {
            Grid = new piece_position[8][];
            for (int i = 0; i < 8; i++)
            {
                Grid[i] = new piece_position[8];
                for (int j = 0; j < 8; j++)
                    Grid[i][j] = new piece_position(Piece.NONE, Player.WHITE);
            }

            LastMove = new Dictionary<Player, board_pos>();
            LastMove[Player.BLACK] = new board_pos();
            LastMove[Player.WHITE] = new board_pos();

            Kings = new Dictionary<Player, board_pos>();

            Pieces = new Dictionary<Player, List<board_pos>>();
            Pieces.Add(Player.BLACK, new List<board_pos>());
            Pieces.Add(Player.WHITE, new List<board_pos>());
        }

        public ChessBoard(ChessBoard copy)
        {
            Pieces = new Dictionary<Player, List<board_pos>>();
            Pieces.Add(Player.BLACK, new List<board_pos>());
            Pieces.Add(Player.WHITE, new List<board_pos>());

            Grid = new piece_position[8][];
            for (int i = 0; i < 8; i++)
            {
                Grid[i] = new piece_position[8];
                for (int j = 0; j < 8; j++)
                {
                    Grid[i][j] = new piece_position(copy.Grid[i][j]);

                    if (Grid[i][j].piece != Piece.NONE)
                        Pieces[Grid[i][j].player].Add(new board_pos(j, i));
                }
            }
            LastMove = new Dictionary<Player, board_pos>();
            LastMove[Player.BLACK] = new board_pos(copy.LastMove[Player.BLACK]);
            LastMove[Player.WHITE] = new board_pos(copy.LastMove[Player.WHITE]);

            Kings = new Dictionary<Player, board_pos>();
            Kings[Player.BLACK] = new board_pos(copy.Kings[Player.BLACK]);
            Kings[Player.WHITE] = new board_pos(copy.Kings[Player.WHITE]);
        }

        public int ValidMove(Player p)
        {
            int valid = 0;
            int[] blackPieces = { 0, 0, 0, 0, 0, 0 };
            int[] whitePieces = { 0, 0, 0, 0, 0, 0 };
            int blackMoves = 0;
            int whiteMoves = 0;

            foreach (board_pos pos in Pieces[Player.BLACK])
            {
                blackMoves += CheckValidMoves.getLegalMove(this, pos).Count;
                blackPieces[(int)Grid[pos.number][pos.letter].piece]++;
            }

            foreach (board_pos pos in Pieces[Player.WHITE])
            {
                whiteMoves += CheckValidMoves.getLegalMove(this, pos).Count;
                whitePieces[(int)Grid[pos.number][pos.letter].piece]++;
            }

            if (p == Player.BLACK)
            {
                for (int i = 0; i < 6; i++)
                {
                    valid += points[i] * (blackPieces[i] - whitePieces[i]);
                }

                valid += (int)(0.5 * (blackMoves - whiteMoves));
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    valid += points[i] * (whitePieces[i] - blackPieces[i]);
                }
                valid += (int)(0.5 * (whiteMoves - blackMoves));
            }

            return valid;
        }

        public void PutPiecesToStartNewGame()
        {
            for (int i = 0; i < 8; i++)
            {
                PutPiecesOnBoard(Piece.PAWN, Player.WHITE, i, 1);
                PutPiecesOnBoard(Piece.PAWN, Player.BLACK, i, 6);
            }
            PutPiecesOnBoard(Piece.KING, Player.WHITE, 4, 0);
            PutPiecesOnBoard(Piece.KING, Player.BLACK, 4, 7);
            Kings[Player.WHITE] = new board_pos(4, 0);
            Kings[Player.BLACK] = new board_pos(4, 7);
            PutPiecesOnBoard(Piece.QUEEN, Player.WHITE, 3, 0);
            PutPiecesOnBoard(Piece.QUEEN, Player.BLACK, 3, 7);

            PutPiecesOnBoard(Piece.ROOK, Player.WHITE, 0, 0);
            PutPiecesOnBoard(Piece.ROOK, Player.WHITE, 7, 0);
            PutPiecesOnBoard(Piece.ROOK, Player.BLACK, 0, 7);
            PutPiecesOnBoard(Piece.ROOK, Player.BLACK, 7, 7);

            PutPiecesOnBoard(Piece.KNIGHT, Player.WHITE, 1, 0);
            PutPiecesOnBoard(Piece.KNIGHT, Player.WHITE, 6, 0);
            PutPiecesOnBoard(Piece.KNIGHT, Player.BLACK, 1, 7);
            PutPiecesOnBoard(Piece.KNIGHT, Player.BLACK, 6, 7);

            PutPiecesOnBoard(Piece.BISHOP, Player.WHITE, 2, 0);
            PutPiecesOnBoard(Piece.BISHOP, Player.WHITE, 5, 0);
            PutPiecesOnBoard(Piece.BISHOP, Player.BLACK, 2, 7);
            PutPiecesOnBoard(Piece.BISHOP, Player.BLACK, 5, 7);

        }

        public void PutPiecesOnBoard(Piece piece, Player player, int letter, int number)
        {
            Grid[number][letter].piece = piece;
            Grid[number][letter].player = player;

            Pieces[player].Add(new board_pos(letter, number));

            if (piece == Piece.KING)
            {
                Kings[player] = new board_pos(letter, number);
            }
        }
    }
}
