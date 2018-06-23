namespace AdapterDesignPatternExample.Plugs.HdmiPlug
{
    public interface IHdmiPlug
    {
        int Send();
        int Get();
        void Connect();
    }
}