using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mailing
{
    public interface IEmailTemplateService : ITransientService
    {
        string GenerateEmailTemplate<T>(string templateName, T mailTemplateModel);
    }
}
