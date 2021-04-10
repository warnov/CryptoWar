# CryptAndHash
[Net 5+]
CryptAndHash is a package that ships an enhanced secure password hashing algorith based on the mix of SHA512 and BCrypt. It also offers two way symmetric using (AES - Rijndael Algorithm) and a utility for auto generate passwords.

## Nuget
You can find this library as a Nuget package: 

### Net (5+)
Find it in [Nuget](http://warnov.com/@CryptAndHash)
Or install it directly:  
```
PM>Install-Package CryptAndHash -Version 1.0.0
```

### Older Versions
Older versions of this repository are available in packages for *net framework*, *net standard* and *net 5*, but don't have the hashing utility included:

### Net Framework
Find it in [Nuget](http://warnov.com/@CryptoWarNuget)
Or install it directly:

    PM> Install-Package AESManagedWrapper -Version 1.0.0
### Net Standard
Find it in [Nuget](http://warnov.com/@CryptoWarNugetNS)
Or install it directly:

    PM> Install-Package AESManagedWrapper.NetStandard -Version 1.0.0.1

### Net (5+)
Find it in [Nuget](http://warnov.com/@CryptoWarNugetNet)
Or install it directly:  
```
PM>Install-Package AESManagedWrapper.Net -Version 1.0.1
```


How to Use It:
-----------

### Hashing:



Just add the reference

    using WarNov.CryptAndHash;

and call the static methods:

    var securedPwdInfo = WarBCrypt.SecurePwd(plainPwd, blackPepper, workForceLevel);

* `plainPwd`: The text to hash.
* `blackPepper`: A secret string that won't be stored in the user database but in other secure repository such as *Azure KeyVault*
* `workForceLevel`: Optional integer from 4 to 31. Default: 11 (Ideal if you want to spend ~100ms in the operation). The higher, the more secure the hashing, but the longer execution time. 

After the execution you will have an structure with this data as result:
* `Salt`: An obfuscator string that is mixed to the original pwd to add security. It is ok if you store this element among with the `SecuredPwd` in the same DB.
* `RedPepper`: An obfuscator string that is mixed to the original pwd to add security. It is ok if you store this element among with the `SecuredPwd` and the `Salt` in the same DB. *Note the contrast with the `BlackPepper` that must be stored outside the DB to improve the security*
* `SecuredPwd`: The hashed password that will be stored in the DB. If the DB gets compromised, attackers will have a very hard time trying to decipher the original password.

#### Password Verification
To verify a password, just create a `SecurePwdInfo` structure:
```
    var securedPwdInfo = new SecuredPwdInfo
    {
        RedPepper = redPepper,
        Salt = salt,
        SecuredPwd = hashedPwd
    };
```

All these values will be available in your users DB. And then, call:
    
    var verificationResult = WarBCrypt.Verify(plainPwd, securedPwdInfo, blackPepper);

The `plainPwd` is the one you want to verify. And the `blackPepper`is that secret stored in a secure place apart from the DB.

### Two way symmetric encryption:

Call the static methods:

    //Encryption
    var encTxt = RMWCrypto.EncryptStringAES(txt, ss);
    //Decryption     
    var decTxt = RMWCrypto.DecryptStringAES(encTxt, ss);    

The first parameter received is the text to work with. The second is the string with the shared key to work with.

The class `PasswordGenerator` is also included and with that class you can build passwords automatically (or strong shared-secrets for your encryptions), specifying the amount of characters, the characters to be used, and the possibility of have repetitions in the characters or not.
You can use this class in this way:

  

    private void btnAutogenerate_Click(object sender, EventArgs e)    
    {
    	int value = (int)nudMain.Value;
        PasswordGenerator pg = new PasswordGenerator()
        {
                ConsecutiveCharacters = true,
                Maximum = value,    
                Minimum = value - 1,    
                RepeatCharacters = true    
        };
        txtSS.Text = pg.Generate();
    }

There are also sample projects included for you to learn how to use the library.
<!--stackedit_data:
eyJoaXN0b3J5IjpbLTExMzI5ODUxODJdfQ==
-->