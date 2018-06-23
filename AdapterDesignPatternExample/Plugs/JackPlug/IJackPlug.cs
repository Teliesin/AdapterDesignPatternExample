namespace AdapterDesignPatternExample.Plugs.JackPlug
{
    public interface IJackPlug
    {
        void LeftChannelSend();
        void RightChannelSend();
        void LeftChannelReceive();
        void RightChannelReceive();
    }
}