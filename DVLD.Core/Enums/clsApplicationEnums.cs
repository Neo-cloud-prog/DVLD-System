namespace DVLD.Core.Enums
{
    public enum enMode
    {
        AddNew = 0,
        Update = 1,
    }

    public enum enTestType
    {
        Vision = 0,
        Written = 1,
        Street = 2
    }

    public enum enLicenseClassType
    {
        SmallMotorcycle = 1,
        HeavyMotorcycle = 2,
        Ordinary = 3,
        Commercial = 4,
        Agricultural = 5,
        SmallAndMediumBus = 6,
        TruckAndheavyVehicle = 7
    }

    public enum enApplicationType
    {
        NewLocalDrivingLicense = 1,
        RenewDrivingLicense = 2,
        ReplacementForLostDrivingLicense = 3,
        ReplacementForDamagedDrivingLicense = 4,
        ReleaseDetainedDrivingLicense = 5,
        NewInternationalLicense = 6,
        RetakeTest = 8
    }

    public enum enIssueReason
    {
        FirstTime = 1,
        Renew = 2,
        ReplacementForDamaged = 3,
        ReplacementForLost = 4
    }

    public enum enApplicationStatus
    {
        New = 1,
        Cancelled = 2,
        Completed = 3
    }

    public enum enReplaceLicenseFor 
    { 
        Lost = 4, 
        Damaged = 3
    }

    public enum enTestAppointmentOperation
    {
        ScheduleTest,
        ScheduleRetakeTest,
        TakeTest,
        EditTest,
        Nil
    }
}
