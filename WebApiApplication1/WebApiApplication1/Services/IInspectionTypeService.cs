using WebApiApplication1.Core;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Services
{
    public interface IInspectionTypeService
    {
        InspectionType GetById(int id);

        IPagedList<InspectionType> SearchInspectionType(
            int pageIndex = 0,
            int pageSize = int.MaxValue
            );

        void InsertInspectionType(InspectionType inspectionType);
        void UpdateInspectionType(InspectionType inspectionType);
        void DeleteInspectionType(InspectionType inspectionType);
    }
}
