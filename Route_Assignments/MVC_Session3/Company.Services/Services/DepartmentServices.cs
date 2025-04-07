using System.Xml.Schema;
using Company.Data.Entites;
using Company.Repository.Interfaces;
using Company.Service.Interfaces;

namespace Company.Service.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentServices(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public void Add(Department department)
        {
            var mappedDepartment = new Department
            {
                Code = department.Code,
                Name = department.Name,
                CreateAt = DateTime.Now
            };
            _departmentRepository.Add(mappedDepartment);
        }

        public void Delete(Department department)
        {
            _departmentRepository.Delete(department);
        }

        public IEnumerable<Department> GetAll()
        {
            var departments = _departmentRepository.GetAll();
            return departments;
        }

        public Department GetById(int? id)
        {
            if (id is null)
                return null;

            var department = _departmentRepository.GetById(id.Value);
            
            if (department is null)
                return null;

            return department;
        }

        public void Update(Department department)
        {
            //var dept = GetById(department.Id);
            //if (dept.Name != department.Name)
            //{
            //    if (GetAll().Any(x => x.Name == department.Name))
            //        throw new Exception("DuplicateDepartmentName");
            //}
            //dept.Name = department.Name;
            //dept.Code = department.Code;

            _departmentRepository.Update(department);
        }
    }
}
