using dotnet.src.Domain.DTOs;
using dotnet.src.Domain.Model.EmployeeAggregate;

namespace dotnet.src.infra.Repositories
{
    public class EmployeeRepository : IEmpoyeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        
        public void Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public Employee? FindUserPhoto(int id)
        {
            return _context.Employees.Find(id);
        }

        public List<EmployeeDTO> Get()
        {
            return _context.Employees.Select(b => new EmployeeDTO()
            {
                Id = b.id,
                NameEmployee = b.name,
                Photo = b.photo
            }).ToList();
        }

        public Employee? Get(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}