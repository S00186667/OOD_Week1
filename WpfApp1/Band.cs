using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Band : IComparable
    {


        public string BandName { get; set; }
        public string YearFormed { get; set; }
        public string Members { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Band otherband = obj as Band;
            if (otherband != null)
            {
                return this.BandName.CompareTo(otherband.BandName);
            }
            else
            {
                throw new ArgumentException("this isnt a band"); 
            }
        }

        public override string ToString()
        {
            return string.Format($"{BandName} - {this.GetType().Name}"); 
        }


    }

    

    public class RockBand : Band
    {
        

    }
    public class IndieBand : Band
    {

    }

    public class PopBand : Band
    {

    }
}
