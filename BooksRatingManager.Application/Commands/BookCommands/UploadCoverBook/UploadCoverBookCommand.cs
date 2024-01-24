using MediatR;
using Microsoft.AspNetCore.Http;

namespace BooksRatingManager.Application.Commands.BookCommands.UploadCoverBook;

public class UploadCoverBookCommand(int id, IFormFile cover) : IRequest<Unit>
{
    public int Id { get; set; } = id;
    public IFormFile Cover { get; set; } = cover;
}