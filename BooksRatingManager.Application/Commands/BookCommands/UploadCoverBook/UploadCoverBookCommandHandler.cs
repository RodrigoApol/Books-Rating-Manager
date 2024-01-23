using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.UploadCoverBook;

public class UploadCoverBookCommandHandler : IRequestHandler<UploadCoverBookCommand, Unit>
{
    private readonly IBookRepository _bookRepository;

    public UploadCoverBookCommandHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    public async Task<Unit> Handle(UploadCoverBookCommand request, CancellationToken cancellationToken)
    {
        var book = await _bookRepository.GetByIdAsync(request.Id);

        byte[] cover;
        using (var stream = new MemoryStream())
        {
            await request.Cover.CopyToAsync(stream, cancellationToken);

            cover = stream.ToArray();
        }
        
        book.UploadCover(cover);
        await _bookRepository.SaveChangesAsync();
        
        return Unit.Value;
    }
}