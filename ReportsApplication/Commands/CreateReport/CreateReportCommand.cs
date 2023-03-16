﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ReportsApplication.Reports.Commands.CreateReport
{
    public class CreateReportCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }
    }
}
