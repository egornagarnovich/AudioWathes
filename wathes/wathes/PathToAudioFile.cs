using System.Web.Script.Serialization;
using System.IO;
using System.Collections.Generic;

namespace wathes
{
    /// <summary>
    /// Path to audio file.
    /// </summary>
    public class PathToAudioFile
    {
        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <returns>The path to audio file.</returns>
        /// <param name="time">Time.</param>
        /// <param name="key">Time type.</param>
        /// <param name="pathToSpecificator">Path to specificator.</param>
        public string GetPath(ref string time, Time timeType, ref string pathToSpecificator)
        {
            var audioSpecificator = GetAudioSpecificator(ref pathToSpecificator);
            foreach (var i in audioSpecificator[TimeToString(timeType)].Keys)
            {
                if (time == i)
                    return audioSpecificator[TimeToString(timeType)][i];
            }
            throw new InvalidDataException();
        }

        public string TimeToString(Time time)
        {
            switch(time)
            {
                case Time.hour:
                    return "hours";
                case Time.minute:
                    return "minutes";
                default:
                    throw new InvalidDataException();
            }
        }

        private Dictionary<string, Dictionary<string,string>> GetAudioSpecificator(ref string pathToSpecificator)
        {
            string dataJson = File.ReadAllText(pathToSpecificator);
            var serializer = new JavaScriptSerializer();
            var jsonSpecificator = serializer.Deserialize<Dictionary<string, Dictionary<string,string>>>(dataJson);
            return jsonSpecificator;
        }
    }
}