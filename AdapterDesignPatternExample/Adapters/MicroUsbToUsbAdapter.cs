using AdapterDesignPatternExample.Plugs.MicroUsbPlug;
using AdapterDesignPatternExample.Plugs.UsbPlug;

namespace AdapterDesignPatternExample.Adapters
{
    public class MicroUsbToUsbAdapter : IUsbPlug
    {
        private IMicroUsbPlug MicroUsbPlug { get; set; }

        public MicroUsbToUsbAdapter(IMicroUsbPlug microUsbPlug)
        {
            MicroUsbPlug = microUsbPlug;
        }

        public bool Receive()
        {
            bool result = MicroUsbPlug.Receive();
            return result;
        }

        public bool Send()
        {
            bool result = MicroUsbPlug.Receive();
            return result;
        }
    }
}