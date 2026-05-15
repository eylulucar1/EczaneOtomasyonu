using System;

namespace EczaneOtomasyonu
{
    // Demo modu için basit yapı. Varsayılan olarak demo etkin (true).
    public static class DemoConfig
    {
        public static bool IsDemo { get; }

        static DemoConfig()
        {
            // Ortam değişkeni ile üzerine yazılabilir: ECZANE_DEMO = "false" ise gerçek mod.
            var env = Environment.GetEnvironmentVariable("ECZANE_DEMO");
            if (!string.IsNullOrEmpty(env))
            {
                bool parsed;
                if (bool.TryParse(env, out parsed))
                {
                    IsDemo = parsed;
                    return;
                }
            }

            // Varsayılan: demo modu etkin
            IsDemo = true;
        }
    }
}