using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable()]
class TestClassA
{
    private readonly TestClassA TestClassAInA;

    public void TestMethod()
    {
    }
}

[Serializable()]
class TestClassB
{
    private readonly TestClassA TestClassAInB;

    public void TestMethod()
    {
    }
}

class TestClassC
{
    public static void Main()
    {
        byte[] buffer = new byte[] { 1, 2, 3 };
        MemoryStream memStream = new MemoryStream(buffer);
        BinaryFormatter bf = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.All));
        DataTable dt = (DataTable)bf.Deserialize(memStream);
    }
}
