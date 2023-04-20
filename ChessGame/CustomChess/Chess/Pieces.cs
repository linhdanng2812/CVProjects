namespace CustomChess
{
    public enum Player
    {
        BLACK,
        WHITE
    }
    public enum Piece
    {
        NONE = -1,
        PAWN,
        ROOK,
        KNIGHT,
        BISHOP,
        QUEEN,
        KING
    }
    public struct board_pos
    {
        public int letter;
        public int number;

        public board_pos(int letter, int number)
        {
            this.letter = letter;
            this.number = number;
        }
        public board_pos(board_pos copy)
        {
            this.letter = copy.letter;
            this.number = copy.number;
        }

        public override bool Equals(object obj)
        {
            return letter == ((board_pos)obj).letter && number == ((board_pos)obj).number;
        }
    }

    public struct piece_position
    {
        public Piece piece;
        public Player player;
        public board_pos lastPosition;

        public piece_position(Piece piece, Player player)
        {
            this.piece = piece;
            this.player = player;
            this.lastPosition = new board_pos(-1, -1);
        }

        public piece_position(piece_position copy)
        {
            this.piece = copy.piece;
            this.player = copy.player;
            this.lastPosition = copy.lastPosition;
        }
    }

    public struct move_t
    {
        public board_pos from;
        public board_pos to;

        public move_t(board_pos from, board_pos to)
        {
            this.from = from;
            this.to = to;
        }
    }
}