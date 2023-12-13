namespace CreekRiver.Models;

public class UserProfileDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public List<ReservationDTO> Reservations { get; set; }
}