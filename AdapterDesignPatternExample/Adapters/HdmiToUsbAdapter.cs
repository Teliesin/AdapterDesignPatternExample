using AdapterDesignPatternExample.Plugs.HdmiPlug;
using AdapterDesignPatternExample.Plugs.UsbPlug;

namespace AdapterDesignPatternExample.Adapters
{
    public class HdmiToUsbAdapter : IUsbPlug
    {
        private IHdmiPlug HdmiPlug { get; set; }

        public HdmiToUsbAdapter(IHdmiPlug hdmiPlug)
        {
            HdmiPlug = hdmiPlug;
        }

        public bool Receive()
        {
            HdmiPlug.Connect();
            var result = HdmiPlug.Get();

            return result == 1;
        }

        public bool Send()
        {
            HdmiPlug.Connect();
            var result = HdmiPlug.Get();

            return result == 1;
        }
    }
}