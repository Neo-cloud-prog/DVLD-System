using System.Drawing;
using DVLD.Core.Enums;

namespace DVLD.UI.Helpers.Shared
{
    public class clsHandleApplicationEnums
    {
        public static string GetApplicationTypeName(enIssueReason IssueReason)
        {
            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.ReplacementForDamaged:
                    return "Replacement For Damaged";
                default:
                    return "Replacement for Lost";
            }
        }

        public static string GetTestTypeName(enTestType TestType)
        {
            switch (TestType)
            {
                case enTestType.Vision:
                    return "Vision";
                case enTestType.Written:
                    return "Written";
                default:
                    return "Street";
            }
        }



        public static Image GetTestTypeImage(enTestType TestType)
        {
            switch (TestType)
            {
                case enTestType.Vision:
                    return Properties.Resources.Vision;
                case enTestType.Written:
                    return Properties.Resources.Written;
                default:
                    return Properties.Resources.Street;
            }
        }

        public static string GetApplicationStatusName(enApplicationStatus ApplicationStatus)
        {
            switch (ApplicationStatus)
            {
                case enApplicationStatus.New:
                    return "New";
                case enApplicationStatus.Cancelled:
                    return "Cancelled";
                default:
                    return "Completed";
            }
        }
    }
}
