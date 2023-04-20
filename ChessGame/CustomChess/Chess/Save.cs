using System.Windows.Forms;

namespace CustomChess
{
	public class Save
	{
        public void SaveGame()
		{
			Intermediate chess = new Intermediate();
			SaveFileDialog saveAsBox = new SaveFileDialog();
			saveAsBox.Title = "Save current game as...";
			saveAsBox.Filter = "Custom Chess Game (*.ccg)|*.ccg";
			saveAsBox.RestoreDirectory = true;
			if (saveAsBox.ShowDialog() == DialogResult.OK)
			{
				chess.SaveGame(saveAsBox.FileName);
			}
		}

	}
}
