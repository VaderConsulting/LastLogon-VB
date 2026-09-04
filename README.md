# LastLogon

VB.NET WinForms utility that queries Active Directory for the newest last-logon time across domain controllers. frmMain can search users, computers, or both under a chosen LDAP root, walks each DC in the domain, and keeps the latest LastLogin value per account. Useful for administrators who need a multi-DC view of when accounts last authenticated.

**Source last updated:** 2007-08-20

---

## Contents

- `LastLogon.sln`
- `LastLogon/` - application source and forms

## Attribution and provenance

No third-party source attribution markers were identified during this review.

## Requirements

- Visual Studio 2005

## License

MIT. See `LICENSE`.
