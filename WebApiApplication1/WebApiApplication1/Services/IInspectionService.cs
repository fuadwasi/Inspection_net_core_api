using WebApiApplication1.Core;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Services
{
    public interface IInspectionService
    {
        Inspection GetById(int id);

        IPagedList<Inspection> SearchInspection(
            string statusString = "",
            int inspectionTypeId = 0, 
            int pageIndex = 0, 
            int pageSize = int.MaxValue
            );

        void InsertInspection(Inspection inspection);
        void UpdateInspection(Inspection inspection);
        void DeleteInspection(Inspection inspection);

    }
}
