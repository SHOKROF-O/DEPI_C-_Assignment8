using System;

namespace Assignment_04
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration()
        {
        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        // constructor that takes the duration as total seconds
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            else
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
        }

        public override bool Equals(object obj)
        {
            if (obj is not Duration other)
                return false;

            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }
    }
}
