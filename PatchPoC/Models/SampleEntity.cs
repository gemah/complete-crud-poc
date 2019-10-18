namespace PatchPoC.Models
{
    /// <summary>
    /// A simple class that represents an address.
    /// </summary>
    public class SampleEntity
    {
        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public SampleEntity() { }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        /// <param name="id">The entity Id.</param>
        /// <param name="nome">The entity Name</param>
        /// <param name="endereco">The entity Address.</param>
        public SampleEntity(int id, string nome, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        /// <summary>
        /// The entity ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The entity Name.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// The entity Address.
        /// </summary>
        public string Endereco { get; set; }
    }
}
