# WorldOfWarcraftBestInSlotWebApiApplication

## Overview

WorldOfWarcraftBestInSlotWebApiApplication is a web API designed to help players of World of Warcraft determine the best-in-slot gear for their characters. It provides endpoints for retrieving gear recommendations, managing character profiles, and accessing game-related data.

## Technologies Used

- **ASP.NET Core**: For building the web API.
- **Entity Framework Core**: For database interactions and ORM functionality.
- **PostgreSQL Server**: As the primary database for storing application data.
- **Swagger/OpenAPI**: For API documentation and testing.
- **Git**: For version control and collaboration.
- **Docker**: NOT USED YET.
- **Visual Studio/VS Code**: As the primary development environment.
- **RESTful API Design**: For structuring endpoints and ensuring scalability.

## Features

- Retrieve best-in-slot gear recommendations based on character class and specialization.
- Manage character profiles with customizable settings.


## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/WorldOfWarcraftBestInSlotWebApiApplication.git
    ```
2. Navigate to the project directory:
    ```bash
    cd WorldOfWarcraftBestInSlotWebApiApplication
    ```
3. Install dependencies:
    ```bash
    dotnet restore
    ```
4. Build the application:
    ```bash
    dotnet build
    ```

## Usage

1. Run the application:
    ```bash
    dotnet run
    ```
2. Access the API at `http://localhost:5063` (default port).

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix:
    ```bash
    git checkout -b feature-name
    ```
3. Commit your changes:
    ```bash
    git commit -m "Description of changes"
    ```
4. Push to your branch:
    ```bash
    git push origin feature-name
    ```
5. Open a pull request.
