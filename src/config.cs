using ICities;

namespace SimpleInfiniteDemand
{
    [ConfigurationPath("SimpleInfiniteDemand.xml")]
    public class Configuration {
        public string SmallRoadTree { get; set; } = "909448182.Royal Palm_Data";
    }
    public partial class SimpleInfiniteDemand : IUserMod
    {
        public void OnSettingsUI(UIHelperBase helper)
        {
            // helper.AddSlider("Residential", 0f, 100f, 1f, 100f, );
        }
    }
}
