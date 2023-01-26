using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using test228;

namespace TestProject1
{
    public class DataFloodingTest
    {
        [Theory]
        [InlineData (1,1,1,1)]
        public void DataFlooding_FiguresTest(double a, double b, double c, int d)
        {
            Triangle triangle = new Triangle(a, b, c, d);
            Assert.InRange(triangle.GetArea(), 0, 100);
            Assert.InRange(triangle.GetPerimeter(), 1, 100);
            Assert.NotEqual(triangle.GetPerimeter(), -1);
            Assert.NotEqual(triangle.GetArea(), -1);
        }
        [Theory]
        [InlineData(0,0,-1,0)]
        public void Validator_Impossible(double a, double b, double c, int d)
        {
            List<string> valids = new List<string>() { Convert.ToString(a), Convert.ToString(b), Convert.ToString(c), Convert.ToString(d) };
            Validator validator = new Validator();
            Assert.False(validator.valueError(valids));
        }
    }
}
