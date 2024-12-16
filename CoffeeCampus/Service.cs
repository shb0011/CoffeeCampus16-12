namespace CoffeeCampus
{
    public class Service
    {
        public int ServiceID { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public int MachineID { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }

    }
}
