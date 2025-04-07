using Company.Data.Entites;

namespace Company.Service.Interfaces
{
    public interface IDepartmentServices
    {
        Department GetById(int? id);
        IEnumerable<Department> GetAll();
        void Add(Department department);
        void Update(Department department);
        void Delete(Department department);
    }
}
