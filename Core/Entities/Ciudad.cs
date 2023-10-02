namespace Core.Entities;

public class Ciudad : BaseEntity
{
    public string Nombre { get; set; }
    public int IdDepartamentoFk { get; set; }
    public Departamento Departamentos { get; set; }
}
