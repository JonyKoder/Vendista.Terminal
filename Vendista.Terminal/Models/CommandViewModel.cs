﻿namespace Vendista.Terminal.Models;

public class CommandViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Parameter_name1 { get; set; }
    public string Parameter_name2 { get; set; }
    public string Parameter_name3 { get; set; }
    public int Parameter_default_value1 { get; set; }
    public int Parameter_default_value2 { get; set; }
    public int Parameter_default_value3 { get; set; }
}