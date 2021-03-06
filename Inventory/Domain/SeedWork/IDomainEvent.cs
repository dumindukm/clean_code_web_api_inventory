﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SeedWork
{
    public interface IDomainEvent :INotification
    {
        DateTime OccurredOn { get; }
    }
}
