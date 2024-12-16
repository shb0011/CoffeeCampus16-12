namespace CoffeeCampus
{
    public class CoffeeMachine
    {
        public int machineID {  get; set; }
        public string building { get; set; }

        public DateTime hoseChangeDate { get; set; }
        public DateTime serviceDate { get; set; }

        public DateTime CleaningDate { get; set; }
        public DateTime RefillDate { get; set; }

        public List <Refill> Refills { get; set; }

        public List<Service> Services { get; set; }

        public List<HoseChange> HoseChanges { get; set; }
    }


 

}
