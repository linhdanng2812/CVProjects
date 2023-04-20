using System;
using System.Collections.Generic;
namespace CustomChess
{
    public class CheckValidMoves
    {
        
        public static ChessBoard move(ChessBoard b, move_t m)
        {
            ChessBoard b2 = new ChessBoard(b); 

            bool enpassant = (b2.Grid[m.from.number][m.from.letter].piece == Piece.PAWN && isEnPassant(b2, m));
            bool castling = (b2.Grid[m.from.number][m.from.letter].piece == Piece.KING && Math.Abs(m.to.letter - m.from.letter) == 2);

            b2.Pieces[b2.Grid[m.from.number][m.from.letter].player].Remove(m.from);

            if (b2.Grid[m.to.number][m.to.letter].piece != Piece.NONE && b2.Grid[m.from.number][m.from.letter].player != b2.Grid[m.to.number][m.to.letter].player)
                b2.Pieces[b2.Grid[m.to.number][m.to.letter].player].Remove(m.to);
            else if(enpassant) 
            {
                int step = (b.Grid[m.from.number][m.from.letter].player == Player.WHITE) ? -1 : 1;
                b2.Pieces[b2.Grid[m.to.number + step][m.to.letter].player].Remove(new board_pos(m.to.letter, m.to.number + step));
            }
            else if (castling)
            {
                if (m.to.letter == 6)
                {
                    b2.Pieces[b2.Grid[m.to.number][m.to.letter].player].Remove(new board_pos(7, m.to.number));
                    b2.Pieces[b2.Grid[m.to.number][m.to.letter].player].Add(new board_pos(5, m.to.number));
                }
                else
                {
                    b2.Pieces[b2.Grid[m.to.number][m.to.letter].player].Remove(new board_pos(0, m.to.number));
                    b2.Pieces[b2.Grid[m.to.number][m.to.letter].player].Remove(new board_pos(3, m.to.number));
                }
            }

            b2.Pieces[b2.Grid[m.from.number][m.from.letter].player].Add(m.to);

            b2.Grid[m.to.number][m.to.letter] = new piece_position(b2.Grid[m.from.number][m.from.letter]);
            b2.Grid[m.to.number][m.to.letter].lastPosition = m.from;
            b2.Grid[m.from.number][m.from.letter].piece = Piece.NONE;
            if (enpassant)
            {
                int step = (b.Grid[m.from.number][m.from.letter].player == Player.WHITE) ? -1 : 1;
                b2.Grid[m.to.number + step][m.to.letter].piece = Piece.NONE;
            }
            else if (castling)
            {
                if (m.to.letter == 6)
                {
                    b2.Grid[m.to.number][5] = new piece_position(b2.Grid[m.to.number][7]);
                    b2.Grid[m.to.number][7].piece = Piece.NONE;
                }
                else
                {
                    b2.Grid[m.to.number][3] = new piece_position(b2.Grid[m.to.number][0]);
                    b2.Grid[m.to.number][0].piece = Piece.NONE;
                }
            }


            if (b2.Grid[m.to.number][m.to.letter].piece == Piece.PAWN)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (b2.Grid[0][i].piece == Piece.PAWN)
                        b2.Grid[0][i].piece = Piece.QUEEN;
                    if (b2.Grid[7][i].piece == Piece.PAWN)
                        b2.Grid[7][i].piece = Piece.QUEEN;
                }
            }

            if (b2.Grid[m.to.number][m.to.letter].piece == Piece.KING)
            {
                b2.Kings[b2.Grid[m.to.number][m.to.letter].player] = m.to;
            }

            b2.LastMove[b2.Grid[m.to.number][m.to.letter].player] = m.to;

