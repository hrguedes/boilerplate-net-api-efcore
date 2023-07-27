namespace Entities.Base.Interfaces;

public interface IBaseAudityEntity
{
    public Guid Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? RemovedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public bool Removed { get; set; }
    public Guid? UserCreateId { get; set; }
    public Guid? userUpdateId { get; set; }
}