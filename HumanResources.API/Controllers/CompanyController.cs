﻿using HumanResources.Core.Dto.Request;
using HumanResources.Usecase.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.API.Controllers;

[ApiController]
[Route("api/companies")]
public class CompanyController : ControllerBase
{
	private readonly ICompanyService _companyService;

	public CompanyController(ICompanyService companyService)
	{
		_companyService = companyService;
	}

	[HttpGet]
	public async Task<IActionResult> GetAll()
	{
		var response = await _companyService.GetAllAsync();

		return Ok(response);
	}

	[HttpGet("{id:guid}", Name = "GetCompanyById")]
	public async Task<IActionResult> GetById(Guid id)
	{
		var response = await _companyService.GetByIdAsync(id);

		return Ok(response);
	}

	[HttpPost]
	public async Task<IActionResult> Create(CompanyRequestDto company)
	{
		var response = await _companyService.CreateAsync(company);

		return CreatedAtRoute("GetCompanyById", new { id = response.Id}, response);
	}

	[HttpDelete("{id:guid}")]
	public async Task<IActionResult> Delete(Guid id)
	{
		await _companyService.DeleteAsync(id);

		return NoContent();
	}

	[HttpPut("{id:guid}")]
	public async Task<IActionResult> Update(Guid id, CompanyRequestDto company)
	{
		await _companyService.UpdateAsync(id, company);

		return NoContent();
	}
}
