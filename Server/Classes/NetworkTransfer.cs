namespace Game.Networking
{
    // Serelized object used in sending and receieving data
    [Serializable]
    public class NetworkTransfer
    {
        public string protocol { get; set; } = "bungo";
        public string args { get; set; } = string.Empty;
    }
}