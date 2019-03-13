using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Messaging{
    public interface IMessageFormatter : ICloneable
    { }

    public class MessageQueue : System.ComponentModel.Component, System.Collections.IEnumerable
    {
        public MessageQueue(string message)
        {
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public System.Messaging.IMessageFormatter Formatter { get; set; }

        public System.Messaging.Message Receive()
        {
            return null;
        }
    }

    public class BinaryMessageFormatter : ICloneable, System.Messaging.IMessageFormatter
    {
        public BinaryMessageFormatter()
        {
        }

        public object GetTest()
        {
            return null;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

    public class Message : System.ComponentModel.Component
    {
        public object Body { get; set; }
    }

    public sealed class Bitmap
    {
        public void Save(string filename)
        { }
    }
}

class TestClassC
{
    public static void Main()
    {
        MessageQueue myQueue = new MessageQueue(".\\myQueue");

        // Set the formatter to indicate body contains an Order.
        myQueue.Formatter = new BinaryMessageFormatter();
        var a = new BinaryMessageFormatter().GetTest();

        // Receive and format the message. 
        System.Messaging.Message myMessage = myQueue.Receive();
        Bitmap myImage = (Bitmap)myMessage.Body;

        // This will be saved in the \bin\debug or \bin\retail folder.
        myImage.Save("ReceivedImage.bmp");

        byte[] buffer = new byte[] { 1, 2, 3 };
        MemoryStream memStream = new MemoryStream(buffer);
        BinaryFormatter bf = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.All));
        DataTable dt = (DataTable)bf.Deserialize(memStream);
    }
}
