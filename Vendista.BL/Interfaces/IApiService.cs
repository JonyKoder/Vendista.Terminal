using Vendista.BL.Entityes;

namespace Vendista.BL.Interfaces;

public interface IApiService
{
    Task<CommandModel> GetCommandTypes();
}