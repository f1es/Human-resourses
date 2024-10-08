﻿namespace HumanResources.Core.Shared.Dto.Response;

public record WorkerResponseDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Phone,
    DateTime Birthday);
