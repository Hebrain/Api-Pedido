namespace Domain.Entities
{
    public class Pedido(string cliente)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Cliente { get; private set; } = cliente;
        public DateTime DataCriacao { get; private set; } = DateTime.Now;
    }
}
