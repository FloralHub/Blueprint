global using System.Reflection;
global using System.Text.Json.Serialization;
global using AlchemyLub.Blueprint.Application.Services.Abstractions;
global using AlchemyLub.Blueprint.Domain;
global using AlchemyLub.Blueprint.Endpoints.Attributes;
global using AlchemyLub.Blueprint.Endpoints.Requests;
global using AlchemyLub.Blueprint.Endpoints.Responses;
global using AlchemyLub.Blueprint.Endpoints.SchemaFilters;
global using AlchemyLub.Blueprint.Endpoints.Validators;
global using FluentValidation;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.OpenApi.Any;
global using Microsoft.OpenApi.Models;
global using Swashbuckle.AspNetCore.SwaggerGen;
global using Unchase.Swashbuckle.AspNetCore.Extensions.Extensions;
