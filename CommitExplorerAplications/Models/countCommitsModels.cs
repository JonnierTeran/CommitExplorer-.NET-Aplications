namespace CommitExplorerAplications.Models
{
    /// <summary>
    /// Modelo para Mapear Todos los commits por semana de un repositorio
    /// </summary>
    public class countCommitsModels
    {
        /// <summary>
        /// ES: Todos las confirmaciones por semana Por todos los colaboradores y autor
        /// </summary>
        public List<int>? All { get; set; }

        /// <summary>
        /// Todas las confirmaciones por El Autor
        /// </summary>
        public List<int>? Owner { get; set; }

        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public countCommitsModels()
        {
            this.All = new List<int>();
            this.Owner = new List<int>();
        }

    }    
}
