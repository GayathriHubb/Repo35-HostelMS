This is a C# Windows Forms application (100% C#) that provides a comprehensive hostel management system with a SQL Server database backend.

Project Overview
The Hostel Management System is a desktop application designed to manage:

Room management and booking
Member registration and tracking
Employee management and payroll
Fee collection from members

Key Features
1. Authentication & Access Control
Login/Registration System (Form1.cs, SignUp.cs, FrgtPswrd.cs)
User authentication via Form1Login,
Sign-up functionality for new users,
Forgot password recovery
2. Room Management (Rooms.cs)
Add/Create new rooms with status (Active/Inactive),
Search rooms by room number,
Update room status,
Delete rooms,
Track room booking status (available/booked)
3. Member Management
New Members Registration (NewMembers.cs)

Register new hostel members with details (name, phone, email, hometown, ID proof),
Auto-assign room numbers from available rooms,
Automatic member ID generation,
Email validation,
Update booking status when member joins,
Living Members (LivingMembs.cs)

View all currently living members,
Vacant/Leaved Members (VacantMembs.cs)

Track members who have left the hostel,
Update/Delete Members (UpdDelMembs.cs)

Modify member information
Remove member records,
4. Member Fee Management (MembsFees.cs)
Track and manage fee payments from members,
Calculate due fees
5. Employee Management
New Employee Registration (NewEmployee.cs),
Update/Delete Employees (UpdDelEmps.cs),
Working Employees (WorkingEmps.cs),
Leaved Employees (LeavedEmps.cs),
Employee Payment (EmpPayment.cs),
Manage employee salaries and payments,
6. Main Dashboard (MainForm.cs),
Central hub with navigation buttons to all modules,
Quick access to all features,
Logout functionality

Technology Stack:
Language: C# (.NET Framework),
UI Framework: Windows Forms with Guna2 UI components (modern styling),
Database: SQL Server (LocalDB) with MDF file,
Database File: Hostel.mdf and Hostel_log.ldf

Core Components:
HostelFuncs.cs - Database helper class with methods:
  ├── GetConn() - Establishes SQL connection
  ├── GetData() - Executes SELECT queries
  ├── GetCount() - Returns count from queries
  └── SetData() - Executes INSERT/UPDATE queries


File	Purpose
Program.cs	Application entry point - starts with Form1Login,
MainForm.cs	Dashboard with all module navigation,
Rooms.cs	Room CRUD operations,
NewMembers.cs	Register new members,
NewEmployee.cs	Register new employees,
MembsFees.cs	Fee management,
EmpPayment.cs	Employee salary/payment,
HostelFuncs.cs	Database helper functions,
.Designer.cs files	Auto-generated UI/form design files,
.resx files	Resource files for UI elements,
HostelMS.csproj	Project configuration

Database Features |
The application uses a SQL Server database with tables for:

Rooms - Room number, status, booking info |
NewMembers - Member details, room assignment, dates |
Employees - Employee information, salaries |
Fees - Member fee records

Key Highlights
✅ Full CRUD operations (Create, Read, Update, Delete),
✅ Email validation for members,
✅ Automatic ID generation,
✅ Room availability tracking,
✅ Member and employee lifecycle management,
✅ Modern UI with Guna2 components,
✅ Error handling and debugging support

This is a practical, production-ready hostel management solution suitable for hostels, dormitories, or similar accommodation facilities.
