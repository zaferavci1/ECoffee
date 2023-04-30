﻿using ECoffee.Application.Features.Customers.Commands.Update;
using FluentValidation;

namespace ECoffee.Application.Features.Customers.Validators
{
    public class UpdateCustomerValidator:AbstractValidator<UpdateCustomerCommandRequest>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(c => c.Id).NotEmpty()
                .NotNull().WithMessage("Lütfen müşteri id'sini boş geçmeyiniz.")
                .GreaterThan(0).WithMessage("Lütfen müşteri id'sini 0'dan büyük giriniz.");
            
            RuleFor(c => c.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen müşteri adını boş geçmeyiniz.")
                .MaximumLength(30)
                .MinimumLength(3)
                    .WithMessage("Lütfen müşteri adını 5 ile 150 karakter arasında giriniz.");

            RuleFor(c => c.Surname)
               .NotEmpty()
               .NotNull()
                   .WithMessage("Lütfen müşteri soyadını boş geçmeyiniz.")
               .MaximumLength(30)
               .MinimumLength(3)
                   .WithMessage("Lütfen müşteri soyadını 5 ile 150 karakter arasında giriniz.");

            RuleFor(c => c.Email)
                .NotEmpty()
                .NotNull().WithMessage("Email boş geçilemez.")
                .MinimumLength(15)
                .MaximumLength(100).WithMessage("Email 15 karakterden küçük veya 100 karakterden büyük olamaz");

        }
    }
}
