namespace gn_core_entities.Location
{
    public class Prefecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long Population { get; private set; }
        public int AreaKm2 { get; private set; }
        public string Longitude { get; private set; }
        public string Latitude { get; private set; }
        public int RegionId { get; set; }

        public Prefecture()
        {
            
        }

        public Prefecture(int id, string name, string code, long population, int areaKm2, string longitude, string latitude, int regionId)
        {

            Id = id;
            Name = name;
            Code = code;
            Population = population;
            AreaKm2 = areaKm2;
            Longitude = longitude;
            Latitude = latitude;
            RegionId = regionId;
        }
    }
}
