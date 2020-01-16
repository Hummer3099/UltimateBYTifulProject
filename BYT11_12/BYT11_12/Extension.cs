using System;

public class Extension
{
    public DateTime ExtensionDate { get; set; }
    
    public Extension(DateTime extensionDate)
    {
        this.ExtensionDate = DateTime.AddDays(14)(extensionDate, "dd/MM/yyyy", null);
    }
}
