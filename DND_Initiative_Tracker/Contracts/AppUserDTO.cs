namespace DND_Initiative_Tracker.Contracts
{
    public record AppUserDto(int Id, string Name, RoleDto? Role);

    public record CreateAppUserDto(string Name, int RoleId);

    public record UpdateAppUserDto(string Name, int RoleId);

}
