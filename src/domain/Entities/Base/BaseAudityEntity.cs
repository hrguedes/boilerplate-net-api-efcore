using Entities.Base.Interfaces;

namespace Entities.Base;

public class BaseAudityEntity : IBaseAudityEntity
{
    public Guid Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? RemovedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public bool Removed { get; set; }
    public Guid? UserCreateId { get; set; }
    public Guid? userUpdateId { get; set; }

    public BaseAudityEntity()
    {
        if (Id != null) return;
        Removed = false;
        UpdateAt = DateTime.Now;
        CreateAt = DateTime.Now;
    }
}