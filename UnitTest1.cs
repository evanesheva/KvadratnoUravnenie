using Kvadratno_Uravnenie.Controller;
using Kvadratno_Uravnenie.Model;
using Kvadratno_Uravnenie.View;

namespace KvadratnoUravnenie_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTwoSolutions()
        {
            Display display = new Display();
            ZadachaController controller = new ZadachaController(display);

            display.data.A = -2;
            display.data.B = 1;
            display.data.C = 3;

            controller.Calculate();

            Assert.NotNull(display.data.X1);
            Assert.NotNull(display.data.X2);
        }
    }
}