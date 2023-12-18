using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Assembler
    {
        private IToyMaker toyMaker;

        public Assembler(IToyMaker toyMaker)
        {
            this.toyMaker = toyMaker;
        }

        public Toy GetToy()
        {
            return toyMaker.GetToy();
        }

        public void AssembleToy()
        {
            toyMaker.NameToy();
            toyMaker.MakeHat();
            toyMaker.PaintHead();
            toyMaker.PaintLegs();
            toyMaker.PaintTorso();
            toyMaker.StitchClothes();
        }
    }
}
