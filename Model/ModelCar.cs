using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoPatiro.Model
{
     class ModelCar
    {
        public int LocalTimeFactor;
        public int GlobalTimeFactor;
        public string Model;
        //constructor with 2 parameters for local time factor and model. The global time factor is set to 300 automatically
        public ModelCar(int loc,string mod)
        {
            this.LocalTimeFactor = loc;
            this.Model = mod;
            this.GlobalTimeFactor=300;
        }
        //constructor with 1 paramiter  for the model. The global factor is set to 300
        public ModelCar( string mod)
        {
            this.GlobalTimeFactor=300;
            this.Model = mod;
        }
    }
}
