using System.Runtime.InteropServices; 

namespace CustomChess
{
	public class SoundEffect
	{
		private string mainFolder;
		private int SND_ASYNC = 0x0001;     
		private int SND_FILENAME = 0x00020000; 
		private int SND_PURGE = 0x0040;    

		public SoundEffect(string folder)
		{
			mainFolder = folder;
		}
		[DllImport("WinMM.dll")]
		public static extern bool PlaySound(string fname, int Mod, int flag);

		public void PlaySound(string file)
		{
			int SoundFlags = SND_ASYNC | SND_FILENAME;
			PlaySound(file, 0, SoundFlags);
		}

		public void StopPlay()
		{
			PlaySound(null, 0, SND_PURGE);
		}

		public void ClickSound()
		{
			StopPlay();
			PlaySound(mainFolder + "click.wav");
		}

		public void MoveSound()
		{
			StopPlay();
			PlaySound(mainFolder + "move.wav");
		}
		public void AttackSound()
		{
			StopPlay();
			PlaySound(mainFolder + "attack.wav");
		}

		public void CheckmateSound()
		{
			StopPlay();
			PlaySound(mainFolder + "checkmate.wav");
		}

		public void EndGameSound()
		{
			StopPlay();
			PlaySound(mainFolder + "endgame.wav");
		}
	}
}
