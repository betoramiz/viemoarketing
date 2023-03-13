using MediatR;

namespace VideoMarketing.Controllers.Features.Appointment;

public class BookClass
{
	public record Command(int Id) : IRequest<Response>;

	public record Response(int Id);

	public class CommandHandler : IRequestHandler<Command, Response>
	{
		public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
