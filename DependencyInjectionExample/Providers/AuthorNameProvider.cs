using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample.Providers
{
    public class AuthorNameProvider: IAuthorNameProvider
    {
        public string AuthorName => "Royston Malcomber";
    }
}
