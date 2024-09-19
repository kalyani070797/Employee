using Employee.Model.StatusModel;

namespace Employee.Core.StatusCore.Interface
{
    public interface IStatusCreator
    {
        void CreateStatus(StatusRequestModel statusRequest);
    }
}