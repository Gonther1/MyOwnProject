namespace Core.Entities;

public class Departamento : BaseEntity
{
    public string Nombre { get; set; }
    public int IdPaisFk { get; set; }
}
