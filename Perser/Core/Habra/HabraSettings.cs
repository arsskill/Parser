namespace Perser.Core.Habra
{
    class HabraSettings : IParserSettings
    {
        public HabraSettings(int start, int end)
        {
            Startpoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://habr.com/ru/all";
        public string Prefix { get; set; } = "page1";
        public int Startpoint { get; set; }
        public int EndPoint { get; set; }
    }
}
