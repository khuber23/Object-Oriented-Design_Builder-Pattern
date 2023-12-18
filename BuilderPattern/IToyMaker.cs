using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IToyMaker
    {
        Toy GetToy();
        void MakeHat();
        void NameToy();
        void PaintHead();
        void PaintLegs();
        void PaintTorso();
        void StitchClothes();
    }
}
