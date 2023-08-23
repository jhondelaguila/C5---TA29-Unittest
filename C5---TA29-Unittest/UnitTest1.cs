namespace Geometria;

public class Tests
{
    Geometria geo;
    [SetUp]
    public void Setup()
    {
      geo = new Geometria();
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(4,geo.areacuadrado(2));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(3.1416 * Math.Pow(1, 2), geo.areaCirculo(1));
    }

    [Test]
    public void Test3()
    {
        Assert.AreNotEqual("Default", geo.figura(8));
    }
}
