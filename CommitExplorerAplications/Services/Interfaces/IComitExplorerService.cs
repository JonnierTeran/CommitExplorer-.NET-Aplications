using CommitExplorerAplications.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommitExplorerAplications.Services.Interfaces
{
    /// <summary>
    /// Metodo que exponemos al Controlador
    /// </summary>
    public interface IComitExplorerService
    {
        /// <summary>
        /// Metodo Expuesto Para el Controlador
        /// </summary>
        /// <param name="request"> Recibe Un Objeto de Tipo RequestCommits con la Libreria y cantidad de repositorios deseados</param>
        /// <returns> Regresa un Arrays de Objetos de tipo ResponseCommit con la informacion de los repositorios</returns>
        Task<IActionResult> CommitsPorSemana(RequestCommits request);
    }
}
