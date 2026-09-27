# LastLogon

VB.NET WinForms utility that queries Active Directory for the newest last-logon time across domain controllers. frmMain can search users, computers, or both under a chosen LDAP root, walks each DC in the domain, and keeps the latest LastLogin value per account. Useful for administrators who need a multi-DC view of when accounts last authenticated.

**Source last updated:** 2007-08-20

| Field | Value |
| --- | --- |
| Language | VB.NET |
| Target | .NET Framework 2.0 |
| Output | WinForms executable |

## Solution structure

| Project | Language | Type | Purpose |
| --- | --- | --- | --- |
| `LastLogon` | VB.NET | WinForms exe | Multi-DC last-logon query UI |

## How to open

Open `LastLogon.sln` in Visual Studio.

## Requirements

- Visual Studio 2005 or 2007
- .NET Framework 2.0
- Domain-joined machine with DirectoryServices access

## Attribution and provenance

Working copy from my Historical Dev folder. No third-party source attribution markers were identified during this review.

## License

MIT. See `LICENSE`.
