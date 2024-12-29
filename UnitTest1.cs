using NUnit.Framework;

namespace TempRiderZWSP;

public class Tests
{
    [Test]
    [TestCase("\u200B")]
    public void Test1(string a)
    {
        Assert.That(a, Is.EqualTo(a));
    }
}