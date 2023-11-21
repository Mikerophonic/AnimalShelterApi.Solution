# AnimalShelter API

This is an example API built with ASP.NET Core.

#### By Michael G Connelly

## Technologies Used

- C#
- ASP.NET Core
- Entity Framework Core



## Description

This project was created as my sixth independent project, "Building an API", in the C# / .Net course at Epicodus. It demonstrates my understanding of building a web API with ASP.NET Core and implementing pagination.

## Setup and Installation

Follow these steps to set up and run the AnimalShelter API locally.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet) installed on your machine.
- SQL Server (or another compatible database) installed.

### Clone the Repository

```bash
git clone https://github.com/Mikerophonic/AnimalShelterApi.Solution.git
```

### Setup database

Create two new files named `appsettings.json` and `appsettings.Development.json` in the project's root directory:

```bash
   $ touch appsettings.json appsettings.Development.json
```

Open the appsettings.json file and insert the following code. Replace [YOUR-USERNAME] and [YOUR-MYSQL-PASSWORD] with your MySQL username and password:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animalshelter_api;uid=[YOUR_USERNAME];pwd=[YOUR_MYSQL_PASSWORD];"
  }
}
```

Open the appsettings.Development.json file and insert the following code.
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

Navigate to the project directory:
```bash
    $ cd AnimalShelterApi
```

<b>Create Database:</b> 
```
$ dotnet ef migrations add Initial
$ dotnet ef database update
```

### Start project server
Start the project in development mode with a watcher using the following command:
```bash
    $ dotnet run
```

Use your program of choice to make API calls. In your API calls, use the domain _http://localhost:5000_. 

## API Documentation

### GET /api/Animals
<table>
    <thead>
      <tr>
        <th>HTTP Verb</th>
        <th>URL</th>
        <th>Expected Behavior</th>
        <th>Response Status</th>
      </tr>
    </thead>
      <tr>
        <td>GET</td>
        <td>/api/Animals</td>
        <td>Returns an array containing all Animal objects in the database.</td>
        <td>200: Ok</td>
      </tr>
</table>

Expected Response:
```json
[
  {
    "animalId": 1,
    "name": "Luna",
    "species": "Cat",
    "age": 2
  },
  {
    "animalId": 2,
    "name": "Rocky",
    "species": "Dog",
    "age": 3
  }
]
```

### GET /api/Animals *with optional parameters for pages
<table>
    <thead>
      <tr>
        <th>HTTP Verb</th>
        <th>URL</th>
        <th>Optional URL Parameters</th>
        <th>Expected Behavior</th>
        <th>Response Status</th>
      </tr>
    </thead>
      <tr>
        <td>GET</td>
        <td>/api/Animals?[PARAMETER PAGE]=[PARAMETER PAGESIZE]</td>
        <td>page (integer) <br> pageSize  </td>
        <td>Returns an array containing all Animal objects in the database depending on the paramaters of what the starting page is and how many animals are on each page.</td>
        <td>200: Ok</td>
      </tr>
</table>

Example Request URL: `GET /api/Animals?page=1&pageSize=5`

Expected Response:

```json
[
  {
    "animalId": 1,
    "name": "Luna",
    "species": "Cat",
    "age": 2
  },
  {
    "animalId": 2,
    "name": "Rocky",
    "species": "Dog",
    "age": 3
  },
  {
    "animalId": 3,
    "name": "Sparkle",
    "species": "Rabbit",
    "age": 1
  },
  {
    "animalId": 4,
    "name": "Ziggy",
    "species": "Parrot",
    "age": 5
  },
  {
    "animalId": 5,
    "name": "Whiskers",
    "species": "Hamster",
    "age": 1
  }
]
```


### GET /api/Animals/{id}
<table>
    <thead>
      <tr>
        <th>HTTP Verb</th>
        <th>URL</th>
        <th>URL Parameter *required</th>
        <th>Expected Behavior</th>
        <th>Response Status</th>
      </tr>
    </thead>
      <tr>
        <td>GET</td>
        <td>/api/Animals/{id}</td>
        <td>id (int)</td>
        <td>Returns a JSON object representing an Animal with an "animalId" property that matches the "id" provided as a URL parameter.</td>
        <td>200: Ok</td>
      </tr>
</table>

Example Request URL: `GET /api/Animals/1`

Expected Response: 

```json
  {
    "animalId": 1,
    "name": "Luna",
    "species": "Cat",
    "age": 2
  },
```

### POST /api/Animals
<table>
    <thead>
      <tr>
        <th>HTTP Verb</th>
        <th>URL</th>
        <th>Request Body *required</th>
        <th>Expected Behavior</th>
        <th>Response Status</th>
      </tr>
    </thead>
      <tr>
        <td>POST</td>
        <td>/api/Animals</td>
        <td>A JSON object containing key-value pairs for: <br> - name(string), <br> - species(string), <br> - age(int) <br> - animalId(int) may be included but regardless of the value provided, it's value will be set by the database when the record is saved.</td>
        <td>Creates a new Animal object in the database.</td>
        <td>201: Created</td>
      </tr>
</table>

Example Request Body *required:

```json
  {
    "name": "Milo",
    "species": "Cat",
    "age": 7
  }
```

Expected Response:

```json
  {
    "animalId": 21,
    "name": "Milo",
    "species": "Cat",
    "age": 7
  }
```

### PUT /api/Animals/{id}
<table>
    <thead>
      <tr>
        <th>HTTP Verb</th>
        <th>URL</th>
        <th>URL Parameter *required</th>
        <th>Request Body *required</th>
        <th>Expected Response</th>
        <th>Response Status</th>
      </tr>
    </thead>
      <tr>
        <td>PUT</td>
        <td>/api/Animals/{id}</td>
        <td>id (int)</td>
        <td>A JSON object containing key-value pairs for: <br> - animalId(int) <br> - name(string), <br> - species(string), <br> - age(int) <br> *Note that the "animalId" must match the "id" provided as a URL parameter.</td>
        <td>No content</td>
        <td>204: No Content</td>
      </tr>
</table>

Example Request Body *required:

```json
  {
    "animalId": 21,
    "name": "Milo",
    "species": "Cat",
    "age": 8
  }
```

### DELETE /api/Animals/{id}
<table>
    <thead>
      <tr>
        <th>HTTP Verb</th>
        <th>URL</th>
        <th>URL Parameter *required</th>
        <th>Expected Behavior</th>
        <th>Response Status</th>
      </tr>
    </thead>
      <tr>
        <td>DELETE</td>
        <td>/api/Animals/{id}</td>
        <td>id (int)</td>
        <td>Deletes an Animal from the database.</td>
        <td>204: No Content</td>
      </tr>
</table>


## Known Bugs

No known bugs.


## License
MIT License

Copyright (c) 2023 Michael Connelly

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.



