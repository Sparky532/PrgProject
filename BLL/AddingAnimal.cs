using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class AddingAnimal
    {
        private List<AnimalsSelected> animalstoAdd;
        private int farmerId;

        public AddingAnimal(List<AnimalsSelected> animalstoAddParam, int farmerIdParam)
        {
            this.AnimalstoAdd = animalstoAddParam;
            this.FarmerId = farmerIdParam;
        }
        public int FarmerId
        {
            get { return farmerId; }
            set { farmerId = value; }
        }

        public List<AnimalsSelected> AnimalstoAdd
        {
            get { return animalstoAdd; }
            set { animalstoAdd = value; }
        }

    }
}
