using LoginBlazor.Shared;

namespace LoginBlazor.Server.Authentication
{
    public class JWTAuthenticationManager
    {
        public const string JWT_SECURITY_KEY = "yPkHGAVHjavvASVAHvajVVGctgfhgCGCgsdgINvcsuAsd";
        public const int JWT_TOKEN_VALIDITY_MINS = 20;

        private UserAccountService _userAccountService;
        public JWTAuthenticationManager(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        public UserSession? GenerateJwtToken(string userName, string password)
        {
            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            /*Validando las credenciales del usuario*/

            var userAccount = _userAccountService.GetUserAccountByUserName(userName);
            if(userAccount == null || userAccount.Password != password)//si la contraseña no es valida o el nombre de usuario no existe devuelve null
                return null;
            /*Si las crewdenciales son valida*/
        }
    }
}
