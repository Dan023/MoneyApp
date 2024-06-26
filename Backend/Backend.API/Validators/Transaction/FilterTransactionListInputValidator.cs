﻿using Backend.API.Types.Input.Transaction;
using FluentValidation;

namespace Backend.API.Validators.Transaction
{
    public class FilterTransactionListInputValidator : AbstractValidator<FilterTransactionListInput>
    {
        public FilterTransactionListInputValidator() 
        {
            RuleFor(x => x.UserEmail).NotEmpty();
            RuleFor(x => x.SelectedAccountId).NotEmpty();
            RuleFor(x => x.TransactionFilters.DateStart).NotEmpty().Must((model, startDate) => startDate <= model.TransactionFilters.DateEnd)
                .WithMessage("Start date can't be greater than end date");
            RuleFor(x => x.TransactionFilters.DateEnd).NotEmpty();
        }
    }
}
