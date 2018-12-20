namespace wathes
{
    /// <summary>
    /// Time parser.
    /// </summary>
    public class TimeParser
    {
        /// <summary>
        /// Gets the hour and minute.
        /// </summary>
        /// <returns>The hour and minute.</returns>
        /// <param name="time">Time.</param>
        public string[] GetHourAndMinute(ref string time)
        {
            return time.Split(new char[] { ':' });
        }
    }
}