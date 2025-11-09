
using GD.Sabre.Common;
using GD.Sabre.Common.Core;
using GD.Sabre.Common.Core.Factories;
using GD.Sabre.Common.Core.Models;
using GD.Sabre.Common.Core.Models.Options;
using GD.Sabre.Common.Models.AirAvail;
using GD.Sabre.Common.Service.Session;
using GD.Sabre.Connect.Common.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient(HttpClientSetup.DefaultSoapClientName)
                .ConfigurePrimaryHttpMessageHandler(() =>
                    new HttpClientHandler
                    {
                        AutomaticDecompression = DecompressionMethods.All
                    });

builder.Services.AddSabreCommon(builder.Configuration.GetSection("SabreServices"));
builder.Services.AddTransient<ISabreAirAvail, SabreAirAvail>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/GetSession", async (ISabreSessionPool sessionPool) =>
{
    var result =    await sessionPool.GetPooledSession("CC61");
    return result;

})
.WithName("GetSession");


app.MapGet("/AirAvail", async ([AsParameters] AirAvailRequestModel req, ISabreSessionPool sessionPool, ISabreAirAvail avail) =>
{

    SessionItem? sessionItem = null;

    try
    {
        var sessionResult = await sessionPool.GetLimitedSession("CC61");

        if (!sessionResult.IsSuccess)
            return SabreResult<AirAvailResponseModel>.Failure(sessionResult.Error);

        sessionItem = sessionResult.Response;

        var resp = await avail.AirAvail(req, sessionItem!.SessionToken!);

        var model = resp.Response.ToModel();

        resp = await avail.MoreAirAvail(sessionItem!.SessionToken!);

         model = model.AddToModel(resp.Response);

        if (!sessionResult.IsSuccess)
            return SabreResult<AirAvailResponseModel>.Failure(sessionResult.Error);


        return SabreResult<AirAvailResponseModel>.Success(model);

    }
    catch (Exception ex)
    {
        return SabreResult<AirAvailResponseModel>.Failure(ex);
    }

    finally
    {
        if (sessionItem != null)
            await sessionPool.ReleaseSession(sessionItem);
        //    // await sessionPool.CloseSession(result.SessionPoolItem.SessionToken, "CC1");
    }


})
.WithName("AirAvail");

app.MapGet("/CloseSession", async (string sessionToken, string pcc,  ISabreSessionPool sessionPool) =>
{
    var result = await sessionPool.CloseSession(sessionToken, pcc);
    return result;

})
.WithName("GoseSession");



app.Run();

