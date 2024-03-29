﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DANE_Reports.model
{
    internal class DANEData
    {

        private List<Data> _data;
        private List<StateData> _states;

        public DANEData()
        {
            this._data = new List<Data>();
            this._states = new List<StateData>();
        }

        public List<Data> Data
        {
            get => _data;
            set => _data = value;
        }

        public List <StateData> States
        {
            get => _states;
            set => _states = value;
        }
        public void ImportFileData(string FilePath, char separator, bool header)
        {
            bool endData = false;
            StreamReader sr = new StreamReader(FilePath);
            if (header)
                sr.ReadLine();
            string line;
            while ((line = sr.ReadLine()) != null && !endData)
            {
                try {
                    string[] parts = line.Split(separator);
                    int checking = Convert.ToInt32(parts[0]);
                    if (parts.Length == 5)
                    {
                        Console.WriteLine("Se agregara una ciudad");
                        AddCity(parts[0], parts[1], parts[2], parts[3], parts[4]);
                        Console.WriteLine("nombre de la ciudad {0}", parts[3]);
                    }
                }
                catch (FormatException) { Console.WriteLine("Format exception"); endData = true; }
            }//End while
        }//End importFileData

        private void AddCity(string sCode, string cCode, string sName, string cName, string cType)
        {
            AddStateName(sName);
            int i = 0;
            while (i < _data.Count && _data[i].CityId.CompareTo(cCode) < 0)
                ++i;
            _data.Insert(i, new Data(sCode, cCode, sName, cName, cType));
        }

        private void AddStateName(string sName)
        {
            for (int i = 0; i < _states.Count; i++)
            {
                StateData current = _states[i];
                if (current.Name == sName)
                {
                    current.Count++;
                    return;
                }
            }
            int j = 0;
            while (j < _states.Count && _states[j].Name.CompareTo(sName) < 0)
                ++j;
            _states.Insert(j, new StateData(sName, 1));
        }

        public Data FindCityById(string id)
        {
            int start = 0;
            int end = _data.Count - 1;
            while(start <= end)
            {
                int mid = (start + end) / 2;
                Data current = _data[mid];
                if (current.CityId.CompareTo(id) == 0)
                    return _data[mid];
                else if (current.CityId.CompareTo(id) < 0)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return null;
        }

    }
}
