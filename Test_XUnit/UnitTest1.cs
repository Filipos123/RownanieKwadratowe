using kwadratowe;
using System;
using Xunit;

namespace Test_XUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test_wspolczynnika_a()
        {
            Program p = new Program();
            var x=p.rownanie(1, 1, 1);
            Assert.True(x.Count==0);
        }

        [Fact]
        public void Test_brak_rozwiazan()
        {
            Program p = new Program();
            var x = p.rownanie(0, 1, 1);
            Assert.True(x.Count == 0);
        }

        [Fact]
        public void Test_1_rozwiazanie()
        {
            Program p = new Program();
            var x = p.rownanie(1, 2, 1);
            Assert.True(x.Count == 1);
            Assert.True(x[0] == -1);
        }

        [Fact]
        public void Test_2_rozwiazania()
        {
            Program p = new Program();
            var x = p.rownanie(1, 5, 6);
            Assert.True(x.Count == 2);
            Assert.True((x[0]==-3 && x[1] == -2) || (x[0] == -2 && x[1] == -3));

        }
    }
}
