using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CYPVP
{
    public class MainMenu
    {
        private SoundPlayer MainMenuSoundPlayer { get; set; }
        public bool IsMuted { get; set; }
        public MainMenu() { 
            MainMenuSoundPlayer=new SoundPlayer(Properties.Resources.music_zapsplat_astro_race);
            VideoPlayerController.AudioManager.StepMasterVolume(10);
            MainMenuSoundPlayer.PlayLooping();
            VideoPlayerController.AudioManager.SetMasterVolumeMute(false);
            IsMuted = false;
        }
        public void Mute()
        {
            VideoPlayerController.AudioManager.SetMasterVolumeMute(true);
        }
        public void UnMute() {
            VideoPlayerController.AudioManager.SetMasterVolumeMute(false);
        }
        public void Play()
        {
            MainMenuSoundPlayer.PlayLooping();
        }
        public void Stop()
        {
            MainMenuSoundPlayer.Stop(); 
        }

    }
}
