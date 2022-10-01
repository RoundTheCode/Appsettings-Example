namespace RoundTheCode.AppSettings.Entities
{
    public class Authentication
    {
#nullable disable
        public int Id { get; private set; }

        public string ClientId { get; private set; }


        public string ClientSecret { get; private set; }

        public int Attempts { get; private set; }

    }
}
