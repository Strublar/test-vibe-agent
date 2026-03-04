using Microsoft.AspNetCore.Mvc;

namespace TestVibeAgent.Controllers;

/// <summary>
/// Contrôleur pour les endpoints de vérification de connectivité
/// </summary>
[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{
    /// <summary>
    /// Endpoint ping qui retourne 'pong' pour vérifier la connectivité de l'API
    /// </summary>
    /// <returns>Retourne 'pong' en format texte</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("pong");
    }
}