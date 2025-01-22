namespace Hahn.Domain;

public partial class Equipament : ICloneable
{
    public Equipament()
    {
        OnCreated();
    }

    public virtual string Index { get; set; }
    public virtual string Name { get; set; }


    partial void OnCreated();


    public object Clone()
    {
        Equipament obj = new Equipament();
        obj.Index = Index;
        obj.Name = Name;
        return obj;
    }
}