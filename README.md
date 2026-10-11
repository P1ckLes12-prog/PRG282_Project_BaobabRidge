# Baobab Ridge Wildlife Rehabilitation Centre

A C# Windows Forms application (.NET 8) for recording and managing wild animals in care.

## Team Members
| Name | Student Number | Feature |
|------|----------------|---------|
| Enza Kearney | 603589 | Add Animal |
| Sally Tarmica Handitye | 604298 | View Animal |
| Morgan O'Kennedy | 604199 | Update Animal |
| MAsana Sakala | Summary Report + Git/GitHub |
| Masana Sakala | 600688 | Delete Animal |

## How to Build and Run
1. Clone the repository.
2. Open the `.sln` file in Visual Studio.
3. Press **Ctrl+Shift+B** to build, then **F5** to run.

## Features
- Add a new animal with full validation and auto-classification
- View all animals in a read-only DataGridView
- Update an existing animal via grid selection or ID search
- Delete an animal with confirmation
- Generate a summary report written to `summary.txt`

## File Formats
**animals.txt** — one animal per line, seven pipe-separated fields:
`ID|Name|Species|Age|Score|Status|Housing Unit`

**summary.txt** — regenerated on demand with totals, averages and per-status counts.

## Known Limitations
- (to be added) 