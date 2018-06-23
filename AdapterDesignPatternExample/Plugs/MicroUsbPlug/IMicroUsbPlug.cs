namespace AdapterDesignPatternExample.Plugs.MicroUsbPlug
{
    public interface IMicroUsbPlug
    {
        bool Send();
        bool Receive();
    }
}