namespace AlchemyLub.Blueprint.Application.Services.Abstractions;

/// <summary>
/// Сервис инфраструктурного слоя
/// </summary>
public interface IInfrastructureService
{
    /// <summary>
    /// Получить сущность из БД
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Запрашиваемая сущность</returns>
    public Task<IEntity> GetDbEntity(Guid id);

    /// <summary>
    /// Создать новую сущность в БД
    /// </summary>
    /// <returns>Идентификатор созданной сущности</returns>
    public Task<Guid> AddDbEntity();

    // TODO: Заменить результат на Success/Failure
    /// <summary>
    /// Удалить сущность из БД
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns><see langword="true"/> если удаление успешно, <see langword="false"/> если нет</returns>
    public Task<bool> DeleteDbEntity(Guid id);
}
