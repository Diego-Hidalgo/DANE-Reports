namespace DANE_Reports.model
{
    internal class Data
    {

        private string _stateId;
        private string _cityId;
        private string _stateName;
        private string _cityName;
        private string _cityType;

        internal Data()
        {
            _stateId = default;
            _cityId = default;
            _stateName = default;
            _cityName = default;
            _cityType = default;
        }

        internal Data(string StateId, string CityId, string StateName, string CityName, string CityType)
        {
            this._stateId = StateId;
            this._cityId = CityId;
            this._stateName = StateName;
            this._cityName = CityName;
            this._cityType = CityType;
        }

        public string StateId
        {
            get => _stateId;
            set => _stateId = value;
        }

        public string CityId
        {
            get => _cityId;
            set => _cityId = value;
        }

        public string StateName
        {
            get => _stateName;
            set => _stateName = value;
        }

        public string CityName
        {
            get => _cityName;
            set => _cityName = value;
        }

        public string CityType
        {
            get => _cityType;
            set => _cityType = value;
        }

    }
}
