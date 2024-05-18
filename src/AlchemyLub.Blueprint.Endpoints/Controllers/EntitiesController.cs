namespace AlchemyLub.Blueprint.Endpoints.Controllers;

/// <summary>
/// Базовый контроллер сущностей.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class EntitiesController(IApplicationService applicationService) : ControllerBase
{
    /// <summary>
    /// Получить сущность
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    [HttpGet("{id}")]
    public async Task<EntityResponse> GetEntity(Guid id)
    {
        Entity entity = await applicationService.GetEntity(id);

        return new(entity.Id, entity.Title);
    }

    /// <summary>
    /// Создать сущность
    /// </summary>
    [HttpPost]
    public async Task<Guid> CreateEntity(EntityType type) => await applicationService.CreateEntity(type);

    /// <summary>
    /// Удалить сущность
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    [HttpDelete("{id}")]
    public async Task<bool> DeleteEntity(Guid id) => await applicationService.DeleteEntity(id);

    /// <summary>
    /// Обновить сущность
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <param name="request">Новая сущность</param>
    [HttpPatch("{id}")]
    public async Task<EntityResponse> UpdateEntity(Guid id, EntityRequest request)
    {
        Entity newEntity = new(id)
        {
            Title = request.Title,
            Description = request.Description,
            CreatedAt = DateTime.UtcNow
        };

        Entity entity = await applicationService.UpdateEntity(id, newEntity);

        return new(entity.Id, entity.Title);
    }
}
