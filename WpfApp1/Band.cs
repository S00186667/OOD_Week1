using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Band
    {


        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }




        public override string ToString()
        {
            return string.Format("{0}", BandName); 
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
