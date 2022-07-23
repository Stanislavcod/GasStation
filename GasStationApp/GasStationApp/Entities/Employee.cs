namespace GasStationApp.Entities
{
    internal class Employee : Person
    {
        public decimal Salary { get; set; }
        public string? Post { get; set; }
        public string? SurName { get; set; }
    }
}
