using EFPrac;
using EFPrac.Models;

var dbcontextFactory = new EFCoreDBContextFactory();
var context = dbcontextFactory.CreateDbContext(new string[] {});


// Add a new student
var newStudent = new Student { Name = "New Name", Address = "New Address" };
context.Students.Add(newStudent);
context.SaveChanges();

// Delete a student
var studentToDelete = context.Students.FirstOrDefault(x => x.Name == "Delete his student");
if (studentToDelete != null)
{
	context.Students.Remove(studentToDelete);
	context.SaveChanges();
}

// Update a student
var studentToUpdate = context.Students.FirstOrDefault(x => x.Name == "Old Name");
if (studentToUpdate != null)
{
	studentToUpdate.Name = "New Name";
	context.SaveChanges();
}