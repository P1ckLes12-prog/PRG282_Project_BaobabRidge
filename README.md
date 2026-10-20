# Baobab Ridge Wildlife Rehabilitation Centre

A C# Windows Forms application (.NET 8) for recording and managing wild animals in care.

## Team Members
| Name | Student Number | Feature |
|------|----------------|---------|
| Enza Kearney | 603589 | Add Animal, Delete Animal |
| Sally Tarmica Handitye | 604298 | View Animal |
| Morgan O'Kennedy | 604199 | Update Animal |
| Masana Sakala | 600688 | Summary Report, GitHub |

## How to Build and Run
1. Clone the repository.
2. Open the `.sln` file in Visual Studio.
3. Press **Ctrl+Shift+B** to build.
4. Press **F5** to run.

## Features
- Add a new animal with full validation and auto-classification
- View all animals in a read-only DataGridView
- Update an existing animal via grid selection or ID search
- Delete an animal with confirmation
- Generate a summary report written to `summary.txt`
- Error handling is done and friendly messages for read-only files, files in use by other programs, and invalid input.

## File Formats
**animals.txt** — one animal per line, seven pipe-separated fields:
`ID|Name|Species|Age|Score|Status|Housing Unit`

**summary.txt** — regenerated on demand with totals, averages and per-status counts.

## Known Limitations
- Windows Only- the application cannot be run by macOS or Linux.
- Only one user can use the application at a time, due to only using plain text storage. Meaning data can become out of date.
- Invalid lines in the animals.txt is skipped rather than displaying inn the grid. The skipped lines are only showing in the View Animals screen.
- Deletion cannot be undone- once the deletion is confirmed the data cannot be retreived.
- The Back buttons open a new main menu rather than returning to the original, so closing the program with the window's close button from a later menu may leave it running in the background.
- The summary screen is not live and the generate button must be selected before a summary is given.
- Age and recovery score must be whole numbers, and names and species are limited to 30 characters.
