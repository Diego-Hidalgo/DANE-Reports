namespace DANE_Reports.model
{
    internal class Data
    {

        private string stateName;
        private string stateId;
        private string cityName;
        private string cityId;
        private string cityType;

        internal Data()
        {
            stateName = default;
            stateId = default;
            cityName = default;
            cityId = default;
            cityType = default;
        }

        internal Data(string StateName, string StateId, string CityName, string CityId, string CityType)
        {
            this.stateName = StateName;
            this.stateId = StateId;
            this.cityName = CityName;
            this.cityId = CityId;
            this.cityType = CityType;
        }

        public string StateName
        {
            get => stateName;
            set => stateName = value;
        }

        public string StateId
        {
            get => stateId;
            set => stateId = value;
        }

        public string CityName
        {
            get => cityName;
            set => cityName = value;
        }

        public string CityId
        {
            get => cityId;
            set => cityId = value;
        }

        public string CityType
        {
            get => cityType;
            set => cityType = value;
        }

    }
}
