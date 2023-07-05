namespace GradeBook
{
    public class Statistics
    {
        private int count;
        public double Sum;
        public double total
        {
            get
            {
                return Sum;
            }
        }
        public double Average
        {
            get
            {
                return Sum / count;
            }

            set {

            }
        }
        public double maximum;
        public double minimum;

        public Statistics()
        {
            Average = 0.0;
            Sum = 0.0;
            maximum = double.MaxValue;
            minimum = double.MinValue;

        }

        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';

                    case var d when d >= 80.0:
                        return 'B';

                    case var d when d >= 70.0:
                        return 'C';

                    case var d when d >= 60.0:
                        return 'D';

                    case var d when d >= 50.0:
                        return 'E';

                    default:
                        return 'F';
                }
            }
        }
        public void Add(double number)
        {
            Sum =+ number;
            count =+ 1;
            maximum = Math.Max(number, maximum);
            minimum = Math.Min(number, minimum);
        }

    }
}