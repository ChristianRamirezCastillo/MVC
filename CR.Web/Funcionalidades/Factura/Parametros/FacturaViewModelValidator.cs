using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;

namespace CR.Web.Funcionalidades.Factura.Parametros
{
    public class FacturaViewModelValidator : AbstractValidator<FacturaViewModel>
    {
        public FacturaViewModelValidator()
        {
            RuleFor(mod => mod.RUC)
                .NotEmpty()
                .WithMessage("Maximo 11 caracteres");

            RuleFor(mod => mod.RazonSocial)
                .NotEmpty()
                .Length(4)
                .WithMessage("Minimo 4 caracteres");

            RuleFor(mod => mod.FechaVencimiento)
                .NotEmpty()
                .WithMessage("La fecha debe ser minimo a 30 dias de la emision");

            RuleFor(mod => mod.Fecha)
                .NotEmpty()
                .WithMessage("No puede ser fecha menor a la emision ");

            RuleFor(mod => mod.Glosa)
                .NotEmpty()
                .Length(20)
                .WithMessage("Minimo 20 caracteres");


        }
    }
}