using Microsoft.AspNetCore.Mvc;

namespace TestVibeAgent.Controllers
{
    /// <summary>
    /// Contrôleur pour les endpoints de test de connectivité
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        /// <summary>
        /// Endpoint ping qui retourne 'pong' en texte brut
        /// </summary>
        /// <returns>Retourne 'pong' comme réponse de test</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public ActionResult<string> Ping()
        {
            return Ok("pong");
        }
    }
}