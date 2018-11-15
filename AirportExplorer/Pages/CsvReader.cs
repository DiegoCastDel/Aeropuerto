using System;
using System.IO;

namespace AirportExplorer.Pages
{
    internal class CsvReader : IDisposable
    {
        private StreamReader sr;

        public CsvReader(StreamReader sr, CsvHelper.Configuration.Configuration configuration)
        {
            this.sr = sr;
        }

        internal T GetField<T>(int v)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal bool Read()
        {
            throw new NotImplementedException();
        }
    }
}