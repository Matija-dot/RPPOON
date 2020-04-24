using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_3
{
    class Dataset : Prototype
    {
        private List<List<string>> data;

        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public Dataset(Dataset original)
        {
            // Duboko kopiranje je potrebno ako želimo pomoću klonova trajno spremati različite kopije podataka učitanih pomoću metode "LoadDataFromCSV".
            this.data = new List<List<string>>();
            foreach(List<string> row in original.data)
            {
                List<string> rowClone = new List<string>();
                foreach(string item in row)
                {
                    string itemClone = new string(item);
                    rowClone.Add(itemClone);
                }
                this.data.Add(rowClone);
            }
        }

        public void LoadDataFromCSV(string filePath)
        {
            using(System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach(string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        public Prototype Clone() 
        {
            return new Dataset(this);
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (List<string> row in this.data)
            {
                foreach (string item in row)
                {
                    stringBuilder.Append(item);
                }
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
}
