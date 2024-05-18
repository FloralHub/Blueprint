global using AlchemyLub.Blueprint.Application.Services.Abstractions;
global using AlchemyLub.Blueprint.Clients.Abstractions;
global using AlchemyLub.Blueprint.Domain;
global using AlchemyLub.Blueprint.Endpoints.Controllers;
global using AlchemyLub.Blueprint.Endpoints.Requests;
global using AlchemyLub.Blueprint.IntegrationTests.Extensions;
global using AlchemyLub.Blueprint.IntegrationTests.Stubs;
global using FluentAssertions;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Mvc.Testing;
global using Microsoft.AspNetCore.TestHost;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Refit;
global using ClientEntityResponse = AlchemyLub.Blueprint.Clients.Responses.EntityResponse;
global using ClientEntityRequest = AlchemyLub.Blueprint.Clients.Requests.EntityRequest;
