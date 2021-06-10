using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Token;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Xero.NetStandard.OAuth2.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Http;
using XeroNetStandardApp.Models;

namespace XeroNetStandardApp.Controllers
{
  public class InvoiceSync : Controller
  {
    private readonly ILogger<AuthorizationController> _logger;
    private readonly IOptions<XeroConfiguration> XeroConfig;
    private readonly IHttpClientFactory httpClientFactory;

    public InvoiceSync(IOptions<XeroConfiguration> XeroConfig, IHttpClientFactory httpClientFactory, ILogger<AuthorizationController> logger)
    {
      _logger = logger;
      this.XeroConfig = XeroConfig;
      this.httpClientFactory = httpClientFactory;
    }

    // GET: /InvoiceSync/
    public async Task<ActionResult> Index()
    {
      var xeroToken = TokenUtilities.GetStoredToken();
      var utcTimeNow = DateTime.UtcNow;

      if (utcTimeNow > xeroToken.ExpiresAtUtc)
      {
        var client = new XeroClient(XeroConfig.Value, httpClientFactory);
        xeroToken = (XeroOAuth2Token)await client.RefreshAccessTokenAsync(xeroToken);
        TokenUtilities.StoreToken(xeroToken);
      }

      string accessToken = xeroToken.AccessToken;
      string xeroTenantId = xeroToken.Tenants[0].TenantId.ToString();

      var AccountingApi = new AccountingApi();


      var sevenDaysAgo = DateTime.Now.AddDays(-7).ToString("yyyy, MM, dd");
      var invoicesFilter = "Date >= DateTime(" + sevenDaysAgo + ")";

      var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId, null, invoicesFilter);
      var invoices = response._Invoices;

      return View(invoices);
    }

