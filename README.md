# CryptoWar
CryptoWar is a class library that wraps the Rijndael Algorithm in a Password crypto utility class. It's developed in C#. It also ships an utility for auto generate passwords. It is an implementation of the Advanced Encryption Standard (AES) adopted by the US government. Now, this repository ships a Net Standard version

## Nuget
You can find this library as a Nuget package: 
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

Just add the reference

    using WarNov.AESManagedWrapper;
or
   

    using WarNov.AESManagedWrapper.NetStandard;

and call the statics methods:

    //Encryption
    var encTxt = RMWCrypto.EncryptStringAES(txt, ss);
    //Decryption     
    var decTxt = RMWCrypto.DecryptStringAES(encTxt, ss);    

The first parameter received is the text to work with. The second is the string with the shared key to work with.

The class PasswordGenerator is also included and with that class you can build passwords automatically (or strong shared-secrets for your encryptions), specifying the amount of characters, the characters to be used, and the possibility of have repetitions in the characters or not.
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