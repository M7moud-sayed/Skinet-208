using System;
using API.RequestHelpers;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    protected async Task<ActionResult> CreatePageResult<T>(IGenericRepository<T> genericRepository, ISpecification<T> spec, int pageIndex, int pageSize) where T : BaseEntity
    {
        var count = await genericRepository.CountAsync(spec);
        var items = await genericRepository.ListAsync(spec);
        var pagination = new Pagination<T>(pageIndex, pageSize, count, items);
        return Ok(pagination);
    }
}
