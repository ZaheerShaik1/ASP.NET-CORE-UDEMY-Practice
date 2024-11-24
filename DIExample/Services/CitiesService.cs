using ServiceContracts;
namespace Services
{
    public class CitiesService : ICitiesService
    {
        private List<string> _cities;

        private Guid _ServiceInstanceId;

        public Guid ServiceInstanceId
        {
            get
            {
                return _ServiceInstanceId;
            }
        }

        public CitiesService()
        {
            _ServiceInstanceId = Guid.NewGuid();
            _cities = new List<string>()
            {
                "DELHI",
                "Mumbai",
                "Hyderabad",
                "Kolkata"

            };
        }

        public List<string> GetCities()
        {
            return _cities;
        }



    }
}
