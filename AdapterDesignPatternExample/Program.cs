using AdapterDesignPatternExample.Adapters;
using AdapterDesignPatternExample.Plugs.HdmiPlug;
using AdapterDesignPatternExample.Plugs.JackPlug;
using AdapterDesignPatternExample.Plugs.MicroUsbPlug;
using AdapterDesignPatternExample.Plugs.UsbPlug;

namespace AdapterDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;

            IUsbPlug usbPlug = new USBPlug();
            result = usbPlug.Receive();
            result = usbPlug.Send();

            IHdmiPlug hdmiPlug = new HdmiPlug();
            IUsbPlug hdmiToUsbAdapter = new HdmiToUsbAdapter(hdmiPlug);
            result = hdmiToUsbAdapter.Receive();
            result = hdmiToUsbAdapter.Send();

            IJackPlug jackPlug = new JackPlug();
            IUsbPlug jackToUsbPlug = new JackToUsbAdapter(jackPlug);
            result = jackToUsbPlug.Receive();
            result = jackToUsbPlug.Send();

            IMicroUsbPlug microUsbPlug = new MicroUsbPlug();
            IUsbPlug microUsbTo = new MicroUsbToUsbAdapter(microUsbPlug);
            result = microUsbPlug.Receive();
            result = microUsbPlug.Send();
        }
    }
}