using dotnet.src.Domain.DTOs;

namespace dotnet.src.Domain.Model.EmployeeAggregate
{
    public interface IEmpoyeeRepository
    {
        void Create(Employee employee);
        List<EmployeeDTO> Get();

        Employee? FindUserPhoto(int id);

        Employee? Get(int id);
    }
}