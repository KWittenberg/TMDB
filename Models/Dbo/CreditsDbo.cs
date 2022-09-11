﻿namespace TMDB.MVC.Models;

public class CreditsDbo
{
    public int id { get; set; }
    public List<CastDbo> cast { get; set; }
    public List<CrewDbo> crew { get; set; }
    //public MovieDetailsDbo MovieDetailsDbo { get; set; }
    //public int MovieDetailsDboId { get; set; }
}

public class CastDbo
{
    public bool? adult { get; set; }
    public int? gender { get; set; }
    public int? id { get; set; }
    public string? known_for_department { get; set; }
    public string? name { get; set; }
    public string? original_name { get; set; }
    public double? popularity { get; set; }
    public string? profile_path { get; set; }
    public int? cast_id { get; set; }
    public string? character { get; set; }
    public string? credit_id { get; set; }
    public int? order { get; set; }
    public CreditsDbo CreditsDbo { get; set; }
    public int CreditsDboId { get; set; }
}

public class CrewDbo
{
    public bool? adult { get; set; }
    public int? gender { get; set; }
    public int? id { get; set; }
    public string? known_for_department { get; set; }
    public string? name { get; set; }
    public string? original_name { get; set; }
    public double? popularity { get; set; }
    public string? profile_path { get; set; }
    public string? credit_id { get; set; }
    public string? department { get; set; }
    public string? job { get; set; }
    public CreditsDbo CreditsDbo { get; set; }
    public int CreditsDboId { get; set; }
}