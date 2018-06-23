namespace AdapterDesignPatternExample.Plugs.HdmiPlug
{
    public class HdmiPlug : IHdmiPlug
    {
        public int Send()
        {
            return 1;
        }

        public int Get()
        {
            return 1;
        }

        public void Connect()
        {
        }
    }
}