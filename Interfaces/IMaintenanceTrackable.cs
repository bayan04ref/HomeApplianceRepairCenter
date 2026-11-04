namespace HomeApplianceRepairCenter.Interfaces
{
    public interface IMaintenanceTrackable
    {
        void AddMaintenanceNote(string note);
        string GetLastMaintenanceNote();
    }
}
