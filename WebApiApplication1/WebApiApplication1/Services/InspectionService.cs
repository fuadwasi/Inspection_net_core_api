using WebApiApplication1.Core;
using WebApiApplication1.Data;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Services
{
    public class InspectionService : IInspectionService
    {
        private readonly IRepository<Inspection> _inspectionRepository;
        #region Fields

        #endregion

        #region Ctor

        public InspectionService(IRepository<Inspection> inspectionRepository)
        {
            _inspectionRepository = inspectionRepository;
        }

        #endregion

        #region Utilities

        #endregion

        #region method
        public void DeleteInspection(Inspection inspection)
        {
            _inspectionRepository.Delete(inspection);
        }

        public Inspection GetById(int id)
        {
            if (id < 1)
                return null;

            return _inspectionRepository.GetById(id);
        }

        public void InsertInspection(Inspection inspection)
        {
            if (inspection == null) return;

            _inspectionRepository.Insert(inspection);
        }

        public IPagedList<Inspection> SearchInspection(string statusString = "", 
            int inspectionTypeId = 0, int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = _inspectionRepository.Table;

            if(!string.IsNullOrEmpty(statusString))
                query = query.Where(x => x.Status.Contains(statusString));

            if(inspectionTypeId > 0)
                query = query.Where(x => x.InspectionTypeId == inspectionTypeId);

            var inspectionList = new PagedList<Inspection>(query, pageIndex, pageSize);
            return inspectionList;
        }

        public void UpdateInspection(Inspection inspection)
        {
            if(inspection == null) return;

            _inspectionRepository.Update(inspection);
        }

        #endregion
    }
}
