﻿using HumanResources.Core.Dto.Request;
using HumanResources.Core.Dto.Response;
using HumanResources.Core.Models;

namespace HumanResources.Usecase.Services.Interfaces;

public interface IDepartmentService
{
	Task<IEnumerable<DepartmentResponseDto>> GetAllAsync(Guid companyId, PagingParameters pagingParameters);
	Task<DepartmentResponseDto> GetByIdAsync(Guid companyId, Guid id);
	Task<DepartmentResponseDto> CreateAsync(Guid companyId, DepartmentRequestDto departmentDto);
	Task UpdateAsync(Guid companyId, Guid id, DepartmentRequestDto departmentDto);
	Task DeleteAsync(Guid companyId, Guid id);
}
