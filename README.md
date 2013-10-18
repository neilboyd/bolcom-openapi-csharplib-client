===========================================================================
Overview
===========================================================================
This library supports the standard REST calls of the bol.com Open API v4.

Take note that the library uses JSON.NET for parsing JSON responses to
equivallent C# classes. GZIP is by default enabled.

Catalog:
- Search for products.
- Browse for products.
- Get products.
- Get offers.
- Get product recommendations.
- Get related products (accessories, families).

Account:
- Request to start the process of registering an OAuth token.
- Login with the OAuth token.
- Logout the current session.
- Get the wish list.
- Add product to the wish list.
- Remove item from the wish list.

Basket:
- Get the basket.
- Add offer to the basket.
- Change item quantity in the basket.
- Remove item from the basket.

Utils:
- Ping: Pings the OpenAPI server.


===========================================================================
Requirements
===========================================================================
- .NET Framework 4.5
- JSON.NET 5.0.6


===========================================================================
How-to:
===========================================================================

Please see the integration test project for example usage.
