CRUD app gjord i Blazor.

Element gjorda mha. MudBlazor [https://mudblazor.com/docs/overview]


********************************
**Document**

"/Document" route för att lägga till dokument. 
Dokument läggs till med autoincrement från databasen.
Inline editing på MudTable


********************************
**Problem:**

Snackbar fungerar inte, misstänker någonting o göra med rendermode:t. Kan inte få o fungera som det ska. 
MudSelect funkar inte för /Article. Misstänker något o göra med rendermode. Kan inte få o fungera som det ska.

********************************
**Kör med**
```dotnet ef migrations add <namn på migration>```
```dotnet ef database update```

OBS: Glöm inte att ändra connection string i appsettings.json

exempel på connection string:

```"DPPDB": "Server=localhost;Database=DPPDB;Trusted_Connection=True;TrustServerCertificate=True;"```