            return b2;
        }

        public static bool isCheck(ChessBoard b, Player king)
        {
            if (b.Kings.Count == 0) return true;

            board_pos king_pos = b.Kings[king];
            if (king_pos.number < 0 || king_pos.letter < 0) return true;

            Piece[] pieces = { Piece.PAWN, Piece.ROOK, Piece.KNIGHT, Piece.BISHOP, Piece.QUEEN, Piece.KING };

            ChessBoard tempBoard = new ChessBoard(b);

            for (int i = 0; i < 6; i++)
            {
                tempBoard.Grid[king_pos.number][king_pos.letter] = new piece_position(pieces[i], king);
                List<board_pos> moves = getLegalMove(tempBoard, king_pos, false);
                foreach (var move in moves)
                {
                    if (b.Grid[move.number][move.letter].piece == pieces[i] &&
                        b.Grid[move.number][move.letter].player != king)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public static Dictionary<board_pos, List<board_pos>> getPlayerMoves(ChessBoard b, Player player)
        {
            Dictionary<board_pos, List<board_pos>> moves = new Dictionary<board_pos, List<board_pos>>();
            foreach (board_pos pos in b.Pieces[player])
                if (b.Grid[pos.number][pos.letter].piece != Piece.NONE)
                {
                    if (!moves.ContainsKey(pos)) moves[pos] = new List<board_pos>();
                    moves[pos].AddRange(CheckValidMoves.getLegalMove(b, pos));
                }
            return moves;
        }


        public static List<board_pos> getLegalMove(ChessBoard board, board_pos pos, bool verify_check = true)
        {
            piece_position p = board.Grid[pos.number][pos.letter];
            if (p.piece == Piece.NONE) return new List<board_pos>();

            switch (p.piece)
            {
                case Piece.PAWN:
                    return CheckValidMoves.Pawn(board, pos, verify_check);
                case Piece.ROOK:
                    return CheckValidMoves.Rook(board, pos, verify_check);
                case Piece.KNIGHT:
                    return CheckValidMoves.Knight(board, pos, verify_check);
                case Piece.BISHOP:
                    return CheckValidMoves.Bishop(board, pos, verify_check);
                case Piece.QUEEN:
                    return CheckValidMoves.Queen(board, pos, verify_check);
                case Piece.KING:
                    return CheckValidMoves.King(board, pos, verify_check);
                default:
                    return new List<board_pos>();
            }
        }
        public static bool hasMoves(ChessBoard b, Player player)
        {
            foreach (board_pos pos in b.Pieces[player])
                if (b.Grid[pos.number][pos.letter].piece != Piece.NONE &&
                    b.Grid[pos.number][pos.letter].player == player &&
                    getLegalMove(b, pos).Count > 0) return true;
            return false;
        }
        private static List<board_pos> Slide(ChessBoard board, Player p, board_pos pos, board_pos step)
        {
            List<board_pos> moves = new List<board_pos>();
            for (int i = 1; i < 8; i++)
            {
                board_pos moved = new board_pos(pos.letter + i * step.letter, pos.number + i * step.number);

                if (moved.letter < 0 || moved.letter > 7 || moved.number < 0 || moved.number > 7)
                    break;

                if (board.Grid[moved.number][moved.letter].piece != Piece.NONE)
                {
                    if (board.Grid[moved.number][moved.letter].player != p)
                        moves.Add(moved);
                    break;
                }
                moves.Add(moved);
            }
            return moves;
        }

       
        private static List<board_pos> King(ChessBoard board, board_pos pos, bool verify_check = true)
        {
            List<board_pos> moves = new List<board_pos>();

            piece_position p = board.Grid[pos.number][pos.letter];
            if (p.piece == Piece.NONE) return moves;

            List<board_pos> relative = new List<board_pos>();

            relative.Add(new board_pos(-1, 1));
            relative.Add(new board_pos(0, 1));
            relative.Add(new board_pos(1, 1));

            relative.Add(new board_pos(-1, 0));
            relative.Add(new board_pos(1, 0));

            relative.Add(new board_pos(-1, -1));
            relative.Add(new board_pos(0, -1));
            relative.Add(new board_pos(1, -1));

            foreach (board_pos move in relative)
            {
                board_pos moved = new board_pos(move.letter + pos.letter, move.number + pos.number);

                if (moved.letter < 0 || moved.letter > 7 || moved.number < 0 || moved.number > 7)
                    continue;

                if (board.Grid[moved.number][moved.letter].piece == Piece.NONE || board.Grid[moved.number][moved.letter].player != p.player)
                {
                    if (verify_check) 
                    {
                        ChessBoard b2 = CheckValidMoves.move(board, new move_t(pos, moved));
                        if(!isCheck(b2, p.player))
                        {
                            moves.Add(moved);
                            
                        }
                    }
                    else
                    {
                        moves.Add(moved);
                    }
                }
            }
            if (verify_check)
            {
                if (!isCheck(board, p.player)
                    && p.lastPosition.Equals(new board_pos(-1,-1)))
                {
                    bool castleRight = canCastling(board, p.player, pos, true);
                    bool castleLeft = canCastling(board, p.player, pos, false);

                    if (castleRight)
                    {
                        moves.Add(new board_pos(6, pos.number));
                    }
                    if (castleLeft)
                    {
                        moves.Add(new board_pos(2, pos.number));
                    }
                }
            }

            return moves;
        }

        private static bool canCastling(ChessBoard board, Player player, board_pos pos, bool isRight)
        {
            bool isValid = true;
            int rookPos;
            int kingDirection;
            if (isRight)
            {
                rookPos = 7;
                kingDirection = 1;
            }
            else
            {
                rookPos = 0;
                kingDirection = -1;
            }

            if (board.Grid[pos.number][rookPos].piece == Piece.ROOK &&
                board.Grid[pos.number][rookPos].player == player && board.Grid[pos.number][rookPos].lastPosition.Equals(new board_pos(-1,-1)))
            {
                for (int i = 0; i < 2; i++)
                {
                    if (board.Grid[pos.number][pos.letter + (i + 1) * kingDirection].piece != Piece.NONE)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        ChessBoard b2 = CheckValidMoves.move(board, new move_t(pos, new board_pos(pos.letter + (i + 1) * kingDirection, pos.number)));

                        if (isCheck(b2, player))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }

        private static List<board_pos> Queen(ChessBoard board, board_pos pos, bool verify_check = true)
        {
            List<board_pos> moves = new List<board_pos>();

            piece_position p = board.Grid[pos.number][pos.letter];
            if (p.piece == Piece.NONE) return moves;

            moves.AddRange(Slide(board, p.player, pos, new board_pos(1, 0)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(-1, 0)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(0, 1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(0, -1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(1, 1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(-1, -1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(-1, 1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(1, -1)));

            if (verify_check) 
            {
                for (int i = moves.Count - 1; i >= 0; i--)
                {
                    ChessBoard b2 = CheckValidMoves.move(board, new move_t(pos, moves[i]));
                    if (isCheck(b2, p.player))
                    {
                        moves.RemoveAt(i);
                    }
                }
            }
            return moves;
        }

        private static List<board_pos> Bishop(ChessBoard board, board_pos pos, bool verify_check = true)
        {
            List<board_pos> moves = new List<board_pos>();

            piece_position p = board.Grid[pos.number][pos.letter];
            if (p.piece == Piece.NONE) return moves;

            moves.AddRange(Slide(board, p.player, pos, new board_pos(1, 1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(-1, -1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(-1, 1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(1, -1)));

            if (verify_check) 
            {
                for (int i = moves.Count - 1; i >= 0; i--)
                {
                    ChessBoard b2 = CheckValidMoves.move(board, new move_t(pos, moves[i]));
                    if (isCheck(b2, p.player))
                    {
                        moves.RemoveAt(i);
                    }
                }
            }
            return moves;
        }

        private static List<board_pos> Knight(ChessBoard board, board_pos pos, bool verify_check = true)
        {
            List<board_pos> moves = new List<board_pos>();

            piece_position p = board.Grid[pos.number][pos.letter];
            if (p.piece == Piece.NONE) return moves;

            List<board_pos> relative = new List<board_pos>();

            relative.Add(new board_pos(2, 1));
            relative.Add(new board_pos(2, -1));

            relative.Add(new board_pos(-2, 1));
            relative.Add(new board_pos(-2, -1));

            relative.Add(new board_pos(1, 2));
            relative.Add(new board_pos(-1, 2));

            relative.Add(new board_pos(1, -2));
            relative.Add(new board_pos(-1, -2));

            foreach (board_pos move in relative)
            {
                board_pos moved = new board_pos(move.letter + pos.letter, move.number + pos.number);

                if (moved.letter < 0 || moved.letter > 7 || moved.number < 0 || moved.number > 7)
                    continue;

                if (board.Grid[moved.number][moved.letter].piece == Piece.NONE ||
                    board.Grid[moved.number][moved.letter].player != p.player) 
                    moves.Add(moved);
            }

            if (verify_check)
            {
                for (int i = moves.Count - 1; i >= 0; i--)
                {
                    ChessBoard b2 = CheckValidMoves.move(board, new move_t(pos, moves[i]));
                    if (isCheck(b2, p.player))
                    {
                        moves.RemoveAt(i);
                    }
                }
            }
            return moves;
        }

        private static List<board_pos> Rook(ChessBoard board, board_pos pos, bool verify_check = true)
        {
            List<board_pos> moves = new List<board_pos>();

            piece_position p = board.Grid[pos.number][pos.letter];
            if (p.piece == Piece.NONE) return moves;

            moves.AddRange(Slide(board, p.player, pos, new board_pos(1, 0)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(-1, 0)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(0, 1)));
            moves.AddRange(Slide(board, p.player, pos, new board_pos(0, -1)));

            if (verify_check)
            {
                for (int i = moves.Count - 1; i >= 0; i--)
                {
                    ChessBoard b2 = CheckValidMoves.move(board, new move_t(pos, moves[i]));
                    if (isCheck(b2, p.player))
                    {
                        moves.RemoveAt(i);
                    }
                }
            }
            return moves;
        }
        public static bool isEnPassant(ChessBoard b, move_t m)
        {
            int step = ((b.Grid[m.from.number][m.from.letter].player == Player.WHITE) ? -1 : 1);

            return (
                b.Grid[m.from.number][m.from.letter].piece == Piece.PAWN &&
                b.Grid[m.to.number][m.to.letter].piece == Piece.NONE &&
                m.to.letter != m.from.letter &&
                b.Grid[m.to.number + step][m.to.letter].piece == Piece.PAWN &&
                b.LastMove[(b.Grid[m.from.number][m.from.letter].player == Player.WHITE) ? Player.BLACK : Player.WHITE].Equals(new board_pos(m.to.letter, m.to.number + step)) &&
                Math.Abs(b.Grid[m.to.number + step][m.to.letter].lastPosition.number - (m.to.number + step)) == 2 //jumped from last position
                );
        }
        private static List<board_pos> Pawn(ChessBoard board, board_pos pos, bool verify_check = true)
        {
            List<board_pos> moves = new List<board_pos>();

            piece_position p = board.Grid[pos.number][pos.letter];
            if (p.piece == Piece.NONE) return moves;

            List<board_pos> relative = new List<board_pos>();
            relative.Add(new board_pos(-1, 1 * ((p.player == Player.BLACK) ? -1 : 1)));
            relative.Add(new board_pos(0, 1 * ((p.player == Player.BLACK) ? -1 : 1)));
            relative.Add(new board_pos(0, 2 * ((p.player == Player.BLACK) ? -1 : 1)));
            relative.Add(new board_pos(1, 1 * ((p.player == Player.BLACK) ? -1 : 1)));

            foreach (board_pos move in relative)
            {
                board_pos moved = new board_pos(move.letter + pos.letter, move.number + pos.number);

                if (moved.letter < 0 || moved.letter > 7 || moved.number < 0 || moved.number > 7)
                    continue;

                if (moved.letter == pos.letter && board.Grid[moved.number][moved.letter].piece == Piece.NONE && Math.Abs(moved.number - pos.number) == 2)
                {
                    int step = -((moved.number - pos.number) / (Math.Abs(moved.number - pos.number)));
                    bool hasnt_moved = pos.number == ((p.player == Player.BLACK) ? 6 : 1);
                    if (board.Grid[moved.number + step][moved.letter].piece == Piece.NONE && hasnt_moved)
                    {
                        moves.Add(moved);
                    }
                }
                else if (moved.letter == pos.letter && board.Grid[moved.number][moved.letter].piece == Piece.NONE)
                {
                    moves.Add(moved);
                }
                else if (moved.letter != pos.letter && board.Grid[moved.number][moved.letter].piece != Piece.NONE && board.Grid[moved.number][moved.letter].player != p.player)
                {
                    moves.Add(moved);
                }
                else if(isEnPassant(board, new move_t(pos,moved)))
                {
                    moves.Add(moved);
                }
            }

            if (verify_check)
            {
                for (int i = moves.Count - 1; i >= 0; i--)
                {
                    ChessBoard b2 = CheckValidMoves.move(board, new move_t(pos, moves[i]));
                    if (isCheck(b2, p.player))
                    {
                        moves.RemoveAt(i);
                        
                        
                    }
                }
            }
            return moves;
        }

        
    }
}
