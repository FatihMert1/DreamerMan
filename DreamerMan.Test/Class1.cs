using System;
using Xunit;

namespace DreamerMan.Test
{
    public class MathTest
    {

        [Fact]
        public void Test_Example(){
            int expected = 10;

            Assert.Equal(expected, 4+8 );
        }
    }
}
