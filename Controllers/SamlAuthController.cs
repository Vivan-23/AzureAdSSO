using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sustainsys.Saml2.AspNetCore2;
using System.Security.Claims;

namespace AzureAdTest.Controllers
{
    [ApiController]
    [Route("auth")]
    public class SamlAuthController : ControllerBase
    {


        private readonly ILogger<SamlAuthController> _logger;

        public SamlAuthController(ILogger<SamlAuthController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet("login")]
        public IActionResult Login()
        {
            return new ChallengeResult(
                Saml2Defaults.Scheme,
                new AuthenticationProperties
                {
                    RedirectUri = Url.Action(nameof(Callback))
                });
        }

        [AllowAnonymous]
        [HttpGet("callback")]
        public async Task<IActionResult> Callback()
        {
            var authenticateResult = await HttpContext.AuthenticateAsync(ApplicationSamlConstants.External);

            if (!authenticateResult.Succeeded)
            {
                return Unauthorized();
            }

            return Ok($"Hi {authenticateResult.Principal.FindFirst(ClaimTypes.Email)?.Value.ToString()} {authenticateResult.Principal.FindFirst(ClaimTypes.Name)?.Value.ToString()}");
        }

    }
}