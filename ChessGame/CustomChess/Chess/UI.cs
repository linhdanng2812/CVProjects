namespace CustomChess
{
    public interface UI
    {
        void SetBoard(ChessBoard board);
        void LogMove(string line);
        void SetStatus(bool thinking, string message);
        void SetTurn(Player p);
    }
}
