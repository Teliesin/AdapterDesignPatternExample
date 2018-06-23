namespace AdapterDesignPatternExample.Plugs.UsbPlug
{
    public class USBPlug : IUsbPlug
    {
        public bool Receive()
        {
            return true;
        }

        public bool Send()
        {
            return true;
        }
    }
}