namespace RedBjorn.Utils
{
    public interface ISerializer
    {
        void Serialize(object data, string name);
        void Deserialize(byte[] data, string name);
    }
}
