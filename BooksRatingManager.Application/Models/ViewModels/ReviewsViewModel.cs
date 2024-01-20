namespace BooksRatingManager.Application.Models.ViewModels;

public class ReviewsViewModel(int rating, string description)
{
    public int Rating { get; set; } = rating;
    public string Description { get; set; } = description;
}