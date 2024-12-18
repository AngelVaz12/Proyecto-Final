using System.Media;

namespace proyectof
{
    internal class MusicPlayer
    {
        private SoundPlayer player;

        public MusicPlayer(string soundLocation)
        {
            player = new SoundPlayer(soundLocation);
            player.Load();
        }

        public void PlayLooping()
        {
            player.PlayLooping();
        }

        public void Stop()
        {
            player.Stop();
        }
    }
}