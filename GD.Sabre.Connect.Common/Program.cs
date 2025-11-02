
using GD.Sabre.Common.Core;
using GD.Sabre.Common.Core.Factories;
using GD.Sabre.Common;
using GD.Sabre.Common.Core.Models;
using GD.Sabre.Common.Core.Models.Options;
using GD.Sabre.Common.Service.Session;
using System.Net;
using GD.Sabre.Connect.Common.Service;
using GD.Sabre.Common.Models.AirAvail;

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


app.MapGet("/AirAvail", async (ISabreSessionPool sessionPool, ISabreAirAvail avail) =>
{

    SessionItem? sessionItem = null;
    OTA_AirAvailRS? resp = null;

    try
    {
        sessionItem = await sessionPool.GetLimitedSession("CC61");
        resp = await avail.AirAvail(sessionItem.SessionToken!);

    }
    catch (SabreException sx)
    {
        return new AirAvailResponseModel
        {
             Errors = [ sx.Message ]
        };
    }
    catch (Exception ex)
    {
        return new AirAvailResponseModel
        {
            Errors = [ex.Message]
        };
    }
    finally
    {

        if (sessionItem != null)
            await sessionPool.ReleaseSession(sessionItem);
        // await sessionPool.CloseSession(result.SessionPoolItem.SessionToken, "CC1");
    }


    return resp.ToModel();


})
.WithName("AirAvail");

app.MapGet("/CloseSession", async (string sessionToken, string pcc,  ISabreSessionPool sessionPool) =>
{
    var result = await sessionPool.CloseSession(sessionToken, pcc);
    return result;

})
.WithName("GoseSession");



app.Run();

