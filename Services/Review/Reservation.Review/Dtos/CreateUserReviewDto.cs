namespace Reservation.Review.Dtos
{
    public class CreateUserReviewDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Detail { get; set; }
        public int Score { get; set; }
    }
}
