# Bike Rental and Inventory Management System

Welcome to the collaborative Bike Rental and Inventory Management System project! This application combines the functionalities of a bike rental system and an inventory management system to provide an efficient solution for managing bikes, customers, inventory items, and more.

This project is the collaboration between the two projects Bike rentals and Inventory Management, where the items and bike tables could be merged into one to display the bike details and could be used to manage the inventory for the business.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Future Scope](#future-scope)
- [Contributors](#contributors)
- [License](#license)

## Features

### Bike Rental (Shubham Mishra)

- Create, read, update, and delete customers
- Create, read, update, and delete bikes
- Create, read, update, and delete rentals
- One-to-many relationships between customers-rentals and bikes-rentals

### Inventory Management (Khyati Sethi)

- Create, read, update, and delete inventory items
- Create, read, update, and delete locations
- Manage inventory for bike parts and items
- One-to-many relationship between items-locations

## Technologies Used

- ASP.NET MVC 5: Web application framework for structuring the application
- ASP.NET Web API: Web API controller for providing data via APIs
- Entity Framework: Code-First Migration for database schema management
- LINQ: Data querying and manipulation
- MySQL: Relational database management system
- Views: User interface for interacting with the system

## Installation

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Ensure you have the required tools and packages installed, such as Entity Framework and MySQL connectors.
4. Configure your MySQL connection string in the appropriate configuration files.
5. Run migrations to create the database schema.

## Usage

1. Launch the application from your browser.
2. Navigate through the different sections for bike rentals and inventory management.
3. Perform CRUD operations for customers, bikes, rentals, inventory items, and locations.
4. Explore the integrated functionalities of both systems.

## Future Scope

1. **Mobile Application:** Develop a mobile app for convenient bike rental and inventory management on the go.
2. **Maintenance Management:** Implement a system to track bike maintenance schedules and improve maintenance processes.
3. **Analytics and Reporting:** Integrate advanced analytics and reporting tools for data-driven decision-making.

## Contributors

- Shubham Mishra (Bike Rental)
- Khyati Sethi (Inventory Management)

Feel free to contact us for any questions or contributions to the project.

## License

This project is licensed under the [MIT License](LICENSE).
