using MediatR;

namespace VideoMarketing.Controllers.Features.Dashboard;

public class GetWorkOutPlan
{
	public record Query() : IRequest<List<Response>>;

	public record Response(int Id, string Plan);

	public class CommandHandler : IRequestHandler<Query, List<Response>>
	{
		// private readonly DbContext _context;
		// public CommandHandler(DbContext context) => _context = context;

		public async Task<List<Response>> Handle(Query request, CancellationToken cancellationToken)
		{
			return new List<Response>()
			{
				new Response(1, "M - Leg & lower"),
				new Response(2, "T- Back & Tricep"),
				new Response(2, "W - Biceps & Shoulder"),
				new Response(2, "T - Chest & Core"),
				new Response(2, "F - Cardio")
			};
		}
	}
}
