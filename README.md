# Integration API with BrasilAPI

This API enables integration with BrasilAPI to retrieve information about banks and addresses by ZIP code.

## Endpoints

### List Banks

Returns a list of all available banks.

* **Endpoint:** `/api/banks`
* **Method:** `GET`
* **Response:** A list of objects representing the banks.

### Get Bank by ID

Returns information about a specific bank based on its ID.

* **Endpoint:** `/api/banks/{id}`
* **Method:** `GET`
* **Parameters:**

  * `id`: The unique identifier of the desired bank.
* **Response:** An object representing the bank corresponding to the provided ID.

### Get Address by ZIP Code

Returns address information based on the provided ZIP code.

* **Endpoint:** `/api/addresses/{zip}`
* **Method:** `GET`
* **Parameters:**

  * `zip`: The ZIP code for which you want to retrieve address information.
* **Response:** An object representing the address corresponding to the provided ZIP code.

## Technologies Used

* .NET 8
* C#
* Automapper
* DTOs
* Interfaces
* Models
* Services
* Swagger
* Dependency Injection
* Generic Response Class

## Usage

To use this API, you can make HTTP requests to the endpoints mentioned above. Here’s an example using cURL:

```bash
# List banks
curl -X GET https://your-api.com/api/banks

# Get bank by ID
curl -X GET https://your-api.com/api/banks/123

# Get address by ZIP code
curl -X GET https://your-api.com/api/addresses/12345678
```
