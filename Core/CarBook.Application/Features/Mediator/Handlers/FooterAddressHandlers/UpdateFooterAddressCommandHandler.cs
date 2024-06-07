using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler:IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _reposityory;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> reposityory)
        {
            _reposityory = reposityory;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await _reposityory.GetByIdAsync(request.FooterAddressID);
            values.Phone = request.Phone;
            values.Address = request.Address;  
            values.Description = request.Description;   
            values.Email = request.Email;
            await _reposityory.UpdateAsync(values);
        }
    }
}
