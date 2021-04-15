using Oesia.Front.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Interfaces
{
    public interface IEditorialService
    {
        Task<IEnumerable<EditorialDTO>> GetAllEditorials();

    }
}
