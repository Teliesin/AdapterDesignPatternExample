using AdapterDesignPatternExample.Plugs.JackPlug;
using AdapterDesignPatternExample.Plugs.UsbPlug;

namespace AdapterDesignPatternExample.Adapters
{
    public class JackToUsbAdapter : IUsbPlug
    {
        public IJackPlug JackPlug { get; set; }

        public JackToUsbAdapter(IJackPlug jackPlug)
        {
            JackPlug = jackPlug;
        }

        public bool Receive()
        {
            JackPlug.LeftChannelReceive();
            JackPlug.RightChannelReceive();
            return true;
        }

        public bool Send()
        {
            JackPlug.LeftChannelSend();
            JackPlug.RightChannelSend();
            return true;
        }
    }
}