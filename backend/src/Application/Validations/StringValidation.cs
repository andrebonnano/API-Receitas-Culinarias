
namespace Application.Validations
{
    public class StringValidation
    {
        public string GuidValidator(string valor)
        {
            if (!Guid.TryParse(valor, out _))
                throw new StringValidationExceprtions("dados enviados precisam corresponder a um GUID!");

            return valor;
        }

        public string TitleNameValidator(string valor)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9-]+$");
            if (!rgx.IsMatch(valor))
                throw new StringValidationExceprtions("Dados enviados contém caracteres inválidos!");

            valor = valor.ToLower();
            valor = char.ToUpper(valor[0]) + valor.Substring(1);

            return valor;
        }
    }
}
