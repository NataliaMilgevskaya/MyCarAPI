namespace MyCarAPI
{
    public static class Garage
    {
        public static List<Car> Cars = new List<Car>
    {
        new Car { Id = 1, Manufacturer = "Audi", Model = "Q8", Engine = "petrol", Color = "Dark grey", Year = 2022, PhotoLink = "https://f7432d8eadcf865aa9d9-9c672a3a4ecaaacdf2fee3b3e6fd2716.ssl.cf3.rackcdn.com/C2299/U9655/IMG_76995-large.jpg" , ManufactureDate =  new DateTime(2022, 04, 11)},
        new Car { Id = 2, Manufacturer = "Audi", Model = "Q5", Engine = "petrol",  Color = "Red", Year = 2023, PhotoLink = "https://scontent-iev1-1.xx.fbcdn.net/v/t31.18172-8/29664810_820162874851402_3711253995492330315_o.jpg?_nc_cat=103&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=E5Xy5Cgl3I0AX-RCBfJ&_nc_ht=scontent-iev1-1.xx&oh=00_AfBbqVs_HhUrvDu7Au_1qVoA6a8RHz-k3zyBWOQQdwGTyg&oe=645B8CE4", ManufactureDate =  new DateTime(2023, 01, 11)},
        new Car { Id = 3, Manufacturer = "Audi", Model = "Q3", Engine = "diesel",  Color = "Blue", Year = 2021, PhotoLink = "https://car-images.bauersecure.com/wp-images/12623/1056x594/audi_q3_2018_035.jpg", ManufactureDate =  new DateTime(2021, 04, 11)},
        new Car { Id = 4, Manufacturer = "Audi", Model = "Q8", Engine = "diesel", Color = "White", Year = 2022, PhotoLink = "https://m.atcdn.co.uk/a/media/w800h600/851a2976a6ca45a191dd7a10dce61451.jpg", ManufactureDate =  new DateTime(2022, 04, 11)}
    };
    }
}
