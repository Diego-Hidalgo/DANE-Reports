namespace DANE_Reports.model
{
    internal class StateData
    {

        private string _name;
        private int _count;

        internal StateData()
        {
            _name = default;
            _count = default;
        }

        internal StateData(string Name, int Count)
        {
            this._name = Name;
            this._count = Count;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Count
        {
            get => _count;
            set => _count = value;
        }

    }
}
