using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{

    //empty interface that doesn´t produces a response
    public interface ICommand: ICommand<Unit>
    {

    }

    //produces a response
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
