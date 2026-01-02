using DVLD.Core.Enums;
using DVLD.UI.UserControls.Shared;
using System.Drawing;

namespace DVLD.UI.Helpers.Shared
{
    internal class clsControlHelper
    {
        public static string PraperHeaderScreenAccordingTestType(enTestType TestType, ScreenHeader ScreenHeader, enTestAppointmentOperation TestAppointmentOperation = enTestAppointmentOperation.Nil)
        {
            string HeaderTitle = TestAppointmentOperation == enTestAppointmentOperation.ScheduleTest || TestAppointmentOperation == enTestAppointmentOperation.EditTest ? "Schedule Test" : TestAppointmentOperation == enTestAppointmentOperation.TakeTest ? "Scheduled Test" : TestAppointmentOperation == enTestAppointmentOperation.ScheduleRetakeTest ? "Schedule Retake Test" : "";
            string TestName = clsHandleApplicationEnums.GetTestTypeName(TestType) + " Test";
            Image TestImage = clsHandleApplicationEnums.GetTestTypeImage(TestType);
            string BaseTitle = ScreenHeader.Title;
            ScreenHeader.ScreenImage = TestImage;
            ScreenHeader.Title = HeaderTitle == "" ? TestName : HeaderTitle;
            return TestName;
        }
    }
}
