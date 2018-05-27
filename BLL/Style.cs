using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public struct Style
    {
        public int StyleId;
        public string OutfitType;
        public string SkinColour;
        public string Eyecolour;
        public string HairColour;

        public Style(int styleIdParam,  string eyecolourParam, string hairColourParam, string outfitTypeParam, string SkinColourParam)
        {
            this.StyleId = styleIdParam;
            this.OutfitType = outfitTypeParam;
            this.SkinColour = SkinColourParam;
            this.Eyecolour = eyecolourParam;
            this.HairColour = hairColourParam;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
