using System;

namespace wathes
{
    public enum Time
    {
        hour,
        minute,
    }
    public enum Arguments
    {
        time,
        specificator,
    }
    /// <summary>
    /// Main class.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">Time and path to json specificator.</param>
        public static void Main(string[] args)
        {
            try
            {
                TimeParser timeParser = new TimeParser();
                PathToAudioFile path = new PathToAudioFile();
                SimpleSound play = new SimpleSound();
                string[] time = timeParser.GetHourAndMinute(ref args[0]);
                string pathToAudioWitchHour = path.GetPath(ref time[(int)Time.hour], Time.hour,
                                                           ref args[(int)Arguments.specificator]);
                string pathToAudioWitchMinute = path.GetPath(ref time[(int)Time.minute], Time.minute,
                                                                      ref args[(int)Arguments.specificator]);
                
                play.PlaySimpleSound(pathToAudioWitchHour);
                System.Threading.Thread.Sleep(500);
                play.PlaySimpleSound(pathToAudioWitchMinute);
                System.Threading.Thread.Sleep(500);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}