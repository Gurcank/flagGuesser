using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flagGuesser
{
    internal class FlagData
    {
        public string countryName {  get; set; }
        public string imagePath { get; set; }

        public FlagData(string countryName, string imagePath)
        {
            this.countryName = countryName;
            this.imagePath = imagePath;
        }
    }
}
