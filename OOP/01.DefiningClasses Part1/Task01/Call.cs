namespace Task
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        // P8
        private CultureInfo cultureInfoDateCulture = new CultureInfo("En-us");

        // date, time, dialled phone number and duration
        private DateTime dateOfTheCall;
        private string dialedNumber;
        private double duration;

        public Call(DateTime dateOfTheCall, string dialedNumber, double duration)
        {
            this.dateOfTheCall = dateOfTheCall;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        public DateTime DateOfTheCall
        {
            get
            {
                return this.dateOfTheCall;
            }

            set
            {
                try
                {
                    value = DateTime.Parse(value.ToString());
                }
                catch
                {
                    throw new ArgumentException("Not valid date/time entered!");
                }

                this.dateOfTheCall = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }

            set
            {
                if (value.Length != 12)
                {
                    throw new ArgumentOutOfRangeException("Invalid number");
                }

                this.dialedNumber = value;
            }
        }

        public double Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                if (value > 9999999 || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid duration");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Date: {0}\n" +
                "Number: {1}\n" +
                "Duration: {2}\n",
                this.DateOfTheCall, 
                this.DialedNumber,
                this.Duration);
        }
    }
}