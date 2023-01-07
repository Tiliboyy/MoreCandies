using System.ComponentModel;
using Exiled.API.Interfaces;


internal class Config : IConfig
{

    [Description("Enables the Plugin")]
    public bool IsEnabled { get; set; } = true;

    public bool Debug { get; set; }

    public int MaxAmount { get; set; } = 3;
}