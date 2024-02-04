using CommitExplorerAplications.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommitExplorerAplications.Services.Interfaces
{
    /// <summary>
    /// Metodo que exponemos al Controlador
    /// </summary>
    public interface IComitExplorerService
    {
        Task<IActionResult> CommitsPorSemana(RequestCommits request);
    }
}
