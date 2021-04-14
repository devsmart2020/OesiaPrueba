﻿using Oesia.Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityDTO>> GetCountries();

    }
}
