# thepeer-dotnet

# Usage

### Add Namespace Directive 
```c#
using ThePeer;
```

###Initialize

```c#
var thePeer = new ThePeer("your-secret-key");
thePeer.ChargeLink("lost-in-the-world", 5000, "Benz");
```

## Available Methods 

* ValidateSignature
	* accepts:
		* request (object)
		* signature (string)
	* returns : boolean

```c#
var isValidated = thePeer.ChargeLink(payload, "somestringsignature");
```

* GetSendReceipt
	* accepts:
		* receiptId (string)
	* returns : object

```c#
var response = thePeer.GetSendReceipt("receiptId");
```

* ProcessSendReceipt
	* accepts:
		* receiptId (string)
		* insufficient_funds (bool)
	* returns : object

```c#
var response = thePeer.ProcessSendReceipt("receiptId", false);
```

* IndexUser
	* accepts:
		* name (string)
		* email (string)
		* identifier (string)
	* returns : object

```c#
var response = thePeer.IndexUser("john", "john@ex.com", "identifier");
```

* UpdateUser
	* accepts:
		* receiptId (string)
		* reference (string)
	* returns : object

```c#
var response = thePeer.UpdateUser("receiptId", "reference");
```

* DeleteUser
	* accepts:
		* reference (string)
	* returns : bool

```c#
var response = thePeer.DeleteUser("reference");
```

* GetLink
	* accepts:
		* linkId (string)
	* returns : object

```c#
var response = thePeer.GetLink("linkId");
```

* ChargeLink
	* accepts:
		* linkId (string)
		* amount (integer)
	* returns : object

```c#
var response = thePeer.ChargeLink("linkId", 5000);
```

* AuthorizeDirectCharge
	* accepts:
		* reference (string)
		* insufficient_funds (bool)
	* returns : object

```c#
var response = thePeer.AuthorizeDirectCharge("reference", false);
```

## Extra

Refer to the [Named Link](http://www.google.fr/ "documentation") for more information.
