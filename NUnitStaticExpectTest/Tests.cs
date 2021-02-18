using NUnit.Framework;
using static NUnit.StaticExpect.Expectations;

namespace NUnitStaticExpectTest
{
    class Tests
    {
        [Test]
        public void Foo()
        {
            System.IO.File.Create("foo");
            Expect(1, Is.EqualTo(1));
        }
        [Test]
        public void Baz()
        {
            System.IO.File.Create("baz");
        }
    }
}
