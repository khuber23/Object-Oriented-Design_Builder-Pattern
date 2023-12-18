using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SpacemanMaker : IToyMaker
    {
        private Toy toy;

        public SpacemanMaker()
        {
            this.toy = new Toy();
        }

        public Toy GetToy()
        {
            return this.toy;
        }

        public void MakeHat()
        {
            toy.ChooseHat("Space Helmet");
        }

        public void NameToy()
        {
            toy.GiveName("Buzz Light");
        }

        public void PaintHead()
        {
            toy.ChooseHead("Spaceman");
        }

        public void PaintLegs()
        {
            toy.ChooseLegs("Moon Boots");
        }

        public void PaintTorso()
        {
            toy.ChooseTorso("Jet Pack");
        }

        public void StitchClothes()
        {
            toy.ChooseClothes("Space Suit");
        }
    }
}
