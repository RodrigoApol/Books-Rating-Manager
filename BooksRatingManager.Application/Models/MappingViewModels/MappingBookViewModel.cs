using BooksRatingManager.Application.Models.ViewModels;
using BooksRatingManager.Core.Entities;

namespace BooksRatingManager.Application.Models.MappingViewModels;

public static class MappingBookViewModel
{
    public static IEnumerable<BookViewModel> ToViewModel(this IEnumerable<Book> books)
    {
        return books.Select(b => new BookViewModel(
            b.Title,
            b.Description,
            b.ISBN,
            b.Author,
            b.PublicationYear,
            b.Genre.ToString()
        )).ToList();
    }

    public static BookDetailsViewModel ToViewModelWithId(this Book book)
        => new(
            book.Title,
            book.Description,
            book.ISBN,
            book.Author,
            book.Publisher,
            book.Genre.ToString(),
            book.PublicationYear,
            book.Pages,
            book.Average,
            book.Cover,
            book.Reviews
                .ToViewModel()
                .ToList());
}