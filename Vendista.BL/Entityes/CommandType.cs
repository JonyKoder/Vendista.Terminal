namespace Vendista.BL.Entityes;

public class CommandModel
{
    public int PageNumber { get; set; }
    public int ItemsPerPage { get; set; }
    public int ItemsCount { get; set; }
    public List<CommandType> Items { get; set; }
}

public class CommandType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Parameter_name1 { get; set; }
    public string Parameter_name2 { get; set; }
    public string Parameter_name3 { get; set; }
    public string Parameter_name4 { get; set; }
    public string Parameter_name5 { get; set; }
    public string Parameter_name6 { get; set; }
    public string Parameter_name7 { get; set; }
    public string Parameter_name8 { get; set; }
    public string Str_parameter_name1 { get; set; }
    public string Str_parameter_name2 { get; set; }
    public int? Parameter_default_value1 { get; set; }
    public int? Parameter_default_value2 { get; set; }
    public int? Parameter_default_value3 { get; set; }
    public int? Parameter_default_value4 { get; set; }
    public int? Parameter_default_value5 { get; set; }
    public int? Parameter_default_value6 { get; set; }
    public int? Parameter_default_value7 { get; set; }
    public int? Parameter_default_value8 { get; set; }
    public string Str_parameter_default_value1 { get; set; }
    public string Str_parameter_default_value2 { get; set; }
    public bool Visible { get; set; }
}


