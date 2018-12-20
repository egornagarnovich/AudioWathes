using System.Media;
namespace wathes
{
    /// <summary>
    /// Simple sound.
    /// </summary>
    public class SimpleSound
    {
        /// <summary>
        /// Plaies the simple sound.
        /// </summary>
        /// <param name="pathToAudioFile">Path to audio file.</param>
        public void PlaySimpleSound(string pathToAudioFile)
        {
            SoundPlayer simpleSound = new SoundPlayer(pathToAudioFile);  
            simpleSound.PlaySync();  
        }
    }
}