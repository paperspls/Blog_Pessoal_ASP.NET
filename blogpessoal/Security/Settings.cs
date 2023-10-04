namespace blogpessoal.Security
{
    public class Settings
    {
        private static string secret = "e9bf6a9e654bdff70ad9c849693594fcd3f865a5d1b2eb21acd5cb96655478ec";
        public static string Secret { get => secret; set => secret = value; }
    }
}
