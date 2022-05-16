using WebApiApplication1.Core;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Services
{
    public interface IStatusService
    {
        Status GetById(int id);

        IPagedList<Status> SearchStatus(
            int pageIndex = 0,
            int pageSize = int.MaxValue
            );

        void InsertStatus(Status status);
        void UpdateStatus(Status status);
        void DeleteStatus(Status status);
    }
}
