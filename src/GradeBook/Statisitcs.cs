namespace GradeBook
{
    public class Statistics 
    {
        int count = 0;
        double sum = 0;
        public double total{
            get {
                return sum;
            }
        }
        public double average {
            get {
                return sum / count;
            }
        }
        public double maximum;
        public double minimum;
        public char Letter {
            get {
                return this.Letter;
            }

            set {
                switch (value)
            {
                case var d when d >= 90.0:
                    Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    Letter = 'D';
                    break;
                case var d when d >= 50.0:
                    Letter = 'E';
                    break;
                default:
                    Letter = 'F';
                    break;

            }
            }
        }

        public void Add(double number){
            sum =+ number;
            count =+ 1;
            maximum = Math.Max(number, maximum);
            minimum = Math.Min(number, minimum);
        }

    }
}