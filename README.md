📚 Online Exam System

An Online Exam System built to simplify the process of creating, managing, and taking exams digitally. The system supports multiple roles such as Admin, Instructor, and Student, providing a complete examination workflow from question creation to result evaluation.

🚀 Features
👨‍🏫 Admin / Instructor
Create and manage exams
Add, edit, and delete questions (MCQ / True-False / etc.)
Assign exams to students
Control exam duration and settings
View students' results and analytics
🎓 Student
Register and log in securely
Take assigned exams online
Real-time timer during exams
Automatic submission when time ends
View results after submission
🛠️ Technologies Used
ASP.NET Core MVC (.NET 8)
Entity Framework Core
SQL Server
HTML5 / CSS3
JavaScript
Bootstrap
🏗️ Project Architecture

The system follows MVC (Model-View-Controller) architecture:

Models → Define database structure (Users, Exams, Questions, Answers)
Views → UI for students and instructors
Controllers → Business logic and request handling
🗄️ Database Structure (Overview)
Users (Id, Name, Email, Role, Password)
Exams (Id, Title, Duration, CreatedBy)
Questions (Id, ExamId, Text, Type)
Answers (Id, QuestionId, Text, IsCorrect)
Results (Id, StudentId, ExamId, Score)
⚙️ Installation & Setup
Clone the repository:
git clone https://github.com/your-username/online-exam-system.git
Open the project in Visual Studio
Update database connection string in appsettings.json
Run migrations:
dotnet ef database update
Run the project:
dotnet run
📸 Screenshots (Optional)

Add images here like:

Login Page
Exam Page
Dashboard
Results Page
📌 Future Improvements
Online proctoring (camera monitoring)
Question randomization per student
Time-based auto-save answers
Email notifications
Mobile app version (Flutter)
👨‍💻 Authors
Mahmoud Saber Attia and samer ramses
GitHub: github.com/mahmoudssaber
GitHub: github.com/Samer-Ramses
