-- Create the EmpDept database
CREATE DATABASE EmpDept;
GO

-- Use the newly created database
USE EmpDept;
GO

-- Create the Departments table
CREATE TABLE Departments (
    DeptId INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    PRIMARY KEY (DeptId)
);
GO

-- Create the Employees table
CREATE TABLE Employees (
    EmpId INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL,
    DeptId INT NOT NULL,
    PRIMARY KEY (EmpId),
    FOREIGN KEY (DeptId) REFERENCES Departments(DeptId)
    ON DELETE NO ACTION -- Prevent deletion of a department with assigned employees
    ON UPDATE CASCADE -- Allow updates to be propagated
);
GO

-- Insert data into the Departments table
INSERT INTO Departments (DeptId, Name) VALUES
(1, 'Marketing'),
(2, 'Accounting'),
(3, 'Finance'),
(4, 'IT');
GO

-- Insert data into the Employees table
INSERT INTO Employees (EmpId, Name, Salary, DeptId) VALUES
(1, 'Mary', 90000, 3),
(3, 'John', 90000, 1),
(7, 'Brian', 80000, 2),
(14, 'Anne', 95000, 4),
(32, 'James', 85000, 1);
GO
