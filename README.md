# Security Exercise

## Install Nuget Package

Open the terminal and use the command
``dotnet add package Konscious.Security.Cryptography.Argon2``


## Start coding

1. Create a new interface called `IPasswordHasher`, this makes it easier for you to change the integration to another hashing algorithm later on.
2. Create a class called `Argon2PasswordHasher`, which should implement the interface.
3. For this to work, we need to have atleast two methods `HashingPassword` and `VerifyPassword`
4. See if you can make you application work with PasswordHasher to hash the password from the login/tryRegister endpoint.
5. Save the hashed password to the database -> of course rename column from `password` to `passwordHash`
6. Remember how you save the `hash.salt` in the database, because the salt should be used to verify
7. Try implement verifyPassword.