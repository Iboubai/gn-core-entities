namespace gn_core_entities.Location
{
    public class SousPrefecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long Population { get; private set; }
        public int AreaKm2 { get; private set; }
        public string Longitude { get; private set; }
        public string Latitude { get; private set; }
        public int PrefectureId { get; set; }

        public SousPrefecture()
        {
            
        }

        public SousPrefecture(int id, string name, string code, long population, int areaKm2, string longitude, string latitude, int prefectureId)
        {

            Id = id;
            Name = name;
            Code = code;
            Population = population;
            AreaKm2 = areaKm2;
            Longitude = longitude;
            Latitude = latitude;
            PrefectureId = prefectureId;
        }
    }
}
