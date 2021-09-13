# MVC App using Entity Framework with 'Code First' approach

## Potential further improvements

- Improve efficiency (and modularity) by creating separate entities for Address, Telephone and Age, as multiple customers may share the same details.

- Standardise addresses by asking for a post code and building number/name, then using a post code finder to fill in the address fields. This would validate the address and prevent the same address being stored with slight variations.

- Add security measures, e.g. encrypt private data, prevent SQL injection.
