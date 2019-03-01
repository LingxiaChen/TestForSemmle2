using System;

[Serializable()]
class TestClassA
{
    private TestClassA testClassAInA;

    public void TestMethod()
    {
    }
}

[Serializable()]
class TestClassB
{
    private TestClassA testClassAInB;

    public void TestMethod()
    {
    }
}