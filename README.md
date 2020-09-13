# CoBoo

**CoBoo** is intended to be a document management and sharing system for individuals and families, and takes its name from [commonplace book](https://en.wikipedia.org/wiki/Commonplace_book), a means of compiling information since antiquity.  

## Goals  
The CoBoo project has three goals: maintainability, survivability and shareability.  

### Maintainability 
To allow individual users and their families to collect and organize digital information important to them _independent of a walled-garden solution_ that locks them into a single vendor or service.  To longer simply rely on _hope_ that Microsoft, Apple, Google or a third party will support a piece of software on older hardware or if their corporate "vision" changes.  This means keeping CoBoo an Open Source effort with equally open dependencies, as well as storing data on the local system in a manner that can be easily parsed by _humans_ and not obfuscated with proprietary storage mechanisms.   

CoBoo will also support file versioning and a robust search interface.  

### Survivability 
To allow users to utilize one or more cloud services to back up important data, without having to manage each individually.  Have 50Gb of storage with Google, 1Gb with Dropbox and 10Gb with another service?  CoBoo will manage that, and let users know when the total amount of space is limited or a backup service is no longer responding.  Users will only have to identify what's important to them.  

## Shareability  
CoBoo will allow users to share files with other _specific_ CoBoo users over P2P (peer-to-peer) networks.  


## Technical Implementation 
CoBoo is to be a cross-platform (Microsoft Windows, Apple OS X, Linux) application.  The backend will be a .NET Core service atop a local SQLite database containing file metadata.  The frontend will be accessible via any modern browser, supported by the Angular framework.  

Each item stored in CoBoo will reside in the local filesystem, accompanied by a human-readable XML metadata file.  As items are updated, so are these metadata files as well as the SQLite database.  These metadata files will accompany their associated content during sharing and cloud storage operations, and in the unlikely event of a database failure can be used to recreate it (and vice-versa).  