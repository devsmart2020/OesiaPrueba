using Oesia.App.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.App.Service.Interfaces
{
    public interface IStateService
    {
        Task<IEnumerable<StateDTO>> GetAllStates();

    }
}
