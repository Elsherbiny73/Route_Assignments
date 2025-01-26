using System.Collections.Immutable;
using System;
using System.Runtime.Serialization;

namespace Route_Assignments
{
    internal class OOP_Session6
    {
        #region first project
        public class Duration
        {
            public int Minutes { get; set; }
            public int Seconds { get; set; }
            public int Hours { get; set; }

            public Duration(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
                AdjustTime();
            }

            public Duration(int numberInSeconds)
            {
                Hours = numberInSeconds / 3600;
                Minutes = (numberInSeconds % 3600) / 60;
                Seconds = numberInSeconds % 60;
                AdjustTime();
            }

            public Duration()
            {
            }
            private void AdjustTime()
            {
                if (Seconds < 0)
                {
                    Minutes += (Seconds / 60) - 1;
                    Seconds = (Seconds % 60 + 60) % 60;
                }
                else if (Seconds >= 60)
                {
                    Minutes += Seconds / 60;
                    Seconds %= 60;
                }

                if (Minutes < 0)
                {
                    Hours += (Minutes / 60) - 1;
                    Minutes = (Minutes % 60 + 60) % 60;
                }
                else if (Minutes >= 60)
                {
                    Hours += Minutes / 60;
                    Minutes %= 60;
                }

            }
            public override string ToString()
            {
                if (Hours > 0)
                    return "Hours: " + Hours + ", Minutes: " + Minutes + ", Seconds: " + Seconds;
                else if (Minutes > 0)
                    return "Minutes: " + Minutes + ", Seconds: " + Seconds;
                else
                    return "Seconds: " + Seconds;
            }

            public override bool Equals(object obj)
            {
                if (obj is Duration)
                {
                    var other = (Duration)obj;
                    return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Hours, Minutes, Seconds);
            }

            public static Duration operator +(Duration d1, Duration d2)
            {
                return new Duration(
                    d1.Hours + d2.Hours,
                    d1.Minutes + d2.Minutes,
                    d1.Seconds + d2.Seconds
                );
            }

            public static Duration operator +(Duration d1, int seconds)
            {
                return new Duration(d1.Hours, d1.Minutes, d1.Seconds + seconds);
            }

            public static Duration operator +(int seconds, Duration d1)
            {
                return new Duration(d1.Hours, d1.Minutes, d1.Seconds + seconds);
            }

            public static Duration operator ++(Duration d)
            {
                return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
            }

            public static Duration operator --(Duration d)
            {
                return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
            }
            public static Duration operator -(Duration d1, Duration d2)
            {
                return new Duration(
                    d1.Hours - d2.Hours,
                    d1.Minutes - d2.Minutes,
                    d1.Seconds - d2.Seconds
                );
            }
            public static bool operator >(Duration d1, Duration d2)
            {
                if (d1.Hours != d2.Hours) return d1.Hours > d2.Hours;
                if (d1.Minutes != d2.Minutes) return d1.Minutes > d2.Minutes;
                return d1.Seconds > d2.Seconds;
            }

            public static bool operator <(Duration d1, Duration d2)
            {
                if (d1.Hours != d2.Hours) return d1.Hours < d2.Hours;
                if (d1.Minutes != d2.Minutes) return d1.Minutes < d2.Minutes;
                return d1.Seconds < d2.Seconds;
            }

            public static bool operator >=(Duration d1, Duration d2)
            {
                if (d1.Hours != d2.Hours) return d1.Hours > d2.Hours;
                if (d1.Minutes != d2.Minutes) return d1.Minutes > d2.Minutes;
                return d1.Seconds >= d2.Seconds;
            }

            public static bool operator <=(Duration d1, Duration d2)
            {
                if (d1.Hours != d2.Hours) return d1.Hours < d2.Hours;
                if (d1.Minutes != d2.Minutes) return d1.Minutes < d2.Minutes;
                return d1.Seconds <= d2.Seconds;
            }

            public static implicit operator bool(Duration d)
            {
                return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;
            }

            public static explicit operator DateTime(Duration d)
            {
                if (d.Hours < 0 || d.Hours > 23)
                    throw new ArgumentOutOfRangeException(nameof(d.Hours), "Hours must be between 0 and 23.");
                if (d.Minutes < 0 || d.Minutes > 59)
                    throw new ArgumentOutOfRangeException(nameof(d.Minutes), "Minutes must be between 0 and 59.");
                if (d.Seconds < 0 || d.Seconds > 59)
                    throw new ArgumentOutOfRangeException(nameof(d.Seconds), "Seconds must be between 0 and 59.");

                return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
            }

        }
        #endregion
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(7800);
            Duration D3 = new Duration(666);

            Console.WriteLine($"D1: {D1.Hours} hours, {D1.Minutes} minutes, {D1.Seconds} seconds");
            Console.WriteLine($"D2: {D2.Hours} hours, {D2.Minutes} minutes, {D2.Seconds} seconds");
            Console.WriteLine($"D3: {D3.Hours} hours, {D3.Minutes} minutes, {D3.Seconds} seconds");

            D3 = D1 + D2;
            Console.WriteLine($"D3 after D1 + D2: {D3.Hours} hours, {D3.Minutes} minutes, {D3.Seconds} seconds");

            D3 = D1 + 7800;
            Console.WriteLine($"D3 after D1 + 7800: {D3.Hours} hours, {D3.Minutes} minutes, {D3.Seconds} seconds");

            D3 = 666 + D3;
            Console.WriteLine($"D3 after 666 + D3: {D3.Hours} hours, {D3.Minutes} minutes, {D3.Seconds} seconds");

            D3 = ++D1;
            Console.WriteLine($"D3 after ++D1: {D3.Hours} hours, {D3.Minutes} minutes, {D3.Seconds} seconds");

            D3 = --D2;
            Console.WriteLine($"D3 after --D2: {D3.Hours} hours, {D3.Minutes} minutes, {D3.Seconds} seconds");

            D1 = D1 - D2;
            Console.WriteLine($"D1 after D1 - D2: {D1.Hours} hours, {D1.Minutes} minutes, {D1.Seconds} seconds");

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");
            else
                Console.WriteLine("D1 is not greater than D2");

            if (D1)
                Console.WriteLine("D1 is non-zero");
            else
                Console.WriteLine("D1 is zero");

            try
            {
                DateTime dateTime = (DateTime)new Duration(-1, 75, -15);
                Console.WriteLine($"DateTime: {dateTime:HH:mm:ss}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
