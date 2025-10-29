using Funcionario_WebAPI.Models;

namespace Funcionario_WebAPI.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {    
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();

    }
}
