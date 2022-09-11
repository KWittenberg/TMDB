global using Microsoft.AspNetCore.Authorization;
//global using Microsoft.AspNetCore.Authentication.JwtBearer;
//global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
global using Microsoft.AspNetCore.Mvc.TagHelpers;
global using Microsoft.AspNetCore.Mvc.ViewFeatures;
global using Microsoft.AspNetCore.Mvc.Rendering;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Cors;
global using Microsoft.AspNetCore.Cors.Infrastructure;

global using Microsoft.IdentityModel.Tokens;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Options;

global using System.Text;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Diagnostics;
global using System.Security.Claims;
global using System.IdentityModel.Tokens.Jwt;

global using TMDB.MVC.Data;
global using TMDB.MVC.Models;
//global using TMDB.MVC.Models.Base;
//global using TMDB.MVC.Models.Binding;
//global using TMDB.MVC.Models.Dbo;
//global using TMDB.MVC.Models.Dbo.Base;
//global using TMDB.MVC.Models.Dto;
//global using TMDB.MVC.Models.ViewModel;
//global using CorsPolicy = TMDB.MVC.Models.CorsPolicy;

global using TMDB.MVC.Services.Interface;
global using TMDB.MVC.Services.Implementation;

global using AutoMapper;

global using Newtonsoft.Json;

global using Task = System.Threading.Tasks.Task;