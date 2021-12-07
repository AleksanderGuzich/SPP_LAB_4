using System;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;

[TestFixture]
class ClassExample3Test
{
    private Mock<IEnumerable<int>> _d;
    private ClassExample3 _classExample3;
    [SetUp]
    public void SetUp()
    {
        _d = new Mock<IEnumerable<int>>();
        _classExample3 = new ClassExample3(_d.Object);
    }

    [Test]
    public void Func1()
    {
        var a = default(int);
        var str = default(string);
        _classExample3.Func1(a, str);
        Assert.Fail("autogenerated");
    }

    [Test]
    public void Func2()
    {
        _classExample3.Func2();
        Assert.Fail("autogenerated");
    }
}