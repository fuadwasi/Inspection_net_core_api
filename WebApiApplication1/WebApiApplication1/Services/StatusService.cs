using WebApiApplication1.Core;
using WebApiApplication1.Data;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Services
{
    public class StatusService : IStatusService
    {

        #region Fields

        private readonly IRepository<Status> _statusRepository;

        #endregion

        #region Ctor

        public StatusService(IRepository<Status> statusRepository)
        {
            _statusRepository = statusRepository;
        }

        #endregion

        #region Utilities



        #endregion

        #region Method

        public void DeleteStatus(Status status)
        {
            if (status == null) return;

            _statusRepository.Delete(status);
        }

        public Status GetById(int id)
        {
            if (id < 1) return null;

            return _statusRepository.GetById(id);
        }

        public void InsertStatus(Status status)
        {
            if(status == null) return;

            _statusRepository.Insert(status);
        }

        public IPagedList<Status> SearchStatus(int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = _statusRepository.Table;

            var statusList = new PagedList<Status>(query, pageIndex, pageSize);
            
            return statusList;
        }

        public void UpdateStatus(Status status)
        {
            if (status == null) return;

            _statusRepository.Update(status);
        }

        #endregion
    }
}
