namespace ServiceLayer.Services.Interfaces
{
    public interface IFileService
    {
        string ReadFile(string path, string template);
    }
}
