using ICities;

namespace SimpleInfiniteDemand
{
    public class InfiniteDemand : DemandExtensionBase
    {
        public override int OnCalculateResidentialDemand(int origin)
        {
            origin = 100;
            return 100;
        }
        public override int OnCalculateCommercialDemand(int origin)
        {
            origin = 100;
            return 100;
        }
        public override int OnCalculateWorkplaceDemand(int origin)
        {
            origin = 100;
            return 100;
        }
        public override int OnUpdateDemand(int last, int next, int target)
        {
            target = 100;
            return 100;
        }
    }
}
