namespace GymForward.DomainModel
{
    public interface IGymMembership
    {
        string Description { get; set; }
        string Name { get; }
        decimal GetPrice();
    }
}