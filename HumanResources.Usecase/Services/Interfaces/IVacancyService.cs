﻿using HumanResources.Core.Shared.Dto.Request;
using HumanResources.Core.Shared.Dto.Response;
using HumanResources.Core.Shared.Parameters;

namespace HumanResources.Usecase.Services.Interfaces;

public interface IVacancyService
{
	Task<IEnumerable<VacancyResponseDto>> GetAllAsync(Guid companyId, RequestParameters requestParameters);
	Task<VacancyResponseDto> GetByIdAsync(Guid companyId, Guid id);
	Task<VacancyResponseDto> CreateAsync(Guid companyId, VacancyRequestDto vacancyDto);
	Task UpdateAsync(Guid companyId, Guid id, VacancyRequestDto vacancyDto);
	Task DeleteAsync(Guid companyId, Guid id);
	Task<ProfessionResponseDto> GetProfessionByIdAsync(Guid companyId, Guid id);
}
