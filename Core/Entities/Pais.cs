namespace Core.Entities;

public class Pais : BaseEntity
{
    public string Nombre { get; set; }
    public int IdPaisFk { get; set; }
    public ICollection<Departamento> Departamentos { get; set; }
}
