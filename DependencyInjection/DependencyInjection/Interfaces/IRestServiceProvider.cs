namespace DependencyInjection.Interfaces
{
    public interface IRestServiceProvider
    {
        string URL { get; set; }
        object[] GetRecords();
        bool CreateRecord(object rec);
        bool UpdateRecord(object rec);
        bool DeleteRecord(object rec);
    }
}
