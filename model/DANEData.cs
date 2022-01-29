using System.Collections.Generic;

namespace DANE_Reports.model
{
    internal class DANEData
    {

        private List<Data> data;

        public DANEData()
        {
            this.data = new List<Data>();
        }

        public List<Data> Entries
        {
            get => data;
            set => data = value;
        }


    }
}
