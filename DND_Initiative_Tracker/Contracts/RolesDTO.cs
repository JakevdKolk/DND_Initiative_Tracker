namespace DND_Initiative_Tracker.Contracts
{
    public record RoleDto(int Id, string Name);

    public record CreateRoleDto(string Name);
}
