namespace TP_Parking
{
    public class Garage
    {
        public int Number { get; set; }
        public bool State { get; set; }
        public Vehicle Vehicle { get; set; }

        public Garage() { }

        public Garage(int number, bool state)
        {
            this.Number = number;
            this.State = state;
        }

        public Garage(int number, bool state, Vehicle vehicle)
        {
            this.Number = number;
            this.State = state;
            this.Vehicle = vehicle;
        }
    }
}
