namespace Task
{
    using System;

    public class Battery
    {
        private string modelBattery;
        private int hoursIdle;
        private int hoursTalk;
        private BatteriesEnum batteryType;

        public Battery(string batt, int hIdle, int hTalk, BatteriesEnum type)
        {
            this.modelBattery = batt;
            this.hoursIdle = hIdle;
            this.hoursTalk = hTalk;
            this.BatteryType = type;
        }

        // P5
        public string ModelBattery
        {
            get
            {
                return this.modelBattery;
            }

            set
            {
                if (value.Length <= 0 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Invalid model battery");
                }

                this.modelBattery = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value <= 0 || value > 200)
                {
                    throw new ArgumentOutOfRangeException("Invalid hours idle value");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value <= 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Invalid talk hours value");
                }

                this.hoursTalk = value;
            }
        }

        public BatteriesEnum BatteryType { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Battery Model: {0}\n" + 
                "Hours Idle: {1}\n" + 
                "Hours Talk: {2}\n" + 
                "Battery Type: {3}", 
                this.ModelBattery.ToString(), 
                this.HoursIdle.ToString(), 
                this.HoursTalk.ToString(), 
                this.BatteryType.ToString());
        }
    }
}