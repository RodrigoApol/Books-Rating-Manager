using MediatR;
using Microsoft.AspNetCore.Http;

namespace BooksRatingManager.Application.Commands.BookCommands.UploadCoverBook;

public class UploadCoverBookCommand : IRequest<Unit>
{
    public UploadCoverBookCommand(int id, IFormFile cover)
    {
        Id = id;
        Cover = cover;
    }

    public int Id { get; set; }
    public IFormFile Cover { get; set; }
}