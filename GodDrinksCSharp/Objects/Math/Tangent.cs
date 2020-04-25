using System;

namespace GodDrinksCSharp.Objects
{
    public class Tangent
    {
        public double ValueTangent;

        public Tangent(double x) => this.ValueTangent = Math.Tan(x);
    }
}
