﻿using HumanResources.Core.Models;
using HumanResources.Core.Shared.Dto.Request;
using HumanResources.Core.Shared.Dto.Response;

namespace HumanResources.Usecase.Services.Interfaces;

public interface ICompanyService
{
	Task<IEnumerable<CompanyResponseDto>> GetAllAsync(RequestParameters requestParameters);
	Task<CompanyResponseDto> GetByIdAsync(Guid id);
	Task<CompanyResponseDto> CreateAsync(CompanyRequestDto companyDto);
	Task UpdateAsync(Guid id, CompanyRequestDto companyDto);
	Task DeleteAsync(Guid id);
}
