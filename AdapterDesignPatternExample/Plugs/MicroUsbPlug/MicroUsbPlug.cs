namespace AdapterDesignPatternExample.Plugs.MicroUsbPlug
{
    public class MicroUsbPlug : IMicroUsbPlug
    {
        public bool Send()
        {
            return true;
        }

        public bool Receive()
        {
            return true;
        }
    }
}