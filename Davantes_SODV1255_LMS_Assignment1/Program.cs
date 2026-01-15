var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// HOME ROUTE
app.MapGet("/", () => "HOME PAGE");

// STAFF 
// Get all staffs
app.MapGet("/staff", () => "GET ALL STAFFS");
// Get a staff by ID
app.MapGet("/staff/{id}", (int id) => $"GET STAFF BY ID:{id}");
// Create a new staff
app.MapPost("/staff", () => "CREATE NEW STAFF");
// Update an existing staff member by ID    
app.MapPut("/staff/{id}", (int id) => $"UPDATE STAFF BY ID: {id}");
// Delete a staff member by ID
app.MapDelete("/staff/{id}", (int id) => $"DELETE STAFF BY ID: {id}");

// READER 
// Get all readers
app.MapGet("/reader", () => "GET ALL READERS");
// Get a reader by ID
app.MapGet("/reader/{id}", (int id) => $"GET READER BY ID: {id}");
// Create a new reader
app.MapPost("/reader", () => "CREATE NEW READER");
// Update a reader by ID    
app.MapPut("/reader/{id}", (int id) => $"UPDATE READER BY ID: {id}");
// Delete a reader by ID
app.MapDelete("/reader/{id}", (int id) => $"DELETE READER BY ID: {id}");

// BOOK
// Get all books
app.MapGet("/book", () => "GET ALL BOOKS");
// Get a book by ID
app.MapGet("/book/{id}", (int id) => $"GET BOOK BY ID: {id}");
// Create a new book
app.MapPost("/book", () => "CREATE NEW BOOK");
// Update a book by ID
app.MapPut("/book/{id}", (int id) => $"UPDATE BOOK BY ID: {id}");
// Delete a book by ID
app.MapDelete("/book/{id}", (int id) => $"DELETE BOOK BY ID: {id}");

// BOOKINGS
// Get all bookings
app.MapGet("/booking", () => "GET ALL BOOKINGS");
// Get a booking by ID
app.MapGet("/booking/{id}", (int id) => $"GET BOOKING BY ID: {id}");
// Create a new booking
app.MapPost("/booking", () => "CREATE NEW BOOKING");
// Update a booking by ID
app.MapPut("/booking/{id}", (int id) => $"UPDATE BOOKING BY ID: {id}");
// Delete a booking by ID
app.MapDelete("/booking/{id}", (int id) => $"DELETE BOOKING BY ID: {id}");





app.Run();
