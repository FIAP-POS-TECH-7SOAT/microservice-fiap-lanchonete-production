namespace FiapLanchonete.Application.Exception
{
    public class ApplicationException : System.Exception
    {
        internal ApplicationException(string businessMessage)
               : base(businessMessage)
        {
        }
    }
}
