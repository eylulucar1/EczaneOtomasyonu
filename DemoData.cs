using System.Collections.Generic;

namespace EczaneOtomasyonu
{
    // Basit in-memory demo veri deposu. Gerçek uygulama için kalıcı değildir.
    public static class DemoData
    {
        private static readonly List<GuvenceItem> guvenceler = new List<GuvenceItem>();

        public static void AddGuvence(string ad, bool durum)
        {
            guvenceler.Add(new GuvenceItem { Id = guvenceler.Count + 1, Ad = ad, Durum = durum });
        }

        public static IEnumerable<GuvenceItem> GetGuvenceler()
        {
            return guvenceler.ToArray();
        }
    }

    public class GuvenceItem
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public bool Durum { get; set; }
    }
}
