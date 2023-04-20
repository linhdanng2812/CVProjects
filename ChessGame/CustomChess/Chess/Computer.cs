using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomChess
{
    public class Computer
    {
        public static int DEPTH = 4;
        public static bool RUNNING = false;
        public static bool STOP = false;
        private static Player MAX = Player.BLACK;

        public static move_t FindOptimalMove(ChessBoard board, Player turn)
        {
            RUNNING = true; 
            STOP = false; 
            MAX = turn; 

            Dictionary<board_pos, List<board_pos>> moves = CheckValidMoves.getPlayerMoves(board, turn);
            int[] bestresults = new int[moves.Count];
            move_t[] bestmoves = new move_t[moves.Count];

            Parallel.ForEach(moves, (movelist,state,index) =>
            {
                if (STOP) // interupt
                {
                    state.Stop();
                    return;
                }

                bestresults[index] = int.MinValue;
                bestmoves[index] = new move_t(new board_pos(-1, -1), new board_pos(-1, -1));

                foreach (board_pos move in movelist.Value)
                {
                    if (STOP) 
                    {
                        state.Stop();
                        return;
                    }
                    ChessBoard b2 = CheckValidMoves.move(board, new move_t(movelist.Key, move));
                    int result = optimalMove(b2, (turn == Player.WHITE) ? Player.BLACK : Player.WHITE, 1, Int32.MinValue, Int32.MaxValue);

                    if (bestresults[index] < result || (bestmoves[index].to.Equals(new board_pos(-1, -1)) && bestresults[index] == int.MinValue))
                    {
                        bestresults[index] = result;
                        bestmoves[index].from = movelist.Key;
                        bestmoves[index].to = move;
                    }
                }
            });

            if (STOP)
                return new move_t(new board_pos(-1, -1), new board_pos(-1, -1)); 

            int best = int.MinValue;
            move_t m = new move_t(new board_pos(-1, -1), new board_pos(-1, -1));
            for(int i = 0; i < bestmoves.Length; i++)
            {
                if (best < bestresults[i] || (m.to.Equals(new board_pos(-1,-1)) && !bestmoves[i].to.Equals(new board_pos(-1,-1))))
                {
                    best = bestresults[i];
                    m = bestmoves[i];
                }
            }
            return m;
        }

        private static int optimalMove(ChessBoard board, Player turn, int depth, int alpha, int beta)
        {
            if (depth >= DEPTH)
                return board.ValidMove(MAX);
            else
            {
                List<ChessBoard> boards = new List<ChessBoard>();

                foreach (board_pos pos in board.Pieces[turn])
                {
                    if (STOP) return -1; 
                    List<board_pos> moves = CheckValidMoves.getLegalMove(board, pos);
                    foreach (board_pos move in moves)
                    {
                        if (STOP) return -1; 
                        ChessBoard b2 = CheckValidMoves.move(board, new move_t(pos, move));
                        boards.Add(b2);
                    }
                }

                int a = alpha, b = beta;
                if (turn != MAX) 
                {
                    foreach (ChessBoard b2 in boards)
                    {
                        if (STOP) return -1; 
                        b = Math.Min(b, optimalMove(b2, (turn == Player.WHITE) ? Player.BLACK : Player.WHITE, depth + 1, a, b));
                        if (a >= b)
                            return a;
                    }
                    return b;
                }
                else 
                {
                    foreach (ChessBoard b2 in boards)
                    {
                        if (STOP) return -1; 
                        a = Math.Max(a, optimalMove(b2, (turn == Player.WHITE) ? Player.BLACK : Player.WHITE, depth + 1, a, b));
                        if (a >= b)
                            return b;
                    }
                    return a;
                }
            }
        }
    }
}
