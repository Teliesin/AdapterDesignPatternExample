namespace AdapterDesignPatternExample.Plugs.UsbPlug
{
    public interface IUsbPlug
    {
        bool Send();
        bool Receive();
    }
}