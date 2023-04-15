namespace MyCarAPI
{
    public interface IManagementCars
    {
        string GetCarName();
        string GetCarEngine();
        int GetCarAge();
    }

    public class Car : IManagementCars
    {
        public int Id { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }
        public string? PhotoLink { get; set; }
        public string? Engine { get; set; }
        public DateTime ManufactureDate { get; set; }

        public string GetCarName()
        {
            return $" {Manufacturer} {Model} \n";
        }
        public string GetCarEngine()
        {
            return $"{Engine} \n";
        }

        public int GetCarAge()
        {
            return (int)(DateTime.Now.Year - ManufactureDate.Year);

        }
    }
}
