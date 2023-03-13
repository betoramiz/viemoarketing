using MediatR;

namespace VideoMarketing.Controllers.Features.Appointment;

public class GetAppointments
{
	public record Query(DateTime DateTime) : IRequest<List<Response>>;

	public record Response(int Id, string CoachName, string AreaName, TimeOnly Time, int Duration);

	public class CommandHandler : IRequestHandler<Query, List<Response>>
	{
		// public CommandHandler(DbContext context) => _context = context;

		public async Task<List<Response>> Handle(Query request, CancellationToken cancellationToken) =>
			new List<Response>()
			{
				new Response(1, "Felipe", "Cardio", new TimeOnly(9, 0), 45),
				new Response(2, "Bro", "Weights", new TimeOnly(12, 0), 45),
				new Response(3, "Rocket", "Lobby", new TimeOnly(15, 30), 45),
				new Response(4, "Lance", "Boxing", new TimeOnly(15, 30), 45)
			};
	}
}
