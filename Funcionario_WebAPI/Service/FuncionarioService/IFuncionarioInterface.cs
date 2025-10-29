using Funcionario_WebAPI.Models;

namespace Funcionario_WebAPI.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {    
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();

        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novofuncionario);

        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel novofuncionario);

        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
    }
}
