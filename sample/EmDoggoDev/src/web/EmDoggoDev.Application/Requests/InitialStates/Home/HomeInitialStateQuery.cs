using AutoMapper;
using EmDoggoDev.Application.Common.Interfaces.Persistance;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EmDoggoDev.Application.Requests.InitialStates.Home
{
    public class HomeInitialStateQuery : IRequest<HomeViewModel>
    {
        public class HomeInitialStateQueryHandler : IRequestHandler<HomeInitialStateQuery, HomeViewModel>
        {
            private readonly IEntityContext context;
            private readonly IMapper mapper;

            public HomeInitialStateQueryHandler(IEntityContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<HomeViewModel> Handle(HomeInitialStateQuery request, CancellationToken cancellationToken)
            {
                return new HomeViewModel();
            }
        }
    }
}