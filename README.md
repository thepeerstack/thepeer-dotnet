# ThePeer-dotnet

# Usage

## Installation

Install via .NET CLI

```bash
dotnet add package ThePeer --version 1.0.0
```
Install via Package Manager

```bash
Install-Package ThePeer --version 1.0.0
```

### Add Namespace Directive 
```c#
using ThePeerHQ;
```

###Initialize

```c#
var thePeer = new ThePeer("your-secret-key");
await thePeer.ChargeLink("lost-in-the-world", 5000, "Benz");
```

## Available Methods 

* ValidateSignature
	* accepts:
		* request (object)
		* signature (string)
	* returns : boolean

```c#
var isValidated = ThePeer.ValidateSignature(payload, "somestringsignature");
```

* GetSendReceipt (async)
	* accepts:
		* receiptId (string)
	* returns : object

```c#
var response = await thePeer.GetSendReceipt("receiptId");
```

* ProcessSendReceipt (async)
	* accepts:
		* receiptId (string)
		* event (string)
	* returns : object

```c#
var response = await thePeer.ProcessSendReceipt("receiptId", false);
```

* IndexUser (async)
	* accepts:
		* name (string)
		* email (string)
		* identifier (string)
	* returns : object

```c#
var response = await thePeer.IndexUser("john", "john@ex.com", "identifier");
```

* UpdateUser (async)
	* accepts:
		* receiptId (string)
		* reference (string)
	* returns : object

```c#
var response = await thePeer.UpdateUser("receiptId", "reference");
```

* DeleteUser (async)
	* accepts:
		* reference (string)
	* returns : bool

```c#
var response = await thePeer.DeleteUser("reference");
```

* GetLink (async)
	* accepts:
		* linkId (string)
	* returns : object

```c#
var response = await thePeer.GetLink("linkId");
```

* ChargeLink (async)
	* accepts:
		* linkId (string)
		* amount (integer)
	* returns : object

```c#
var response = await thePeer.ChargeLink("linkId", 5000);
```

* AuthorizeDirectCharge (async)
	* accepts:
		* reference (string)
		* event (string)
	* returns : object

```c#
var response = await thePeer.AuthorizeDirectCharge("reference", false);
```

## Extra

Refer to the [documentation](https://docs.thepeer.co/ "documentation") for more information.
