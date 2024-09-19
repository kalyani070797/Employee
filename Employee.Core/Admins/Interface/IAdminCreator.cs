using Employee.Model.Admins;

namespace Employee.Core.Admins.Interface
{
    public interface IAdminCreator
    {
        void CreateAdmin(AdminRequestModel adminRequest);
    }
}