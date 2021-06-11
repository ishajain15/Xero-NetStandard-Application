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

namespace XeroNetStandardApp.Controllers
{
  public class ContactsInfo : Controller
  {
    private readonly ILogger<AuthorizationController> _logger;
    private readonly IOptions<XeroConfiguration> XeroConfig;
    private readonly IHttpClientFactory httpClientFactory;

    public ContactsInfo(IOptions<XeroConfiguration> XeroConfig, IHttpClientFactory httpClientFactory, ILogger<AuthorizationController> logger)
    {
      _logger = logger;
      this.XeroConfig = XeroConfig;
      this.httpClientFactory = httpClientFactory;
    }

    // GET: /ContactsInfo/
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
      var response = await AccountingApi.GetContactsAsync(accessToken, xeroTenantId);

      var contacts = response._Contacts;

      return View(contacts);
    }

    // GET: /ContactsInfo#Create
    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    // POST: /ContactsInfo#Create
    [HttpPost]
    public async Task<ActionResult> Create(string Name, string EmailAddress, string AccountNumber, string Address1, string Address2, string City, string Region, string PostalCode, string Country)
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
      contact.EmailAddress = EmailAddress;
      contact.AccountNumber = AccountNumber;
      contact.Addresses = new List<Address>();
      contact.Addresses.Add(new Address());
      contact.Addresses[0].AddressType = Address.AddressTypeEnum.POBOX;
      contact.Addresses[0].AddressLine1 = Address1;
      contact.Addresses[0].AddressLine2 = Address2;
      contact.Addresses[0].City = City;
      contact.Addresses[0].Region = Region;
      contact.Addresses[0].PostalCode = PostalCode;
      contact.Addresses[0].Country = Country;

      var contacts = new Contacts();
      contacts._Contacts = new List<Contact>() { contact };

      var AccountingApi = new AccountingApi();
      var response = await AccountingApi.CreateContactsAsync(accessToken, xeroTenantId, contacts);

      return RedirectToAction("Index", "ContactsInfo");
    }
  }
}