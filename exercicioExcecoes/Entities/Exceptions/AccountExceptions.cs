using System;


namespace exercicioExcecoes.Entities.Exceptions
{
    class AccountExceptions: ApplicationException
    {
        public AccountExceptions(string message) : base(message)
        {

        }
    }
}
