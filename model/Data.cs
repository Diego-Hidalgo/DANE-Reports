namespace DANE_Reports.model
{
    internal class Data
    {

        private string _stateName;
        private string _stateId;
        private string _cityName;
        private string _cityId;
        private string _cityType;

        internal Data()
        {
            _stateName = default;
            _stateId = default;
            _cityName = default;
            _cityId = default;
            _cityType = default;
        }

        internal Data(string StateName, string StateId, string CityName, string CityId, string CityType)
        {
            this._stateName = StateName;
            this._stateId = StateId;
            this._cityName = CityName;
            this._cityId = CityId;
            this._cityType = CityType;
        }

        public string StateName
        {
            get => _stateName;
            set => _stateName = value;
        }

        public string StateId
        {
            get => _stateId;
            set => _stateId = value;
        }

        public string CityName
        {
            get => _cityName;
            set => _cityName = value;
        }

        public string CityId
        {
            get => _cityId;
            set => _cityId = value;
        }

        public string CityType
        {
            get => _cityType;
            set => _cityType = value;
        }

    }
}
