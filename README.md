Name Server Check-Up Tool for NOC Team
Overview
The Name Server Check-Up Tool is designed to assist the Network Operations Center (NOC) team in monitoring and verifying the status of name servers. This tool ensures that all name servers are functioning correctly and provides detailed reports on their status.

Features
Automated Checks: Schedule regular checks for name server status.
Detailed Reports: Generate comprehensive reports on the health and performance of name servers.
Alert System: Receive notifications if any name server is down or not responding.
User-Friendly Interface: Easy-to-use interface for managing and viewing name server statuses.
Dependencies
Ruby: The primary programming language used for the tool.
Ruby on Rails: The web application framework used to build the tool.
PostgreSQL: The database system used for storing name server data and reports.
Installation
Clone the Repository:
git clone https://github.com/yourusername/nameserver-checkup-tool.git
cd nameserver-checkup-tool

Install Dependencies: Ensure you have Ruby and Rails installed. Then, run:
bundle install

Set Up the Database: Create and migrate the database:
rails db:create
rails db:migrate

Run the Application: Start the Rails server:
rails server

Access the Tool: Open your web browser and go to http://localhost:3000.
Usage
Add Name Servers:
Navigate to the “Add Name Server” section.
Enter the details of the name servers you want to monitor.
View Reports:
Go to the “Reports” section to view the status and performance of your name servers.
Configure Alerts:
Set up email or SMS alerts to notify you if any name server is down.
Contributing
We welcome contributions! Please follow these steps to contribute:

Fork the repository.
Create a new branch (git checkout -b feature-branch).
Make your changes.
Commit your changes (git commit -m 'Add new feature').
Push to the branch (git push origin feature-branch).
Open a pull request.
License
This project is licensed under the MIT License. See the LICENSE file for details.

