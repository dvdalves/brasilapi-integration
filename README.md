# Integration API with BrasilAPI

This API enables integration with BrasilAPI to retrieve information about banks and addresses by ZIP code.

## Endpoints

### Get All Banks

Returns a list of all available banks.

* **Endpoint:** `/api/banks`
* **Method:** `GET`
* **Response:** A list of objects representing information about the banks.

### Get Bank by Code

Returns information about a specific bank based on its code.

* **Endpoint:** `/api/banks/{code}`
* **Method:** `GET`
* **Parameters:**

  * `code`: The code of the desired bank.
* **Response:** An object representing information about the bank corresponding to the provided code.

### Get Address by ZIP Code

Returns address information based on the provided ZIP code.

* **Endpoint:** `/api/addresses/search/{zip}`
* **Method:** `GET`
* **Parameters:**

  * `zip`: The ZIP code for which you want to retrieve address information.
* **Response:** An object representing information about the address corresponding to the provided ZIP code.

## Technologies Used

* .NET 9
* C#
* Automapper
* DTOs
* Interfaces
* Models
* Services
* Swagger
* Dependency Injection
* Generic Response Class
