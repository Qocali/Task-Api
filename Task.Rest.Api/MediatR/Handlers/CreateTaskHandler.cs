using Domain.Domain.Entities;
using MediatR;
using Task.Rest.Api.MediatR.Commands;

namespace Task.Rest.Api.MediatR.Handlers
{
    public class CreateTaskHandler : IRequestHandler<CreatetaskCommand, Tasks>
    {
        public Task<Tasks> Handle(CreatetaskCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
