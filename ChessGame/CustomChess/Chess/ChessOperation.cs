using System;
using System.Collections.Generic;
using System.Threading;

namespace CustomChess
{
    public class Chess
    {
        public ChessBoard Board { get; private set; }
        public Player SwitchPlayer { get; private set; }
        public board_pos Selection { get; private set; }

        private UI UI;
        private int players;

        public Chess(UI ui, int nPlayers = 1, bool setupBoard = true)
        {
            this.UI = ui;
            this.UI.SetStatus(true, "Thinking next move...");

            this.players = nPlayers;
            this.SwitchPlayer = Player.WHITE;

            this.Board = new ChessBoard();
            if (setupBoard)
            {
                this.Board.PutPiecesToStartNewGame();
            }

            this.UI.SetBoard(Board);
            this.UI.SetStatus(false, "White's turn.");
        }

        public void ComputerMove()
        {
            while (Computer.RUNNING)
            {
                Thread.Sleep(100);
            }

            this.UI.SetStatus(true, "Thinking...");

            move_t move = Computer.FindOptimalMove(this.Board, this.SwitchPlayer);

            if (move.to.letter >= 0 && move.to.number >= 0)
            {
                MakeMove(move);
            }
            else 
            {
                if (!Computer.STOP) 
                {
                    this.UI.LogMove("Null\n");
                }
            }

            bool checkmate = false;

            if (!Computer.STOP)
            {
                switchPlayer();
                checkmate = detectCheckmate();
            }

            Computer.RUNNING = false;
            if (!Computer.STOP && this.players == 0 && !checkmate)
            {
                new Thread(ComputerMove).Start();
            }
        }

        public List<board_pos> Select(board_pos pos)
        {
            if (this.Board.Grid[this.Selection.number][this.Selection.letter].piece != Piece.NONE
                && this.SwitchPlayer == this.Board.Grid[this.Selection.number][this.Selection.letter].player
                && (this.players == 2 
                || this.SwitchPlayer == Player.WHITE)) 
            {
                List<board_pos> moves = CheckValidMoves.getLegalMove(this.Board, this.Selection);
                foreach (board_pos move in moves)
                {
                    if (move.Equals(pos))
                    {
                        MakeMove(new move_t(this.Selection, pos));
                        if (this.Board.Grid[pos.number][pos.letter].piece == Piece.KING && Math.Abs(pos.letter - this.Selection.letter) == 2)
                        {
                            int row = (this.SwitchPlayer == Player.WHITE) ? 0 : 7;

                            if (pos.letter < 4)
                            {
                                CheckValidMoves.move(this.Board, new move_t(new board_pos(0, row), new board_pos(3, row)));
                            }
                            else
                            {
                                CheckValidMoves.move(this.Board, new move_t(new board_pos(7, row), new board_pos(5, row)));
                            }
                        }
                        switchPlayer();
                        if (detectCheckmate()) return new List<board_pos>();

                        if (this.players == 1) 
                        {
                            new Thread(ComputerMove).Start(); 
                        }
                        return new List<board_pos>();
                    }
                }
            }
            if (this.Board.Grid[pos.number][pos.letter].player == this.SwitchPlayer && (this.players == 2 || this.SwitchPlayer == Player.WHITE))
            {
                List<board_pos> moves = CheckValidMoves.getLegalMove(this.Board, pos);
                this.Selection = pos;
                return moves;
            }

            this.Selection = new board_pos();
            return new List<board_pos>();
        }

        private void MakeMove(move_t m)
        {
            string move = (this.SwitchPlayer == Player.WHITE) ? "W" : "B";

            move += ":\t";

            // piece
            SoundEffect sound = new SoundEffect("../../Library/");
            switch (this.Board.Grid[m.from.number][m.from.letter].piece)
            {
                case Piece.PAWN:
                    move += "P";
                    sound.MoveSound();
                    break;
                case Piece.ROOK:
                    move += "R";
                    sound.MoveSound();
                    break;
                case Piece.KNIGHT:
                    move += "k";
                    sound.MoveSound();
                    break;
                case Piece.BISHOP:
                    move += "B";
                    sound.MoveSound();
                    break;
                case Piece.QUEEN:
                    move += "Q";
                    sound.MoveSound();
                    break;
                case Piece.KING:
                    move += "K";
                    sound.MoveSound();
                    break;
            }

            if (this.Board.Grid[m.to.number][m.to.letter].piece != Piece.NONE || CheckValidMoves.isEnPassant(this.Board, m))
            {
                
                sound.AttackSound();
                move += "x";
            }

            switch (m.to.letter)
            {
                case 0: move += "a"; break;
                case 1: move += "b"; break;
                case 2: move += "c"; break;
                case 3: move += "d"; break;
                case 4: move += "e"; break;
                case 5: move += "f"; break;
                case 6: move += "g"; break;
                case 7: move += "h"; break;
            }
            move += (m.to.number + 1).ToString();

            this.Board = CheckValidMoves.move(this.Board, m);

            if (CheckValidMoves.isCheck(this.Board, (SwitchPlayer == Player.WHITE) ? Player.BLACK : Player.WHITE))
            {
                move += "+";
                
                sound.CheckmateSound();
            }
            this.UI.LogMove(move + "\n");

        }
        private void switchPlayer()
        {
            this.SwitchPlayer = (this.SwitchPlayer == Player.WHITE) ? Player.BLACK : Player.WHITE;
            this.UI.SetTurn(this.SwitchPlayer);
            this.UI.SetStatus(false, ((this.SwitchPlayer == Player.WHITE) ? "White" : "Black") + "'s Turn.");
            this.UI.SetBoard(this.Board);
        }

        public bool detectCheckmate()
        {
            bool draw_case1 = this.Board.Pieces[Player.WHITE].Count == 1 && this.Board.Grid[this.Board.Pieces[Player.WHITE][0].number][this.Board.Pieces[Player.WHITE][0].letter].piece == Piece.KING;
            bool draw_case2 = this.Board.Pieces[Player.BLACK].Count == 1 && this.Board.Grid[this.Board.Pieces[Player.BLACK][0].number][this.Board.Pieces[Player.BLACK][0].letter].piece == Piece.KING;

            if (!CheckValidMoves.hasMoves(this.Board, this.SwitchPlayer))
            {
                if (CheckValidMoves.isCheck(this.Board, this.SwitchPlayer))
                {
                    SoundEffect sound = new SoundEffect("../../Library/");
                    sound.EndGameSound();
                    this.UI.LogMove("Checkmate! End!\n");
                    this.UI.SetStatus(false, ((this.SwitchPlayer == Player.WHITE) ? "Black" : "White") + " wins!");
                }
                else
                {
                    SoundEffect sound = new SoundEffect("../../Library/");
                    sound.EndGameSound();
                    this.UI.LogMove("Stalemate! End!\n");
                }
                return true;
            }
            else if (draw_case1 && draw_case2)
            {
                SoundEffect sound = new SoundEffect("../../Library/");
                sound.EndGameSound();
                this.UI.LogMove("Draw. End!\n");
                return true;
            }
            return false;
        }
        public void Undo()
        {

        }
        
    }
}
