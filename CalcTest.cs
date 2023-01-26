using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using test228;

namespace TestProject1
{
    public class FigureTest_IsCalculateCorrectly
    {
        [Fact]
        public void IsCalculateCorrectly_SquareDiagonal()
        {
            Square square = new Square(3);
            double result = square.GetDiagonal();
            Assert.True(result > 4);
        }
        [Fact]
        public void IsCalculateCorrectly_RectangleDiagonal()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            double result = rectangle.GetDiagonal();
            Assert.True(result == 5);
        }
    }
}