    // GET: /InvoiceSync#Create
    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpGet]
    public async Task<ActionResult> Submit()
    {
      var xeroToken = TokenUtilities.GetStoredToken();
      var utcTimeNow = DateTime.UtcNow;

      if (utcTimeNow > xeroToken.ExpiresAtUtc)
      {
        var client = new XeroClient(XeroConfig.Value, httpClientFactory);
        xeroToken = (XeroOAuth2Token)await client.RefreshAccessTokenAsync(xeroToken);
        TokenUtilities.StoreToken(xeroToken);
      }

      string accessToken = xeroToken.AccessToken;
      string xeroTenantId = xeroToken.Tenants[0].TenantId.ToString();

      var AccountingApi = new AccountingApi();

      var invoicesFilter = "Status == \"DRAFT\"";

      var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId, null, invoicesFilter);
      var invoices = response._Invoices;

      List<InvoiceModel> models = new List<InvoiceModel>();

      foreach (var i in invoices)
      {
          models.Add(new InvoiceModel {invoiceId = i.InvoiceID, invoice = i, isChecked = false});
      }

      //return View(invoices);
      return View(models);
    }

    public async Task<ActionResult> Approve()
    {
      var xeroToken = TokenUtilities.GetStoredToken();
      var utcTimeNow = DateTime.UtcNow;

      if (utcTimeNow > xeroToken.ExpiresAtUtc)
      {
        var client = new XeroClient(XeroConfig.Value, httpClientFactory);
        xeroToken = (XeroOAuth2Token)await client.RefreshAccessTokenAsync(xeroToken);
        TokenUtilities.StoreToken(xeroToken);
      }

      string accessToken = xeroToken.AccessToken;
      string xeroTenantId = xeroToken.Tenants[0].TenantId.ToString();

      var AccountingApi = new AccountingApi();
      var invoicesFilter = "Status == \"SUBMITTED\"";

      var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId, null, invoicesFilter);
      var invoices = response._Invoices;

      List<InvoiceModel> models = new List<InvoiceModel>();

      foreach (var i in invoices)
      {
          models.Add(new InvoiceModel {invoiceId = i.InvoiceID, invoice = i, isChecked = false});
      }

      //return View(invoices);
      return View(models);
    }

    // POST: /InvoiceSync#Create
    [HttpPost]
    public async Task<ActionResult> Create(string Name, string LineDescription, string LineQuantity, string LineUnitAmount, string LineAccountCode)
    {
      var xeroToken = TokenUtilities.GetStoredToken();
      var utcTimeNow = DateTime.UtcNow;

      if (utcTimeNow > xeroToken.ExpiresAtUtc)
      {
        var client = new XeroClient(XeroConfig.Value, httpClientFactory);
        xeroToken = (XeroOAuth2Token)await client.RefreshAccessTokenAsync(xeroToken);
        TokenUtilities.StoreToken(xeroToken);
      }

      string accessToken = xeroToken.AccessToken;
      string xeroTenantId = xeroToken.Tenants[0].TenantId.ToString();

      var contact = new Contact();
      contact.Name = Name;
      
      var line = new LineItem() {
        Description = LineDescription,
        Quantity = decimal.Parse(LineQuantity),
        UnitAmount = decimal.Parse(LineUnitAmount),
        AccountCode = LineAccountCode
      };

      var lines = new List<LineItem>() {
        line
      };

      var invoice = new Invoice() {
        Type = Invoice.TypeEnum.ACCREC,
        Contact = contact,
        Date = DateTime.Today,
        DueDate = DateTime.Today.AddDays(30),
        LineItems = lines,
      };

      var invoiceList = new List<Invoice>();
      invoiceList.Add(invoice);

      var invoices = new Invoices();
      invoices._Invoices = invoiceList;

      var AccountingApi = new AccountingApi();
      var response = await AccountingApi.CreateInvoicesAsync(accessToken, xeroTenantId, invoices);
      
      var updatedUTC = response._Invoices[0].UpdatedDateUTC;

      return RedirectToAction("Index", "InvoiceSync");
    }

    // POST: /InvoiceSync#Submit
    [HttpPost]
    public async Task<ActionResult> Submit(List<InvoiceModel> models) {
      var xeroToken = TokenUtilities.GetStoredToken();
        var utcTimeNow = DateTime.UtcNow;

        if (utcTimeNow > xeroToken.ExpiresAtUtc)
        {
          var client = new XeroClient(XeroConfig.Value, httpClientFactory);
          xeroToken = (XeroOAuth2Token)await client.RefreshAccessTokenAsync(xeroToken);
          TokenUtilities.StoreToken(xeroToken);
        }

        string accessToken = xeroToken.AccessToken;
        string xeroTenantId = xeroToken.Tenants[0].TenantId.ToString();
        Invoices updatedInvoices = new Invoices();
        updatedInvoices._Invoices = new List<Invoice>();
        
        foreach (var invoiceModel in models) {
          var AccountingApi = new AccountingApi();

          Invoices invoices = await AccountingApi.GetInvoiceAsync(accessToken, xeroTenantId, (System.Guid) invoiceModel.invoiceId);
          Invoice invoice = invoices._Invoices[0];

          invoice.Status = Invoice.StatusEnum.SUBMITTED;
          updatedInvoices._Invoices.Add(invoice);
        }

        AccountingApi instance = new AccountingApi();
        
        await instance.UpdateOrCreateInvoicesAsync(accessToken, xeroTenantId, updatedInvoices, false);

        return RedirectToAction("Index", "InvoiceSync");
    }

    // POST: /InvoiceSync#Approve
    [HttpPost]
    public async Task<ActionResult> Approve(List<InvoiceModel> models) {
      var xeroToken = TokenUtilities.GetStoredToken();
        var utcTimeNow = DateTime.UtcNow;

        if (utcTimeNow > xeroToken.ExpiresAtUtc)
        {
          var client = new XeroClient(XeroConfig.Value, httpClientFactory);
          xeroToken = (XeroOAuth2Token)await client.RefreshAccessTokenAsync(xeroToken);
          TokenUtilities.StoreToken(xeroToken);
        }

        string accessToken = xeroToken.AccessToken;
        string xeroTenantId = xeroToken.Tenants[0].TenantId.ToString();
        Invoices updatedInvoices = new Invoices();
        updatedInvoices._Invoices = new List<Invoice>();
        
        foreach (var invoiceModel in models) {
          var AccountingApi = new AccountingApi();

          Invoices invoices = await AccountingApi.GetInvoiceAsync(accessToken, xeroTenantId, (System.Guid) invoiceModel.invoiceId);
          Invoice invoice = invoices._Invoices[0];

          invoice.Status = Invoice.StatusEnum.AUTHORISED;
          updatedInvoices._Invoices.Add(invoice);
        }

        AccountingApi instance = new AccountingApi();
        
        await instance.UpdateOrCreateInvoicesAsync(accessToken, xeroTenantId, updatedInvoices, false);

        foreach (var invoice in updatedInvoices._Invoices) {
          RequestEmpty requestEmpty = new RequestEmpty();
          await instance.EmailInvoiceAsync(accessToken, xeroTenantId, (System.Guid)invoice.InvoiceID, requestEmpty);
        }

        return RedirectToAction("Index", "InvoiceSync");
    }
  }
}