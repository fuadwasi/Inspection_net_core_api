using WebApiApplication1.Core;
using WebApiApplication1.Data;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Services
{
    public class InspectionTypeService : IInspectionTypeService
    {
        #region Fields

        private readonly IRepository<InspectionType> _inspectionTypeRepository;

        #endregion

        #region Ctor

        public InspectionTypeService(IRepository<InspectionType> inspectionTypeRepository)
        {
            _inspectionTypeRepository = inspectionTypeRepository;
        }

        #endregion

        #region Utilities



        #endregion

        #region Method

        public void DeleteInspectionType(InspectionType inspectionType)
        {
            _inspectionTypeRepository.Delete(inspectionType);
        }

        public InspectionType GetById(int id)
        {
            if (id < 1)
                return null;

            return _inspectionTypeRepository.GetById(id);
        }

        public void InsertInspectionType(InspectionType inspectionType)
        {
            if (inspectionType == null) return;

            _inspectionTypeRepository.Insert(inspectionType);
        }

        public IPagedList<InspectionType> SearchInspectionType(int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = _inspectionTypeRepository.Table;

            var inspectionTypeList = new PagedList<InspectionType>(query, pageIndex, pageSize);

            return inspectionTypeList;
        }

        public void UpdateInspectionType(InspectionType inspectionType)
        {
            if(inspectionType == null) return;

            _inspectionTypeRepository.Update(inspectionType);
        }

        #endregion
    }
}
